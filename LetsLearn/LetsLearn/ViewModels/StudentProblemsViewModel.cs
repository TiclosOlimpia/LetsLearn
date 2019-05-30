using LetsLearn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsLearn.ViewModels
{
    public class StudentProblemsViewModel
    {
        public IEnumerable<SolveProblemModel> homeworks { get; set; }
        public IEnumerable<SolveProblemModel> notAvailableHomewoks { get; set; }
        public IEnumerable<SolvedHomeworkModel> solvedHomeworks {get; set; }
        public TeacherModel student { get; set; }
        public SolvedProblemModel SolvedProblemModel { get; set; }
    }
}
