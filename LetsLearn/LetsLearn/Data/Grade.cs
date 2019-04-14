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

        public Grade(int value, DateTime date, int week, bool homework, string studentId)
        {
            Id = Guid.NewGuid().ToString();
            //Guard.ValueNotNull(value, nameof(value));
            //Guard.ValueNotNull(date, nameof(date));
            Value = value;
            Date = date;
            Week = week;
            Homework = homework;
            StudentId = studentId;

        }

        [Required]
        
        public int Value { get; set; }

        [Required]
        public DateTime Date{ get; set; }

        [Required]
        public int Week { get; set; }

        public  bool Homework { get; set; }

        public string StudentId { get; set; }
        //[ForeignKey("Exam")]
        //public Guid ExamId { get; private set; }

        //public Homework Homework { get; private set; }

        //foreignkey
        //public User User { get; private set; }


    }
}
