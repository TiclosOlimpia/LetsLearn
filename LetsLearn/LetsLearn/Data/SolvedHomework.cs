
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using LetsLearn.Models;
using MailKit.Search;


namespace LetsLearn.Data
{
    public class SolvedHomework: BaseEntity
    {
        public SolvedHomework()
        {

        }

        public SolvedHomework(string studentId, string homeworkId, string studentAnswer, string correctAnswer)
        {
            Id = Guid.NewGuid().ToString();
            //Guard.ArgumentNotNullOrEmpty(title, nameof(title));
            //Guard.ArgumentNotNull(observations, nameof(observations));
            //Guard.ArgumentNotNull(dateStart, nameof(dateStart));
            //Guard.ArgumentNotNull(dateEnd, nameof(dateEnd));
            HomeworkId = homeworkId;
            StudentId = studentId;
            CorrectAnswer = correctAnswer;
            StudentAnswer = studentAnswer;
        }

        [Required]
        public string HomeworkId { get; set; }

        [Required]
        public string StudentId{ get; set; }

        [Required]
        public string CorrectAnswer { get; set; }

        [Required]
        public string StudentAnswer{ get; set; }

        //public ICollection<Grade> Grades { get; private set; }

        //[ForeignKey("Student")]
        //public Guid StudentId { get; private set; }

        //public User User { get; private set; }

    }
}
