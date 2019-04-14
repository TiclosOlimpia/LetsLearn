using LetsLearn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsLearn.ViewModels
{
    public class StudentViewModel
    {
        public StudentModel student { get; set; }
        public IEnumerable<GradeModel> grades { get; set; }
    }
}
