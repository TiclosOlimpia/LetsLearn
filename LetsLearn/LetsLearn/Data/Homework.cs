using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using LetsLearn.Models;


namespace LetsLearn.Data
{
    public class Homework : BaseEntity
    {
        public Homework()
        {

        }

        public Homework(string title, string container, string correctAnswear,string answear1, string answear2, string answear3, int week, DateTime dateStart, DateTime dateEnd, string clasa)
        {
            Id = Guid.NewGuid().ToString();
            //Guard.ArgumentNotNullOrEmpty(title, nameof(title));
            //Guard.ArgumentNotNull(observations, nameof(observations));
            //Guard.ArgumentNotNull(dateStart, nameof(dateStart));
            //Guard.ArgumentNotNull(dateEnd, nameof(dateEnd));
            Title = title;
            Container = container;
            CorrectAnsear = correctAnswear;
            Ansear1 = answear1;
            Ansear2 = answear2;
            Ansear3 = answear3;
            DateStart = dateStart;
            DateEnd = dateEnd;
            Week = week;
            Clasa = clasa;
        }

        [StringLength(50, MinimumLength = 5)]
        public string Title { get; set; }

        [Required]
        [MaxLength(100)]
        public string Container { get; set; }

        [Required]
        public string CorrectAnsear { get; set; }

        [Required]
        public string Ansear1 { get; set; }

        [Required]
        public string Ansear2 { get; set; }

        [Required]
        public string Ansear3 { get; set; }

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
