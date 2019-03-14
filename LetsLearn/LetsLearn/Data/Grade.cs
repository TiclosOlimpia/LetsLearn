using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace LetsLearn.Data
{
    public class Grade : BaseEntity
    {
        public Grade()
        {

        }

        public Grade(int value, DateTime date)
        {
            Id = Guid.NewGuid().ToString();
            //Guard.ValueNotNull(value, nameof(value));
            //Guard.ValueNotNull(date, nameof(date));
            Value = value;
            Date = date;
        }

        [Required]
        public int Value { get; set; }

        [Required]
        public DateTime Date { get; set; }

        //[ForeignKey("Exam")]
        //public Guid ExamId { get; private set; }

        //public Homework Homework { get; private set; }

        //foreignkey
        //public User User { get; private set; }


    }
}
