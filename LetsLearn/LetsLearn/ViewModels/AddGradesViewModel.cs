using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LetsLearn.Models;

namespace LetsLearn.ViewModels
{
    public class AddGradesViewModel
    {
        public ClasaModel student { get; set; }
        public  GradeModel grade { get; set; }
    }
}
