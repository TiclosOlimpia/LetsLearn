using LetsLearn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsLearn.ViewModels
{
    public class StudentHomeworksViewModel
    {
        
        public IEnumerable<StudentHomeworkModel> students { get; set; }
        
    }
}
