using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using LetsLearn.Data;
using LetsLearn.Models;
using LetsLearn.Repos;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using Microsoft.AspNetCore.Http;
using System.Net;
using Microsoft.AspNetCore.Hosting;

namespace LetsLearn.Controllers
{
    public class AccountController : Controller
    {
        private IRepository _userRepository;
        private readonly IHostingEnvironment hostingEnvironment;


        public AccountController(IRepository userRepository, IHostingEnvironment environment)
        {
            _userRepository = userRepository;

            hostingEnvironment = environment;
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();

        }

        static string ComputeSha256Hash(string rawData)
        { 
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
           
            if (ModelState.IsValid)
            {
                bool ok = false;
                List<User> users = (List<User>)await _userRepository.GetAll<User>();
                foreach (var i in users)
                {
                    if (i.UserName == model.UserName)
                    {
                        ok = true;
                        @ViewBag.UserName = "Acest nume de utilizator exista deja in baza de date";
                        return View();
                    }
                    if (i.EmailAddress == model.EmailAddress)
                    {
                        ok = true;
                        @ViewBag.EmailAddress = "Acest email exista deja in baza de date";
                        return View();
                    }
                }
                if (Helpers.MailHelper.Send("LearningMath", model.EmailAddress, "Creare cont",
                        "Contul tău a fost creat cu succes! Mulțumim pentru colaborare!") == false)
                {
                    ok = true;
                    @ViewBag.EmailAddress = "Adresa de email este invalida";
                    return View();
                }

                if (ok == false)
                {
                    User user = new User();
                    if (model.Class.ToString() == "-")
                    {
                        if (model.Image == null)
                        {
                            user = new User
                            (model.FirstName, model.LastName, model.UserName, ComputeSha256Hash(model.Password),
                                model.EmailAddress, model.IsTeacher, null,"/Images/anonim.jpg", 0);
                        }
                        else
                        {
                            var fileImage = Path.Combine(hostingEnvironment.WebRootPath, Path.GetFileName("Images"),
                                Path.GetFileName(model.Image.FileName));
                            model.Image.CopyTo(new FileStream(fileImage, FileMode.Create));
                            user = new User
                            (model.FirstName, model.LastName, model.UserName, ComputeSha256Hash(model.Password),
                                model.EmailAddress, model.IsTeacher, null, "/Images/" + Path.GetFileName(model.Image.FileName), 0);

                        }

                        _userRepository.Create<User>(user);
                        _userRepository.Save();
                    }
                    else
                    {
                        if (model.Image == null)
                        {
                            user = new User
                            (model.FirstName, model.LastName, model.UserName, ComputeSha256Hash(model.Password),
                                model.EmailAddress, model.IsTeacher, model.Class.ToString(), "/Images/anonim.jpg", 0);
                        }
                        else
                        {
                            var fileImage = Path.Combine(hostingEnvironment.WebRootPath, Path.GetFileName("Images"),
                                Path.GetFileName(model.Image.FileName));
                            model.Image.CopyTo(new FileStream(fileImage, FileMode.Create));

                            var path = "/Images/" + Path.GetFileName(model.Image.FileName);
                            user = new User
                            (model.FirstName, model.LastName, model.UserName, ComputeSha256Hash(model.Password),
                                model.EmailAddress, model.IsTeacher, model.Class.ToString(), path, 0 );
                        }

                        _userRepository.Create<User>(user);
                        _userRepository.Save();

                    }

                    CookieOptions cookieOptions = new CookieOptions();
                    cookieOptions.IsEssential = true;
                    Response.Cookies.Append("userName", model.UserName, cookieOptions);
                    Response.Cookies.Append("pasword", ComputeSha256Hash(model.Password), cookieOptions);
                    Response.Cookies.Append("Id", user.Id, cookieOptions);
                    if (model.IsTeacher == true)
                    {

                        return RedirectToAction("Teacher", "Users");
                    }
                    else
                    {
                        return RedirectToAction("Student", "Users");
                    }

                }

            }

            return View();
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            return View();

        }

        [HttpGet]
        public IActionResult LogOut()
        {
            Response.Cookies.Delete("Id");
            return RedirectToAction("LogIn");


        }
       

        [HttpPost]
        public async Task<IActionResult> LogIn (LogInModel model)
        {

            if (ModelState.IsValid)
            {


                List<User> users = (List<User>) await _userRepository.GetAll<User>();
                foreach (var i in users)
                {
                    if (i.UserName == model.UserName)
                    {
                        string pass = ComputeSha256Hash(model.Password);


                        if (i.Password == pass)
                        {
                            CookieOptions cookieOptions = new CookieOptions();
                            
                            cookieOptions.IsEssential = true;
                            if (model.Remember)
                            {
                                cookieOptions.Expires = DateTimeOffset.Now.AddDays(2);
                                Response.Cookies.Append("userName", i.UserName,cookieOptions);
                                Response.Cookies.Append("pasword", pass, cookieOptions);
                                Response.Cookies.Append("Id", i.Id, cookieOptions);
                                
                            }
                            else
                            {
                                
                                Response.Cookies.Append("userName", model.UserName,cookieOptions);
                                Response.Cookies.Append("pasword", pass, cookieOptions);
                                Response.Cookies.Append("Id", i.Id,cookieOptions);
                            }

                            if (i.IsTeacher)
                            {
                                return RedirectToAction("Teacher", "Users");
                            }
                            else
                            {
                                return RedirectToAction("Student", "Users");
                            }
                            
                        }
                    }

                }
           

            }
            

            return View();
        }

        public IActionResult ReadCookie()
        {
            ViewBag.value = Request.Cookies["userName"].ToString();
            return View();

        }
    }
}