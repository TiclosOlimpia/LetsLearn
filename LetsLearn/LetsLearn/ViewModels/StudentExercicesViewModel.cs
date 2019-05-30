using LetsLearn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsLearn.ViewModels
{
    public class StudentExercicesViewModel
    {
        public IEnumerable<SolveExerciceModel> homeworks { get; set; }
        public IEnumerable<SolveExerciceModel> notAvailableHomewoks { get; set; }
        public IEnumerable<SolvedHomeworkModel> solvedHomeworks {get; set; }
        public SolvedExerciceModel SolvedHomework { get; set; }
        public TeacherModel student { get; set; }
    }
}
