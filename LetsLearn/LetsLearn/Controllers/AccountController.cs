﻿using System;
using System.Collections.Generic;
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

namespace LetsLearn.Controllers
{
    public class AccountController : Controller
    {
        private IRepository _userRepository;

        public AccountController(IRepository userRepository)
        {
            _userRepository = userRepository;
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
                        return View();
                    }
                }

                if (ok == false)
                {
                  
                    User user = new User
                    (model.FirstName, model.LastName, model.UserName, ComputeSha256Hash(model.Password),
                        model.EmailAddress, model.IsTeacher);

                    _userRepository.Create<User>(user);
                    _userRepository.Save();
                    if (model.IsTeacher)
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