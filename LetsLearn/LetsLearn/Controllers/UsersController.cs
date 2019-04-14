using LetsLearn.Data;
using LetsLearn.Models;
using LetsLearn.Repos;
using LetsLearn.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LetsLearn.Controllers
{
    public class UsersController : Controller
    {
        private IRepository _userRepository;
        private readonly IHostingEnvironment hostingEnvironment;


        public UsersController(IRepository userRepository, IHostingEnvironment environment)
        {
            _userRepository = userRepository;

            hostingEnvironment = environment;
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

        [HttpGet]
        public IActionResult Student()
        {
            if (Request.Cookies.ContainsKey("Id"))
            {
                string Id = Request.Cookies["Id"].ToString();
                Task<User> user = _userRepository.GetById<User>(Id);
                if (user.Result.IsTeacher==true)
                {
                    @ViewBag.teacher = user.Result.FirstName.ToString() + " " + user.Result.LastName.ToString();
                    return RedirectToAction("Teacher", "Users");
                }
                else
                {

                    @ViewBag.student = user.Result.FirstName.ToString() + " " + user.Result.LastName.ToString();

                    StudentModel model = new StudentModel
                    {
                        Class = user.Result.Clasa,
                        FirstName = user.Result.FirstName,
                        LastName = user.Result.LastName,
                        Id = user.Result.Id,
                        EmailAddress = user.Result.EmailAddress.ToString(),
                        UserName = user.Result.UserName.ToString(),
                        Image = user.Result.Image.ToString()

                    };

                    Collection<GradeModel> models = new Collection<GradeModel>();
                    Task<ICollection<Grade>> grades = _userRepository.Find<Grade>(s => s.StudentId == Id);

                    foreach (var grade in grades.Result)
                    {
                        GradeModel grademodel = new GradeModel();
                        grademodel.Value = grade.Value;
                        grademodel.Week = grade.Week;
                        grademodel.Date = grade.Date;
                        models.Add(grademodel);
                    }

                    StudentViewModel studentDetail = new StudentViewModel();
                    studentDetail.grades = models;
                    studentDetail.student = model;

                    return View(studentDetail);
                }
                
            }
            else
            {
                return RedirectToAction("LogIn", "Account");
            }

        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            EditProfileModel model = new EditProfileModel();
            var user = await _userRepository.GetById<User>(id);
            if (user == null)
            {
                return NotFound();
            }
            else
            {
                model.FirstName = user.FirstName;
                model.LastName = user.LastName;
                model.Id = user.Id;
                model.EmailAddress = user.EmailAddress.ToString();
                model.UserName = user.UserName.ToString();
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, EditProfileModel model)
        {

            User user = await _userRepository.GetById<User>(id);

            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    user.EmailAddress = model.EmailAddress;
                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName;
                    user.UserName = model.UserName;
                    if (model.Image != null)
                    {
                        var fileImage = Path.Combine(hostingEnvironment.WebRootPath, Path.GetFileName("Images"),
                            Path.GetFileName(model.Image.FileName));
                        model.Image.CopyTo(new FileStream(fileImage, FileMode.Create));
                        var path = "/Images/" + Path.GetFileName(model.Image.FileName);
                        user.Image = path;
                    }


                    _userRepository.Update(user);
                    _userRepository.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    List<User> users = (List<User>)await _userRepository.GetAll<User>();
                    bool ok = false;
                    foreach (var i in users)
                    {
                        if (i.Id == user.Id)
                        {
                            ok = true;
                        }
                    }
                    if (ok==false)
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Student","Users");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Teacher()
        {
            String Id = Request.Cookies["Id"].ToString();
            Task<User> user = _userRepository.GetById<User>(Id);
            @ViewBag.teacher = user.Result.FirstName.ToString() + " " + user.Result.LastName.ToString();

            TeacherModel teacher = new TeacherModel();
            teacher.Id = user.Result.Id;
            teacher.FirstName = user.Result.FirstName;
            teacher.LastName = user.Result.LastName;
            teacher.EmailAddress = user.Result.EmailAddress;
            teacher.Image = user.Result.Image;
            teacher.UserName = user.Result.UserName;
            
            return View(teacher);

        }

        [HttpPost]
        public async Task<IActionResult> Choose_class(TeacherModel model)
        {

            if (model.clasa != null)
            {
                CookieOptions classCookie = new CookieOptions();

                classCookie.IsEssential = true;
                classCookie.Expires = DateTimeOffset.Now.AddDays(2);
                Response.Cookies.Append("clasa", model.clasa, classCookie);

                return RedirectToAction("Clasa", "Class");
            }

            return RedirectToAction("Teacher", "Users");
        }



       

       
    }
}