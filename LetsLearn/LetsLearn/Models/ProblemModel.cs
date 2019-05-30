using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LetsLearn.Models
{
    public class ProblemModel
    {
        [Required(ErrorMessage = "* Titlul este obligatoriu")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Titlul trebuie să aibe între 5 și 50 de caractere")]
        [Display (Name = "Titlu")]
        public string Title { get; set; }

        [Required(ErrorMessage = "* Cerința este obligatorie")]
        [MaxLength(1000, ErrorMessage = "Maxim 1000 de caractere acceptate")]
        [Display (Name = "Cerința")]
        public string Container { get; set; }

        [Required(ErrorMessage = "* Răspuns obligatoriu")]
        [Display(Name = "Datele Problemei")]
        public string ProblemData { get; set; }

        [Required(ErrorMessage = "* Răspuns obligatoriu")]
        [Display (Name = "Răspunsul Corect")]
        public string CorrectAnswer { get; set; }

        [Required(ErrorMessage = "* Răspuns obligatoriu")]
        [Display (Name = "Răspuns final")]
        public string FinallyAnswer { get; set; }

        [Required(ErrorMessage = "* Răspuns obligatoriu")]
        [Display (Name = "Săptămâna" )]
        public int Week { get; set; }

        [Required(ErrorMessage = "* Răspuns obligatoriu")]
        [Display (Name = "Data de început")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(dataType: DataType.Date, ErrorMessage = "Format invalid")]
        public DateTime DateStart { get; set; }

        [Required(ErrorMessage = "* Răspuns obligatoriu")]
        [Display (Name = "Termen limită")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(dataType: DataType.Date, ErrorMessage = "Format invalid")]
        public DateTime DateEnd { get; set; }

    }
}
