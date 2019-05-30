using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;


namespace LetsLearn.Data
{
    public class User : BaseEntity
    {
        public User()
        {

        }

        public User(string firstName, string lastName, string userName, string password, string emailAddress,
            bool isTeacher, string clasa, string image, float medie)
        {
            Id = Guid.NewGuid().ToString();
            //Guard.ArgumentNotNullOrEmpty(firstName, nameof(firstName));
            //Guard.ArgumentNotNullOrEmpty(lastName, nameof(lastName));
            //Guard.ArgumentNotNullOrEmpty(userName, nameof(userName));
            //Guard.ArgumentNotNullOrEmpty(password, nameof(password));
            //Guard.ArgumentNotNullOrEmpty(emailAddress, nameof(emailAddress));
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = password;
            EmailAddress = emailAddress;
            IsTeacher = isTeacher;
            Clasa = clasa;
            Image = image;
            Average = medie;
            //Type = type;
        }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        

        [Required]
        [StringLength(60, MinimumLength = 5)]
        public string EmailAddress { get; set; }



        [Required]
        public bool IsTeacher { get; set; }

        [StringLength(60, MinimumLength = 5)]
        public string Image { get; set; }

        public string Clasa { get; set; }

        public float Average { get; set; }
        //[Required]
        //[StringLength(8, MinimumLength = 6)]
        //public string Type { get; set; }

        //public Homework Homework { get; set; }

        //public ICollection<Homework> Homeworks { get; set; }

        //[InverseProperty("StudentId")]
        //public ICollection<Grade> Grades { get; private set; }
    }
}
