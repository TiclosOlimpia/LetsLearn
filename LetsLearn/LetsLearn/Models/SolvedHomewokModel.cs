using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LetsLearn.Models
{
    public class SolvedHomeworkModel
    {
        

        [Required]
        [Display(Name = "Titlul temei")]
        public string HomeworkTitle { get; set; }

        [Required]
        [Display(Name ="Cerința temei")]
        public string HomeworkContainer { get; set; }

        [Required]
        [Display(Name = "Răspunsul Corect")]
        public string CorrectAnswer { get; set; }

        [Required]
        [Display(Name = "Răspunsul Tău")]
        public string StudentAnswer { get; set; }

        public string Id { get; set; }

        public int Week { get; set; }

        public float grade { get; set; }

    }
}
