using LetsLearn.Data;
using LetsLearn.Models;
using LetsLearn.Repos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace LetsLearn.Controllers
{
    public class UsersController : Controller
    {
        private IRepository _userRepository;

        public UsersController(IRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult Student()
        {
            String Id = Request.Cookies["Id"].ToString();
            Task<User> user = _userRepository.GetById<User>(Id);
            @ViewBag.student = user.Result.FirstName.ToString() + " " + user.Result.LastName.ToString();

            return View();

        }

        [HttpGet]
        public IActionResult Teacher()
        {
            String Id = Request.Cookies["Id"].ToString();
            Task<User> user = _userRepository.GetById<User>(Id);
            @ViewBag.teacher = user.Result.FirstName.ToString() + " " + user.Result.LastName.ToString();


            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Choose_class(TeacherModel model)
        {
            if (ModelState.IsValid)
            {

                if (model.clasa != null)
                {
                    CookieOptions classCookie = new CookieOptions();

                    classCookie.IsEssential = true;
                    classCookie.Expires = DateTimeOffset.Now.AddDays(2);
                    Response.Cookies.Append("clasa", model.clasa, classCookie);
                    
                    return RedirectToAction("Clasa", "Class");
                }
                
            }

            return View();
        }
    }
}