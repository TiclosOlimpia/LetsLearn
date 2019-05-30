using LetsLearn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsLearn.ViewModels
{
    public class StudentGrilsViewModel
    {
        public IEnumerable<SolveGridExerciceModel> homeworks { get; set; }
        public IEnumerable<SolveGridExerciceModel> notAvailableHomewoks { get; set; }
        public IEnumerable<SolvedHomeworkModel> solvedHomeworks {get; set; }
        public TeacherModel student { get; set; }
    }
}
