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

        public Grade(int value, DateTime date, int week, string homework, string studentId, string teacherId)
        {
            Id = Guid.NewGuid().ToString();
            //Guard.ValueNotNull(value, nameof(value));
            //Guard.ValueNotNull(date, nameof(date));
            Value = value;
            Date = date;
            Week = week;
            Homework = homework;
            StudentId = studentId;
            TeacherId = teacherId;

        }

        [Required]
        
        public int Value { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime Date{ get; set; }

        [Required]
        public int Week { get; set; }

        public string Homework { get; set; }

        public string StudentId { get; set; }

        [Required]
        public string TeacherId { get; set; }
        //[ForeignKey("Exam")]
        //public Guid ExamId { get; private set; }

        //public Homework Homework { get; private set; }

        //foreignkey
        //public User User { get; private set; }


    }
}
