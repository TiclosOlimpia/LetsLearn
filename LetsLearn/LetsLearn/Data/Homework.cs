using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace LetsLearn.Data
{
    public class Homework : BaseEntity
    {
        public Homework()
        {

        }

        public Homework(string title, string observations, DateTime dateStart, DateTime dateEnd)
        {
            Id = Guid.NewGuid().ToString();
            //Guard.ArgumentNotNullOrEmpty(title, nameof(title));
            //Guard.ArgumentNotNull(observations, nameof(observations));
            //Guard.ArgumentNotNull(dateStart, nameof(dateStart));
            //Guard.ArgumentNotNull(dateEnd, nameof(dateEnd));
            Title = title;
            Observations = observations;
            DateStart = dateStart;
            DateEnd = dateEnd;
        }

        [StringLength(50, MinimumLength = 5)]
        public string Title { get; set; }

        [MaxLength(100)]
        public string Observations { get; set; }

        [Required]
        public DateTime DateStart { get; set; }

        [Required]
        public DateTime DateEnd { get; set; }



        //public ICollection<Grade> Grades { get; private set; }

        //[ForeignKey("Student")]
        //public Guid StudentId { get; private set; }

        //public User User { get; private set; }

    }
}
