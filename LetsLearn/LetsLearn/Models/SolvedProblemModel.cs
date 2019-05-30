﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LetsLearn.Models
{
    public class SolvedProblemModel
    {
        
        [Required (ErrorMessage = "* Câmp obligatoriu")]
        [Display(Name = "Răspunsul Corect")]
        public string Answer { get; set; }

        [Required(ErrorMessage = "* Câmp obligatoriu")]
        [Display(Name = "Răspunsul Tău")]
        public string Finally { get; set; }

        [Required(ErrorMessage = "* Câmp obligatoriu")]
        [Display(Name = "Datele Problemei")]
        public string ProblemData { get; set; }

        

    }
}
