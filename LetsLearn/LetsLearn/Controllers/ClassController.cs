using LetsLearn.Data;
using LetsLearn.Models;
using LetsLearn.Repos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using LetsLearn.ViewModels;

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
            Collection<ClasaModel> models = new Collection<ClasaModel>();

            string clasa = Request.Cookies["clasa"].ToString();
            Task<ICollection<User>> users = _userRepository.Find<User>(s => s.Clasa.Equals(clasa));

            foreach (var user in users.Result)
            {
                ClasaModel model = new ClasaModel();
                model.Class = user.Clasa.ToString();
                model.FirstName = user.FirstName.ToString();
                model.LastName = user.LastName.ToString();
                model.Id = user.Id.ToString();
                model.EmailAddress = user.EmailAddress.ToString();
                model.UserName = user.UserName.ToString();
                models.Add(model);

            }

            return View(models);
        }

        [HttpGet]
        public async Task<IActionResult> StudentDetail(string id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var user = await _userRepository.GetById<User>(id);
            Task<ICollection<Grade>> grades = _userRepository.Find<Grade>(s => s.StudentId == id);

            ClasaModel model = new ClasaModel();
            model.Class = user.Clasa.ToString();
            model.FirstName = user.FirstName.ToString();
            model.LastName = user.LastName.ToString();
            model.Id = user.Id.ToString();
            model.EmailAddress = user.EmailAddress.ToString();
            model.UserName = user.UserName.ToString();

            Collection<GradeModel> models = new Collection<GradeModel>();

            foreach (var grade in grades.Result)
            {
                GradeModel grademodel = new GradeModel();
                grademodel.Value = grade.Value;
                grademodel.Week = grade.Week;
                grademodel.Date = grade.Date;
                models.Add(grademodel);
            }

            StudentDetailViewModel studentDetail = new StudentDetailViewModel();
            studentDetail.grades = models;
            studentDetail.student = model;

            return View(studentDetail);




        }


        [HttpGet]
        public  IActionResult AddGrade(string id)
        {
            @ViewBag.StudId = id;
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> AddGrade(string id, GradeModel model)
        {
            if (ModelState.IsValid)
            {
                var grade = new Grade(model.Value, model.Date, model.Week, model.Homework, id);
                _userRepository.Create<Grade>(grade);
                _userRepository.Save();


            }

           
            return RedirectToAction("StudentDetail", new{id = id});
        }

    }
}