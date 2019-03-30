using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Rewrite.Internal.UrlActions;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LetsLearn.Data
{
    public class User_homework : BaseEntity
    {
        public User user { get; set; }
        public Homework homework { get; set; }
        public string userId { get; set; }
        public string homeworkId { get; set; }
    }
    

}
