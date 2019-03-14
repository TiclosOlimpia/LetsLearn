using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LetsLearn.Data;
using LetsLearn.Models;
using LetsLearn.Repos;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;

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
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
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
                User user = new User
                    (model.FirstName, model.LastName, model.EmailAddress, ComputeSha256Hash(model.Password), model.EmailAddress);

                _userRepository.Create<User>(user);
                _userRepository.Save();
                return RedirectToAction("Index", "Home");

            }

            return View();
        }
    }
}