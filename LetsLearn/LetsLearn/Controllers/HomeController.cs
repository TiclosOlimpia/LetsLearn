using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LetsLearn.Models;
using LetsLearn.Data;
using LetsLearn.Helpers;
using LetsLearn.Repos;
using MimeKit;
using MailKit.Net.Smtp;
using EASendMail;
using SmtpClient = System.Net.Mail.SmtpClient;

namespace LetsLearn.Controllers
{
    public class HomeController : Controller
    {
        private IRepository _context;

        public HomeController(IRepository userRepository)
        {
            _context = userRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Contact()
        {
            if (Request.Cookies.ContainsKey("Id"))
            {
                string id = Request.Cookies["Id"].ToString();
                User user = await _context.GetById<User>(id);
                @ViewBag.email = user.EmailAddress;
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Contact(ContactModel model)
        {

            if(MailHelper.Send(model.FromEmailAddress.ToString(), "me", model.Subject.ToString(),
                model.Continut.ToString()))
            { 
                @ViewBag.msg = "Success";
            }
            else
            {
                @ViewBag.msg = "Eroare";
            } 
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
