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
    public class RegisterModel
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

        [Required(ErrorMessage = "* Parola este obligatorie")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Parola trebuie sa contina intre 5 si 20 de caractere")]
        [Display(Name = "Parola")]
        public string Password { get; set; }

        [Required(ErrorMessage = "* Confirmarea Parolei este obligatorie")]
        [StringLength(20, MinimumLength = 5)]
        [DataType(DataType.Password), Compare(nameof(Password), ErrorMessage = "Parolele nu coincid")]
        [Display(Name = "Confirmarea parolei")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "* Emailul este obligatoriu")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "Emailul trebuie sa contina intre 5 si 20 de caractere")]
        [Display(Name = "Email")]
        public string EmailAddress { get; set; }
        public object Guard { get; }

        [Display(Name = "Fotografie de profil")]
        public IFormFile Image { get; set; }

        [Display(Name = "Sunt profesor")]
        public bool IsTeacher { get; set; }
      
        [Display(Name = "Clasa")]
        public string Class { get; set; }

        public string Id { get; set; }

    }
}
