using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace LetsLearn.Data
{
    public class User : BaseEntity
    {
        public User()
        {

        }

        public User(string firstName, string lastName, string userName, string password, string emailAddress, bool isTeacher)
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
        [StringLength(100,MinimumLength = 5)]
        public string Password { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 5)]
        public string EmailAddress { get; set; }
        public object Guard { get; }

        [Required]
        public bool IsTeacher { get; set; }

        //[Required]
        //[StringLength(8, MinimumLength = 6)]
        //public string Type { get; set; }

        //public Homework Homework { get; set; }


        public void SetId(string id)
        {
            Id = id;


        }

        public IEnumerable<User_homework> User_homework { get; set; }

        //public ICollection<Homework> Homeworks { get; set; }

        //[InverseProperty("StudentId")]
        //public ICollection<Grade> Grades { get; private set; }
    }
}
