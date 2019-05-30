using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LetsLearn.Models
{
    public class GridExerciceModel
    {
        [Required(ErrorMessage = "* Titlul este obligatoriu")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Titlul trebuie să aibe între 5 și 50 de caractere")]
        [Display (Name = "Titlu")]
        public string Title { get; set; }

        [Required(ErrorMessage = "* Cerința este obligatorie")]
        [MaxLength(500, ErrorMessage = "Maxim 100 de caractere acceptate")]
        [Display (Name = "Cerința")]
        public string Container { get; set; }

        [Required(ErrorMessage = "* Răspuns obligatoriu")]
        [Display (Name = "Răspunsul Corect")]
        public string CorrectAnswer { get; set; }

        [Required(ErrorMessage = "* Răspuns obligatoriu")]
        [Display (Name = "Răspuns 1")]
        public string Answer1 { get; set; }

        [Required(ErrorMessage = "* Răspuns obligatoriu")]
        [Display(Name = "Răspuns 2")]
        public string Answer2 { get; set; }

        [Required(ErrorMessage = "* Răspuns obligatoriu")]
        [Display (Name = "Rărspuns 3")]
        public string Answer3 { get; set; }

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
