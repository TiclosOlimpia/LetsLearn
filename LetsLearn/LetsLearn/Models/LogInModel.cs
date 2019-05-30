using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LetsLearn.Models
{
    public class LogInModel
    {

        [Required(ErrorMessage = "* Numele de utilizator este obligatoriu")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Numele trebuie sa contina intre 5 si 50 de caractere")]
        [Display(Name = "Nume de Utilizator")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "* Parola este obligatorie")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Parola trebuie sa contina intre 5 si 20 de caractere")]
        [DataType(DataType.Password)]
        [Display(Name = "Parola")]
        public string Password { get; set; }
        public bool Remember { get; set; }

        //[Required]
        //public bool RememberMe { get; set; }

    }
}
