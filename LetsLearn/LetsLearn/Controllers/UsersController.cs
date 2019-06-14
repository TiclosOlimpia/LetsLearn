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
using LetsLearn.Migrations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.Linq;

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
                if (user.Result.IsTeacher == true)
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
                @ViewBag.img = user.Image;
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
                    List<User> users = (List<User>) await _userRepository.GetAll<User>();
                    bool ok = false;
                    foreach (var i in users)
                    {
                        if (i.Id == user.Id)
                        {
                            ok = true;
                        }
                    }

                    if (ok == false)
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction("Student", "Users");
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

            Collection<ClasaModel> models = new Collection<ClasaModel>();


            List<string> clases = new List<string>
            {
                "clasa I A", "clasa I B", "clasa a II-a A", "clasa a II-a B", "clasa a III-a A", "clasa a III-a B",
                "clasa a IV-a A", "clasa a IV-a B"
            };


            foreach (var clasa in clases)
            {


                Task<ICollection<User>> users = _userRepository.Find<User>(s => s.Clasa.Equals(clasa));

                var Suma = 0;
                var NrTemeNecorectate = 0;

                foreach (var use in users.Result)
                {


                    var SumaNote = 0;
                    var NrNoteActivitate = 0;
                    Task<ICollection<Grade>> grades = _userRepository.Find<Grade>(s => s.StudentId == use.Id);
                    foreach (var grade in grades.Result)
                    {
                        SumaNote += grade.Value;
                        if (grade.Homework == "⌧")
                        {
                            NrNoteActivitate++;
                        }
                    }

                    Task<ICollection<GridExercice>> Grils =
                        _userRepository.Find<GridExercice>(s => s.Clasa == use.Clasa);

                    NrNoteActivitate += Grils.Result.Count;


                    Task<ICollection<Exercice>> exercices =
                        _userRepository.Find<Exercice>(s => s.Clasa == use.Clasa);

                    NrNoteActivitate += exercices.Result.Count;

                    Task<ICollection<Problem>> Problems =
                        _userRepository.Find<Problem>(s => s.Clasa == use.Clasa);

                    NrNoteActivitate += Problems.Result.Count;

                    if (NrNoteActivitate == 0)
                    {
                        use.Average = 10;
                    }
                    else
                    {
                        use.Average = (float) Math.Round(((double) SumaNote / NrNoteActivitate), 4);
                    }

                    _userRepository.Update<User>(use);
                    _userRepository.Save();

                    if (use.Average >= 5)
                    {
                        Suma++;
                    }

                    var homeworks =
                        _userRepository.Find<SolvedHomework>(s => s.StudentId.ToString() == use.Id.ToString());
                    foreach (var homework in homeworks.Result)
                    {
                        grades = _userRepository.Find<Grade>(s => s.StudentId == use.Id && s.TeacherId==Id);
                        int ok = 0;
                        foreach (var grade in grades.Result)
                        {
                            if (grade.Homework == homework.HomeworkId)
                                ok = 1;
                        }

                        if (ok == 0)
                        {
                            NrTemeNecorectate++;
                        }
                    }

                }


                string procent;
                if (users.Result.Count == 0)
                {
                    procent = "100 %";
                }
                else
                {
                    procent = Math.Round((double) Suma * 100 / users.Result.Count, 2).ToString() + " %";
                }






                if (clasa == "clasa I A")
                {
                    @ViewBag.procentClasaIA = procent;
                    @ViewBag.temeIA = NrTemeNecorectate;
                }
                else if (clasa == "clasa I B")
                {
                    @ViewBag.procentClasaIB = procent;
                    @ViewBag.temeIB = NrTemeNecorectate;
                }
                else if (clasa == "clasa a II-a A")
                {
                    @ViewBag.procentClasaIIA = procent;
                    @ViewBag.temeIIA = NrTemeNecorectate;
                }
                else if (clasa == "clasa a II-a B")
                {
                    @ViewBag.procentClasaIIB = procent;
                    @ViewBag.temeIIB = NrTemeNecorectate;
                }
                else if (clasa == "clasa a III-a A")
                {
                    @ViewBag.procentClasaIIIA = procent;
                    @ViewBag.temeIIIA = NrTemeNecorectate;
                }
                else if (clasa == "clasa a III-a B")
                {
                    @ViewBag.procentClasaIIIB = procent;
                    @ViewBag.temeIIIB = NrTemeNecorectate;
                }
                else if (clasa == "clasa a IV-a A")
                {
                    @ViewBag.procentClasaIVA = procent;
                    @ViewBag.temeIVA = NrTemeNecorectate;
                }
                else if (clasa == "clasa a IV-a B")
                {
                    @ViewBag.procentClasaIVB = procent;
                    @ViewBag.temeIVB = NrTemeNecorectate;
                }





            }



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

        [HttpGet]
        public async Task<IActionResult> Grils(string id)
        {

            User user = await _userRepository.GetById<User>(id);


            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                var clasa = user.Clasa.ToString();
                Task<ICollection<GridExercice>> homeworks = _userRepository.Find<GridExercice>(s => s.Clasa == clasa);

                Collection<SolveGridExerciceModel> availableHomeworks = new Collection<SolveGridExerciceModel>();
                Collection<SolveGridExerciceModel> notAvailableHomeworks = new Collection<SolveGridExerciceModel>();
                Collection<SolvedHomeworkModel> solveds = new Collection<SolvedHomeworkModel>();

                foreach (var homework in homeworks.Result)
                {
                    Task<ICollection<SolvedHomework>> solvedHomeworks =
                        _userRepository.Find<SolvedHomework>(s =>
                            s.StudentId == user.Id && s.HomeworkId == homework.Id);





                    bool ok = false;
                    foreach (var homeworksm in solvedHomeworks.Result)
                    {

                        SolvedHomeworkModel homeworkm = new SolvedHomeworkModel();
                        homeworkm.HomeworkTitle = homework.Title;
                        homeworkm.HomeworkContainer = homework.Container;
                        homeworkm.CorrectAnswer = homeworksm.CorrectAnswer;
                        homeworkm.StudentAnswer = homeworksm.StudentAnswer;
                        solveds.Add(homeworkm);
                        ok = true;
                    }

                    if (ok == false)
                    {
                        if (homework.DateEnd < DateTime.Now)
                        {
                            SolveGridExerciceModel homeworkm = new SolveGridExerciceModel();
                            homeworkm.Title = homework.Title;
                            homeworkm.Week = homework.Week;
                            homeworkm.Container = homework.Container;
                            homeworkm.DateStart = homework.DateStart;
                            homeworkm.DateEnd = homework.DateEnd;
                            homeworkm.Id = homework.Id;
                            Random rnd = new Random();
                            List<String> a = new List<string>
                                    {homework.Answer1, homework.Answer2, homework.Answer3, homework.CorrectAnswer}
                                ;
                            int i;

                            i = rnd.Next(4);
                            homeworkm.Answer1 = a[i];
                            a.Remove(a[i]);
                            i = rnd.Next(3);
                            homeworkm.Answer2 = a[i];
                            a.Remove(a[i]);
                            i = rnd.Next(2);
                            homeworkm.Answer3 = a[i];
                            a.Remove(a[i]);
                            homeworkm.Answer4 = a[0];


                            notAvailableHomeworks.Add(homeworkm);
                        }
                        else if (homework.DateStart < DateTime.Now)
                        {

                            SolveGridExerciceModel homeworkm = new SolveGridExerciceModel();
                            homeworkm.Title = homework.Title;
                            homeworkm.Week = homework.Week;
                            homeworkm.Container = homework.Container;
                            homeworkm.DateStart = homework.DateStart;
                            homeworkm.DateEnd = homework.DateEnd;
                            homeworkm.Id = homework.Id;
                            Random rnd = new Random();
                            List<String> a = new List<string>
                                    {homework.Answer1, homework.Answer2, homework.Answer3, homework.CorrectAnswer}
                                ;
                            int i;

                            i = rnd.Next(4);
                            homeworkm.Answer1 = a[i];
                            a.Remove(a[i]);
                            i = rnd.Next(3);
                            homeworkm.Answer2 = a[i];
                            a.Remove(a[i]);
                            i = rnd.Next(2);
                            homeworkm.Answer3 = a[i];
                            a.Remove(a[i]);
                            homeworkm.Answer4 = a[0];

                            availableHomeworks.Add(homeworkm);

                        }
                    }




                }

                StudentGrilsViewModel studentGrilsViewModel = new StudentGrilsViewModel();
                studentGrilsViewModel.homeworks = availableHomeworks;
                studentGrilsViewModel.notAvailableHomewoks = notAvailableHomeworks;
                studentGrilsViewModel.solvedHomeworks = solveds;

                TeacherModel student = new TeacherModel();
                student.LastName = user.LastName.ToString();
                student.FirstName = user.FirstName.ToString();
                student.clasa = user.Clasa.ToString();
                student.Image = user.Image.ToString();
                student.EmailAddress = user.EmailAddress.ToString();
                student.Id = user.Id.ToString();

                studentGrilsViewModel.student = student;

                return View(studentGrilsViewModel);

            }

            return NotFound();


        }

        [HttpPost()]

        public async Task<IActionResult> Grils(string studentId, string homeworkId, string answer)
        {
            @ViewBag.ok = "Apelat";
            User user = await _userRepository.GetById<User>(studentId);
            GridExercice homework = await _userRepository.GetById<GridExercice>(homeworkId);
            SolvedHomework solvedHomework = new SolvedHomework();
            solvedHomework.HomeworkId = homeworkId;
            solvedHomework.StudentId = studentId;
            solvedHomework.CorrectAnswer = homework.CorrectAnswer;
            solvedHomework.StudentAnswer = answer;

            Grade grade = new Grade();
            grade.Homework = homeworkId;
            grade.Date = DateTime.Now;
            grade.StudentId = studentId;
            grade.Week = homework.Week;
            grade.TeacherId = homework.TeacherId;

            if (answer == homework.CorrectAnswer)
            {
                grade.Value = 10;

            }
            else
            {
                grade.Value = 0;
            }

            _userRepository.Create<SolvedHomework>(solvedHomework);
            _userRepository.Save();

            _userRepository.Create<Grade>(grade);
            _userRepository.Save();

            
            var teacher = await _userRepository.GetById<User>(homework.TeacherId);

          
             Helpers.MailHelper.Send(user.EmailAddress, teacher.EmailAddress, "TEMĂ REZOLVATĂ",
                    user.FirstName+" "+user.LastName+ " a rezolvat "+homework.Title);
            


            return Json(homework.CorrectAnswer);

        }



        [HttpGet]
        public async Task<IActionResult> Exercices(string id)
        {

            User user = await _userRepository.GetById<User>(id);


            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                var clasa = user.Clasa.ToString();
                Task<ICollection<Exercice>> homeworks = _userRepository.Find<Exercice>(s => s.Clasa == clasa);

                Collection<SolveExerciceModel> availableHomeworks = new Collection<SolveExerciceModel>();
                Collection<SolveExerciceModel> notAvailableHomeworks = new Collection<SolveExerciceModel>();
                Collection<SolvedHomeworkModel> solveds = new Collection<SolvedHomeworkModel>();

                foreach (var homework in homeworks.Result)
                {
                    Task<ICollection<SolvedHomework>> solvedHomeworks =
                        _userRepository.Find<SolvedHomework>(s =>
                            s.StudentId == user.Id && s.HomeworkId == homework.Id);





                    bool ok = false;
                    foreach (var homeworksm in solvedHomeworks.Result)
                    {

                        SolvedHomeworkModel homeworkm = new SolvedHomeworkModel();
                        homeworkm.HomeworkTitle = homework.Title;
                        homeworkm.HomeworkContainer = homework.Container;
                        homeworkm.CorrectAnswer = homeworksm.CorrectAnswer;
                        homeworkm.StudentAnswer = homeworksm.StudentAnswer;
                        solveds.Add(homeworkm);
                        ok = true;
                    }

                    if (ok == false)
                    {
                        if (homework.DateEnd < DateTime.Now)
                        {
                            SolveExerciceModel homeworkm = new SolveExerciceModel();
                            homeworkm.Title = homework.Title;
                            homeworkm.Week = homework.Week;
                            homeworkm.Container = homework.Container;
                            homeworkm.DateStart = homework.DateStart;
                            homeworkm.DateEnd = homework.DateEnd;
                            homeworkm.Id = homework.Id;
                            homeworkm.Answer = null;
                            homeworkm.Finally = null;

                            notAvailableHomeworks.Add(homeworkm);
                        }
                        else if (homework.DateStart < DateTime.Now)
                        {

                            SolveExerciceModel homeworkm = new SolveExerciceModel();
                            homeworkm.Title = homework.Title;
                            homeworkm.Week = homework.Week;
                            homeworkm.Container = homework.Container;
                            homeworkm.DateStart = homework.DateStart;
                            homeworkm.DateEnd = homework.DateEnd;
                            homeworkm.Id = homework.Id;
                            homeworkm.Answer = null;

                            homeworkm.Finally = null;

                            availableHomeworks.Add(homeworkm);

                        }
                    }




                }

                StudentExercicesViewModel studentGrilsViewModel = new StudentExercicesViewModel();
                studentGrilsViewModel.homeworks = availableHomeworks;
                studentGrilsViewModel.notAvailableHomewoks = notAvailableHomeworks;
                studentGrilsViewModel.solvedHomeworks = solveds;

                TeacherModel student = new TeacherModel();
                student.LastName = user.LastName.ToString();
                student.FirstName = user.FirstName.ToString();
                student.clasa = user.Clasa.ToString();
                student.Image = user.Image.ToString();
                student.EmailAddress = user.EmailAddress.ToString();
                student.Id = user.Id.ToString();

                studentGrilsViewModel.student = student;

                return View(studentGrilsViewModel);

            }

            return NotFound();


        }

        [HttpPost]
        public async Task<IActionResult> Exercices(StudentExercicesViewModel studentExercicesViewModel, string id)
        {
            String userId = Request.Cookies["Id"].ToString();
            if (ModelState.IsValid)
            {

                Exercice exercice = await _userRepository.GetById<Exercice>(id);
                var solvedExercice = new SolvedHomework(userId, id,
                    studentExercicesViewModel.SolvedHomework.Answer + "\n Răspuns final: " +
                    studentExercicesViewModel.SolvedHomework.Finally, exercice.CorrectAnswer);
                _userRepository.Create(solvedExercice);
                _userRepository.Save();

                var teacher = await _userRepository.GetById<User>(exercice.TeacherId);
                var user = await _userRepository.GetById<User>(userId);

                Helpers.MailHelper.Send(user.EmailAddress, teacher.EmailAddress, "TEMĂ REZOLVATĂ",
                    user.FirstName + " " + user.LastName + " a rezolvat " + exercice.Title);

                return RedirectToAction("Exercices", new {id = userId});
            }

            else
            {
                var user = _userRepository.GetById<User>(userId);
                var student = new TeacherModel();
                student.Id = userId;
                student.clasa = user.Result.Clasa;
                student.EmailAddress = user.Result.EmailAddress;
                student.FirstName = user.Result.FirstName;
                student.EmailAddress = user.Result.EmailAddress;
                student.LastName = user.Result.LastName;
                student.UserName = user.Result.UserName;





                var clasa = user.Result.Clasa.ToString();
                Task<ICollection<Exercice>> homeworks = _userRepository.Find<Exercice>(s => s.Clasa == clasa);

                Collection<SolveExerciceModel> availableHomeworks = new Collection<SolveExerciceModel>();
                Collection<SolveExerciceModel> notAvailableHomeworks = new Collection<SolveExerciceModel>();
                Collection<SolvedHomeworkModel> solveds = new Collection<SolvedHomeworkModel>();

                foreach (var homework in homeworks.Result)
                {
                    Task<ICollection<SolvedHomework>> solvedHomeworks =
                        _userRepository.Find<SolvedHomework>(s =>
                            s.StudentId == user.Result.Id && s.HomeworkId == homework.Id);





                    bool ok = false;
                    foreach (var homeworksm in solvedHomeworks.Result)
                    {

                        SolvedHomeworkModel homeworkm = new SolvedHomeworkModel();
                        homeworkm.HomeworkTitle = homework.Title;
                        homeworkm.HomeworkContainer = homework.Container;
                        homeworkm.CorrectAnswer = homeworksm.CorrectAnswer;
                        homeworkm.StudentAnswer = homeworksm.StudentAnswer;
                        solveds.Add(homeworkm);
                        ok = true;
                    }

                    if (ok == false)
                    {
                        if (homework.DateEnd < DateTime.Now)
                        {
                            SolveExerciceModel homeworkm = new SolveExerciceModel();
                            homeworkm.Title = homework.Title;
                            homeworkm.Week = homework.Week;
                            homeworkm.Container = homework.Container;
                            homeworkm.DateStart = homework.DateStart;
                            homeworkm.DateEnd = homework.DateEnd;
                            homeworkm.Id = homework.Id;
                            homeworkm.Answer = null;
                            homeworkm.Finally = null;

                            notAvailableHomeworks.Add(homeworkm);
                        }
                        else if (homework.DateStart < DateTime.Now)
                        {

                            SolveExerciceModel homeworkm = new SolveExerciceModel();
                            homeworkm.Title = homework.Title;
                            homeworkm.Week = homework.Week;
                            homeworkm.Container = homework.Container;
                            homeworkm.DateStart = homework.DateStart;
                            homeworkm.DateEnd = homework.DateEnd;
                            homeworkm.Id = homework.Id;
                            homeworkm.Answer = null;
                            homeworkm.Finally = null;

                            availableHomeworks.Add(homeworkm);

                        }
                    }




                }

                StudentExercicesViewModel studentGrilsViewModel = new StudentExercicesViewModel();
                studentGrilsViewModel.homeworks = availableHomeworks;
                studentGrilsViewModel.notAvailableHomewoks = notAvailableHomeworks;
                studentGrilsViewModel.solvedHomeworks = solveds;


                studentGrilsViewModel.student = student;
                studentGrilsViewModel.SolvedHomework = studentExercicesViewModel.SolvedHomework;

                return View(studentGrilsViewModel);
            }

        }

        [HttpGet]
        public async Task<IActionResult> Problems(string id)
        {

            User user = await _userRepository.GetById<User>(id);


            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                var clasa = user.Clasa.ToString();
                Task<ICollection<Problem>> homeworks = _userRepository.Find<Problem>(s => s.Clasa == clasa);

                Collection<SolveProblemModel> availableHomeworks = new Collection<SolveProblemModel>();
                Collection<SolveProblemModel> notAvailableHomeworks = new Collection<SolveProblemModel>();
                Collection<SolvedHomeworkModel> solveds = new Collection<SolvedHomeworkModel>();

                foreach (var homework in homeworks.Result)
                {
                    Task<ICollection<SolvedHomework>> solvedHomeworks =
                        _userRepository.Find<SolvedHomework>(s =>
                            s.StudentId == user.Id && s.HomeworkId == homework.Id);





                    bool ok = false;
                    foreach (var homeworksm in solvedHomeworks.Result)
                    {

                        SolvedHomeworkModel homeworkm = new SolvedHomeworkModel();
                        homeworkm.HomeworkTitle = homework.Title;
                        homeworkm.HomeworkContainer = homework.Container;
                        homeworkm.CorrectAnswer = homeworksm.CorrectAnswer;
                        homeworkm.StudentAnswer = homeworksm.StudentAnswer;
                        solveds.Add(homeworkm);
                        ok = true;
                    }

                    if (ok == false)
                    {
                        if (homework.DateEnd < DateTime.Now)
                        {
                            SolveProblemModel homeworkm = new SolveProblemModel();
                            homeworkm.Title = homework.Title;
                            homeworkm.Week = homework.Week;
                            homeworkm.Container = homework.Container;
                            homeworkm.DateStart = homework.DateStart;
                            homeworkm.DateEnd = homework.DateEnd;
                            homeworkm.Id = homework.Id;
                            homeworkm.ProblemData = null;
                            homeworkm.Answer = null;
                            homeworkm.Finally = null;

                            notAvailableHomeworks.Add(homeworkm);
                        }
                        else if (homework.DateStart < DateTime.Now)
                        {

                            SolveProblemModel homeworkm = new SolveProblemModel();
                            homeworkm.Title = homework.Title;
                            homeworkm.Week = homework.Week;
                            homeworkm.Container = homework.Container;
                            homeworkm.DateStart = homework.DateStart;
                            homeworkm.DateEnd = homework.DateEnd;
                            homeworkm.Id = homework.Id;
                            homeworkm.Answer = null;
                            homeworkm.ProblemData = null;
                            homeworkm.Finally = null;

                            availableHomeworks.Add(homeworkm);

                        }
                    }




                }

                StudentProblemsViewModel studentGrilsViewModel = new StudentProblemsViewModel();
                studentGrilsViewModel.homeworks = availableHomeworks;
                studentGrilsViewModel.notAvailableHomewoks = notAvailableHomeworks;
                studentGrilsViewModel.solvedHomeworks = solveds;

                TeacherModel student = new TeacherModel();
                student.LastName = user.LastName.ToString();
                student.FirstName = user.FirstName.ToString();
                student.clasa = user.Clasa.ToString();
                student.Image = user.Image.ToString();
                student.EmailAddress = user.EmailAddress.ToString();
                student.Id = user.Id.ToString();

                studentGrilsViewModel.student = student;


                return View(studentGrilsViewModel);

            }

            return NotFound();


        }


        [HttpPost]
        public async Task<IActionResult> Problems(StudentProblemsViewModel studentExercicesViewModel, string id)
        {
            String userId = Request.Cookies["Id"].ToString();
            if (ModelState.IsValid)
            {

                Problem exercice = await _userRepository.GetById<Problem>(id);




                var solvedExercice = new SolvedHomework(userId, id,
                    "Datele problemei:" + studentExercicesViewModel.SolvedProblemModel.ProblemData + "\n Rezolvare:" +
                    studentExercicesViewModel.SolvedProblemModel.Answer + "\n Răspuns final: " +
                    studentExercicesViewModel.SolvedProblemModel.Finally, exercice.CorrectAnswer);
                _userRepository.Create(solvedExercice);
                _userRepository.Save();

                var teacher = await _userRepository.GetById<User>(exercice.TeacherId);
                var user = await _userRepository.GetById<User>(userId);

                Helpers.MailHelper.Send(user.EmailAddress, teacher.EmailAddress, "TEMĂ REZOLVATĂ",
                    user.FirstName + " " + user.LastName + " a rezolvat " + exercice.Title);

                return RedirectToAction("Problems", new {id = userId});
            }
            else
            {
                var user = _userRepository.GetById<User>(userId);
                var student = new TeacherModel();
                student.Id = userId;
                student.clasa = user.Result.Clasa;
                student.EmailAddress = user.Result.EmailAddress;
                student.FirstName = user.Result.FirstName;
                student.EmailAddress = user.Result.EmailAddress;
                student.LastName = user.Result.LastName;
                student.UserName = user.Result.UserName;





                var clasa = user.Result.Clasa.ToString();
                Task<ICollection<Problem>> homeworks = _userRepository.Find<Problem>(s => s.Clasa == clasa);

                Collection<SolveProblemModel> availableHomeworks = new Collection<SolveProblemModel>();
                Collection<SolveProblemModel> notAvailableHomeworks = new Collection<SolveProblemModel>();
                Collection<SolvedHomeworkModel> solveds = new Collection<SolvedHomeworkModel>();

                foreach (var homework in homeworks.Result)
                {
                    Task<ICollection<SolvedHomework>> solvedHomeworks =
                        _userRepository.Find<SolvedHomework>(s =>
                            s.StudentId == user.Result.Id && s.HomeworkId == homework.Id);





                    bool ok = false;
                    foreach (var homeworksm in solvedHomeworks.Result)
                    {

                        SolvedHomeworkModel homeworkm = new SolvedHomeworkModel();
                        homeworkm.HomeworkTitle = homework.Title;
                        homeworkm.HomeworkContainer = homework.Container;
                        homeworkm.CorrectAnswer = homeworksm.CorrectAnswer;
                        homeworkm.StudentAnswer = homeworksm.StudentAnswer;
                        solveds.Add(homeworkm);
                        ok = true;
                    }

                    if (ok == false)
                    {
                        if (homework.DateEnd < DateTime.Now)
                        {
                            SolveProblemModel homeworkm = new SolveProblemModel();
                            homeworkm.Title = homework.Title;
                            homeworkm.Week = homework.Week;
                            homeworkm.Container = homework.Container;
                            homeworkm.DateStart = homework.DateStart;
                            homeworkm.DateEnd = homework.DateEnd;
                            homeworkm.Id = homework.Id;
                            homeworkm.ProblemData = null;
                            homeworkm.Answer = null;
                            homeworkm.Finally = null;

                            notAvailableHomeworks.Add(homeworkm);
                        }
                        else if (homework.DateStart < DateTime.Now)
                        {

                            SolveProblemModel homeworkm = new SolveProblemModel();
                            homeworkm.Title = homework.Title;
                            homeworkm.Week = homework.Week;
                            homeworkm.Container = homework.Container;
                            homeworkm.DateStart = homework.DateStart;
                            homeworkm.DateEnd = homework.DateEnd;
                            homeworkm.Id = homework.Id;
                            homeworkm.Answer = null;
                            homeworkm.ProblemData = null;
                            homeworkm.Finally = null;

                            availableHomeworks.Add(homeworkm);

                        }
                    }




                }

                StudentProblemsViewModel studentGrilsViewModel = new StudentProblemsViewModel();
                studentGrilsViewModel.homeworks = availableHomeworks;
                studentGrilsViewModel.notAvailableHomewoks = notAvailableHomeworks;
                studentGrilsViewModel.solvedHomeworks = solveds;


                studentGrilsViewModel.student = student;
                studentGrilsViewModel.SolvedProblemModel = studentExercicesViewModel.SolvedProblemModel;

                return View(studentGrilsViewModel);
            }



        }


        [HttpGet]
        public async Task<IActionResult> Homeworks(string id)
        {

            var users = await _userRepository.Find<User>(s => s.Clasa == id);


            if (ModelState.IsValid)
            {
                List<StudentHomeworkModel> teme = new List<StudentHomeworkModel>();

                foreach (var user in users)
                {
                    String teacherId = Request.Cookies["Id"].ToString();
                    Task<ICollection<SolvedHomework>> homeworks =
                        _userRepository.Find<SolvedHomework>(s => s.StudentId == user.Id);

                    Collection<SolvedHomeworkModel> solveds = new Collection<SolvedHomeworkModel>();

                    foreach (var homework in homeworks.Result)
                    {
                        Task<ICollection<Grade>> solvedHomeworks = _userRepository.Find<Grade>(s =>
                            (s.StudentId == homework.StudentId && s.Homework == homework.HomeworkId && s.TeacherId==teacherId));
                        bool ok = false;
                        foreach (var s in solvedHomeworks.Result)
                        {
                            ok = true;
                        }


                        if (ok == false)
                        {
                            if (await _userRepository.GetById<Problem>(homework.HomeworkId) != null)
                            {
                                var myHomework = await _userRepository.GetById<Problem>(homework.HomeworkId);
                                SolvedHomeworkModel studentHomework = new SolvedHomeworkModel();
                                studentHomework.HomeworkTitle = myHomework.Title;
                                studentHomework.CorrectAnswer = myHomework.CorrectAnswer;
                                studentHomework.HomeworkContainer = myHomework.Container;
                                studentHomework.StudentAnswer = homework.StudentAnswer;
                                studentHomework.Id = homework.HomeworkId;
                                studentHomework.Week = myHomework.Week;
                                solveds.Add(studentHomework);

                            }
                            else
                            {
                                var myHomework = await _userRepository.GetById<Exercice>(homework.HomeworkId);
                                if (myHomework != null)
                                {
                                    SolvedHomeworkModel studentHomework = new SolvedHomeworkModel();
                                    studentHomework.HomeworkTitle = myHomework.Title;
                                    studentHomework.CorrectAnswer = myHomework.CorrectAnswer;
                                    studentHomework.HomeworkContainer = myHomework.Container;
                                    studentHomework.StudentAnswer = homework.StudentAnswer;
                                    studentHomework.Id = homework.HomeworkId;
                                    studentHomework.Week = myHomework.Week;
                                    solveds.Add(studentHomework);
                                }
                            }

                        }

                    }

                    if (solveds.Count != 0)
                    {
                        StudentHomeworkModel s = new StudentHomeworkModel();
                        s.FirstName = user.FirstName;
                        s.LastName = user.LastName;
                        s.Id = user.Id;
                        s.UserName = user.UserName;
                        s.clasa = user.Clasa;
                        s.homeworks = solveds;
                        teme.Add(s);
                    }





                }

                var homewor = new StudentHomeworksViewModel();
                homewor.students = teme;

                return View(homewor);

            }

            return NotFound();


        }

        [HttpPost()]
        public async Task<IActionResult> Homeworks(string studentId, string homeworkId, int value, int week)
        {
            String teacherId = Request.Cookies["Id"].ToString();
            var user = await _userRepository.GetById<User>(studentId);

            var grade = new Grade();
            grade.Date = DateTime.Now;
            grade.Homework = homeworkId;
            grade.StudentId = studentId;
            grade.Value = value;
            grade.Week = week;
            grade.TeacherId = teacherId;

            _userRepository.Create<Grade>(grade);
            _userRepository.Save();


            return RedirectToAction("Homeworks", "Users", user.Clasa);
        }
    }
}