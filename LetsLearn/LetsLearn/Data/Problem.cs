using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using LetsLearn.Models;


namespace LetsLearn.Data
{
    public class Problem : BaseEntity
    {
        public Problem()
        {

        }

        public Problem(string title, string container,string problemData, string correctAnswer, string finallyAnswer, int week, DateTime dateStart, DateTime dateEnd, string clasa)
        {
            Id = Guid.NewGuid().ToString();
            //Guard.ArgumentNotNullOrEmpty(title, nameof(title));
            //Guard.ArgumentNotNull(observations, nameof(observations));
            //Guard.ArgumentNotNull(dateStart, nameof(dateStart));
            //Guard.ArgumentNotNull(dateEnd, nameof(dateEnd));
            Title = title;
            Container = container;
            ProblemData = problemData;
            CorrectAnswer = correctAnswer;
            FinallyAnswer = finallyAnswer;
            DateStart = dateStart;
            DateEnd = dateEnd;
            Week = week;
            Clasa = clasa;
        }

        [StringLength(50, MinimumLength = 5)]
        public string Title { get; set; }

        [Required]
        [MaxLength(300)]
        public string ProblemData { get; set; }


        [Required]
        [MaxLength(1000)]
        public string Container { get; set; }

        [Required]
        public string CorrectAnswer { get; set; }

        [Required]
        public string FinallyAnswer { get; set; }

        [Required]
        public int Week { get; set; }

        [Required]
        public DateTime DateStart { get; set; }

        [Required]
        public DateTime DateEnd { get; set; }

        [Required]
        public string Clasa { get; set; }


      
        //public ICollection<Grade> Grades { get; private set; }

        //[ForeignKey("Student")]
        //public Guid StudentId { get; private set; }

        //public User User { get; private set; }

    }
}
