using LetsLearn.Data;
using LetsLearn.Models;
using LetsLearn.Repos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using LetsLearn.ViewModels;
using LetsLearn.Helpers;

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
                model.Medie = user.Average;
                models.Add(model);

            }

            @ViewBag.clasa = clasa;
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
            model.Medie = user.Average;
            model.Image = user.Image;

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
        public async Task<IActionResult> SeePoints(string id)
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
            model.Medie = user.Average;
            model.Image = user.Image;

            Collection<GradeModel> models = new Collection<GradeModel>();

            foreach (var grade in grades.Result)
            {
                GradeModel grademodel = new GradeModel();
                grademodel.Value = grade.Value;
                grademodel.Week = grade.Week;
                grademodel.Date = grade.Date;
                if (grade.Homework == "⌧")
                    grademodel.Homework = grade.Homework;
                else
                {
                    if (_userRepository.GetById<GridExercice>(grade.Homework).Result == null)
                    {
                        if (_userRepository.GetById<Problem>(grade.Homework).Result == null)
                        {
                            if (_userRepository.GetById<Exercice>(grade.Homework).Result != null)
                            {
                                var homework = _userRepository.GetById<Exercice>(grade.Homework);

                                grademodel.Homework = homework.Result.Title.ToString();
                            }
                            else
                            {
                                grademodel.Homework = "-";
                            }
                        }
                        else
                        {
                            var homework = _userRepository.GetById<Problem>(grade.Homework);
                            grademodel.Homework = homework.Result.Title.ToString();
                        }

                    }
                    else
                    {
                        var homework = _userRepository.GetById<GridExercice>(grade.Homework);
                        grademodel.Homework = homework.Result.Title.ToString();
                    }
                }
                models.Add(grademodel);
            }

            StudentDetailViewModel studentDetail = new StudentDetailViewModel();
            studentDetail.grades = models;
            studentDetail.student = model;

            return View(studentDetail);


        }

        [HttpGet]
        public async Task<IActionResult> AddGrade(string id)
        {
            var user = await _userRepository.GetById<User>(id);

            AddGradesViewModel addGrades = new AddGradesViewModel();

            ClasaModel model = new ClasaModel();
            model.Class = user.Clasa.ToString();
            model.FirstName = user.FirstName.ToString();
            model.LastName = user.LastName.ToString();
            model.Id = user.Id.ToString();
            model.EmailAddress = user.EmailAddress.ToString();
            model.UserName = user.UserName.ToString();
            model.Medie = user.Average;
            model.Image = user.Image;

            addGrades.student = model;
            addGrades.grade = new GradeModel();

            @ViewBag.StudId = id;
            return View(addGrades);

        }

        [HttpPost]
        public async Task<IActionResult> AddGrade(string id, AddGradesViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.grade.Homework.Equals("true"))
                {
                    var grade = new Grade(model.grade.Value, model.grade.Date, model.grade.Week, "🗹", id);
                    _userRepository.Create<Grade>(grade);
                    _userRepository.Save();
                    return RedirectToAction("StudentDetail", new { id = id });
                }
                else
                {
                     var grade = new Grade(model.grade.Value, model.grade.Date, model.grade.Week, "⌧", id);
                    _userRepository.Create<Grade>(grade);
                    _userRepository.Save();
                    return RedirectToAction("StudentDetail", new { id = id });
                }
                
            }
            else
            {
                AddGradesViewModel addGrades = new AddGradesViewModel();
                

                @ViewBag.StudId = id;
                var user = await _userRepository.GetById<User>(id);

                ClasaModel mod = new ClasaModel();
                mod.Class = user.Clasa.ToString();
                mod.FirstName = user.FirstName.ToString();
                mod.LastName = user.LastName.ToString();
                mod.Id = user.Id.ToString();
                mod.EmailAddress = user.EmailAddress.ToString();
                mod.UserName = user.UserName.ToString();
                mod.Medie = user.Average;
                mod.Image = user.Image;

                model.student = mod;

                return View(model);
            }
           
        }
        [HttpGet]
        public IActionResult GridExercice(string clasa)
        {
            @ViewBag.Clasa = Request.Cookies["clasa"].ToString();
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> GridExercice(GridExerciceModel model)
        {
            if (ModelState.IsValid)
            {
                string clasa = Request.Cookies["clasa"].ToString();
                var homework = new GridExercice(model.Title, model.Container, model.CorrectAnswer , model.Answer1,
                    model.Answer2, model.Answer3, model.Week, model.DateStart, model.DateEnd, clasa);
                _userRepository.Create<GridExercice>(homework);
                _userRepository.Save();

                return RedirectToAction("Clasa", "Class");
            }


            return View(model);
        }



        [HttpGet]
        public IActionResult Exercice(string clasa)
        {
            @ViewBag.Clasa = Request.Cookies["clasa"].ToString();
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Exercice(ExerciceModel model)
        {
            if (ModelState.IsValid)
            {
                string clasa = Request.Cookies["clasa"].ToString();
                var homework = new Exercice(model.Title, model.Container, model.CorrectAnswer, model.FinallyAnswer,
                    model.Week, model.DateStart, model.DateEnd, clasa);
                _userRepository.Create<Exercice>(homework);
                _userRepository.Save();

                return RedirectToAction("Clasa", "Class");
            }


            return View(model);
        }


        [HttpGet]
        public IActionResult Problem(string clasa)
        {
            @ViewBag.Clasa = Request.Cookies["clasa"].ToString();
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Problem(ProblemModel model)
        {
            if (ModelState.IsValid)
            {
                string clasa = Request.Cookies["clasa"].ToString();
                var homework = new Problem(model.Title, model.Container,model.ProblemData, model.CorrectAnswer, model.FinallyAnswer,
                    model.Week, model.DateStart, model.DateEnd, clasa);
                _userRepository.Create<Problem>(homework);
                _userRepository.Save();

                return RedirectToAction("Clasa", "Class");
            }


            return View(model);
        }


        [HttpGet]
        public async Task<IActionResult> SendEmail(string id)
        {
            var user = await _userRepository.GetById<User>(id);

            SendEmailViewModel sendEmail = new SendEmailViewModel();

            ClasaModel model = new ClasaModel();
            model.Class = user.Clasa.ToString();
            model.FirstName = user.FirstName.ToString();
            model.LastName = user.LastName.ToString();
            model.Id = user.Id.ToString();
            model.EmailAddress = user.EmailAddress.ToString();
            model.UserName = user.UserName.ToString();
            model.Medie = user.Average;
            model.Image = user.Image;

            sendEmail.Student = model;


            if (Request.Cookies.ContainsKey("Id"))
            {
                string idTeacher = Request.Cookies["Id"].ToString();
                User teacher = await _userRepository.GetById<User>(idTeacher);
                @ViewBag.email = teacher.EmailAddress;
            }

            @ViewBag.StudId = id;
            return View(sendEmail);

        }

        [HttpPost] public async Task<IActionResult> SendEmail (SendEmailViewModel smodel, string id)
        {

            if(ModelState.IsValid)
            {
                if (MailHelper.Send(smodel.Contact.FromEmailAddress.ToString(), smodel.Contact.ToEmailAddress, smodel.Contact.Subject.ToString(),
                smodel.Contact.Continut.ToString()))
            {
                @ViewBag.msg = "Mesaj trimis cu Success";

                }
            else
            {
                @ViewBag.msg = "Ceva nu a mers. Incearca din nou";
            }

            }

            var user = await _userRepository.GetById<User>(id);

            SendEmailViewModel sendEmail = new SendEmailViewModel();

            ClasaModel model = new ClasaModel();
            model.Class = user.Clasa.ToString();
            model.FirstName = user.FirstName.ToString();
            model.LastName = user.LastName.ToString();
            model.Id = user.Id.ToString();
            model.EmailAddress = user.EmailAddress.ToString();
            model.UserName = user.UserName.ToString();
            model.Medie = user.Average;
            model.Image = user.Image;

            sendEmail.Student = model;


            if (Request.Cookies.ContainsKey("Id"))
            {
                string idTeacher = Request.Cookies["Id"].ToString();
                User teacher = await _userRepository.GetById<User>(idTeacher);
                @ViewBag.email = teacher.EmailAddress;
            }

            sendEmail.Contact = null;

            return View(sendEmail);

        }

    }
}