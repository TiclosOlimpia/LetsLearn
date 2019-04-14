using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;

namespace LetsLearn.Models
{
    public class EditProfileModel
    {

        [Required(ErrorMessage = "* Prenumele este obligatoriu")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = " * Perenumele trebuie sa contina intre 3 si 50 de caractere")]
        [Display(Name = "Prenume")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "* Numele este obligatoriu")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Numele trebuie sa contina intre 5 si 50 de caractere")]
        [Display(Name = "Nume")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "* Numele de utilizator este obligatoriu")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Numele de utilizator trebuie sa contina intre 5 si 50 de caractere")]
        [Display(Name = "Nume de Utilizator")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "* Emailul este obligatoriu")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "Emailul trebuie sa contina intre 5 si 20 de caractere")]
        [Display(Name = "Email")]
        public string EmailAddress { get; set; }
        public object Guard { get; }

        [Display(Name = "Fotografie de profil")]
        public IFormFile Image { get; set; }

        public string Id { get; set; }

    }
}
