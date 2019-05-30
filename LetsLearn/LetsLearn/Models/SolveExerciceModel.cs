using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LetsLearn.Models
{
    public class SolveExerciceModel
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

        
        [Display(Name = "Rezolvare")]
        public string Answer { get; set; }

        
        [Display(Name = "Răspuns final")]
        public string Finally { get; set; }

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
