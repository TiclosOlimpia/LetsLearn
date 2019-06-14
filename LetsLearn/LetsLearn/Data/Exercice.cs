using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using LetsLearn.Models;


namespace LetsLearn.Data
{
    public class Exercice : BaseEntity
    {
        public Exercice()
        {

        }

        public Exercice(string title, string container, string correctAnswer, string finallyAnswer, int week, DateTime dateStart, DateTime dateEnd, string clasa, string teacherId)
        {
            Id = Guid.NewGuid().ToString();
            //Guard.ArgumentNotNullOrEmpty(title, nameof(title));
            //Guard.ArgumentNotNull(observations, nameof(observations));
            //Guard.ArgumentNotNull(dateStart, nameof(dateStart));
            //Guard.ArgumentNotNull(dateEnd, nameof(dateEnd));
            Title = title;
            Container = container;
            CorrectAnswer = correctAnswer;
            FinallyAnswer = finallyAnswer;
            DateStart = dateStart;
            DateEnd = dateEnd;
            Week = week;
            Clasa = clasa;
            TeacherId = teacherId;
        }

        [StringLength(50, MinimumLength = 5)]
        public string Title { get; set; }

        [Required]
        [MaxLength(500)]
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

        [Required]
        public string TeacherId { get; set; }

        //public ICollection<Grade> Grades { get; private set; }

        //[ForeignKey("Student")]
        //public Guid StudentId { get; private set; }

        //public User User { get; private set; }

    }
}
