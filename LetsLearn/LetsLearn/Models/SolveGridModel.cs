using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LetsLearn.Models
{
    public class SolveGridExerciceModel
    {
        [Required]
        public string Id { get; set; }

        [StringLength(50, MinimumLength = 5)]
        [Display(Name = "Titlu")]
        public string Title { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Cerința")]
        public string Container { get; set; }

        

        [Required]
        [Display(Name = "Răspuns 1")]
        public string Answer1 { get; set; }

        [Required]
        [Display(Name = "Răspuns 2")]
        public string Answer2 { get; set; }

        [Required]
        [Display(Name = "Rărspuns 3")]
        public string Answer3 { get; set; }

        [Required]
        [Display(Name = "Răspunsul 4")]
        public string Answer4 { get; set; }

        [Required]
        [Display(Name = "Săptămâna")]
        public int Week { get; set; }

        [Required]
        [Display(Name = "Data de început")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(dataType: DataType.Date, ErrorMessage = "Format invalid")]
        public DateTime DateStart { get; set; }

        [Required]
        [Display(Name = "Termen limită")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(dataType: DataType.Date, ErrorMessage = "Format invalid")]
        public DateTime DateEnd { get; set; }

    }
}
