using LetsLearn.Data;
using LetsLearn.Repos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LetsLearn.Controllers
{
    public class ClassController : Controller
    {
        private IRepository _userRepository;

        public ClassController(IRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult Clasa()
        {
            string clasa = Request.Cookies["clasa"].ToString();
            Task<ICollection<User>> users = _userRepository.Find<User>(s => s.Clasa.Equals(clasa));

            return View(users);
        }

      


    }
}