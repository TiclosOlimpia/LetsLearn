using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LetsLearn.Models;

namespace LetsLearn.ViewModels
{
    public class StudentDetailViewModel
    {
        public ClasaModel student { get; set; }
        public  IEnumerable<GradeModel> grades { get; set; }
    }
}
