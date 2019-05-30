using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;
using Org.BouncyCastle.Asn1.X509;

namespace LetsLearn.Models
{
    public class GradeModel
    {
        [Required(ErrorMessage = "* Nota este obligatorie")]
        [Range(0, 10, ErrorMessage = "Nota trebuie să fie între 0 șo 10")]
        [Display(Name = "Nota")]
        public int Value { get; set; }

        [Required(ErrorMessage = "* Data este obligatorile")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(dataType: DataType.Date, ErrorMessage = "Format invalid")]
        [Display(Name = "Data")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "* Nota este obligatorie")]
        [Range(1, 30, ErrorMessage = "Săptămâna trebuie să fie între 1 șo 30")]
        [Display(Name = "Săptămâna")]
        public int Week { get; set; }

        [Display(Name = "Notă pentru temă?")]
        public string Homework { get; set; }

    }
}
