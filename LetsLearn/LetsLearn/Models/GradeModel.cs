using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LetsLearn.Models
{
    public class GradeModel
    {
        [Required]
        public int Value { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int Week { get; set; }

        public bool Homework { get; set; }

    }
}
