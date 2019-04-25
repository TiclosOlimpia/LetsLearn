using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LetsLearn.Models
{
    public class AddHomeworkModel
    {
        [StringLength(50, MinimumLength = 5)]
        public string Title { get; set; }

        [Required]
        [MaxLength(100)]
        public string Container { get; set; }

        [Required]
        public string CorrectAnsear { get; set; }

        [Required]
        public string Ansear1 { get; set; }

        [Required]
        public string Ansear2 { get; set; }

        [Required]
        public string Ansear3 { get; set; }

        [Required]
        public int Week { get; set; }

        [Required]
        public DateTime DateStart { get; set; }

        [Required]
        public DateTime DateEnd { get; set; }

    }
}
