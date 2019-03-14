using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LetsLearn.Models;

namespace LetsLearn.Data
{
    public sealed class ManagementContext : DbContext
    {
        public ManagementContext(DbContextOptions<ManagementContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public ManagementContext()
        {

        }


        public DbSet<User> Users { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<Grade> Grades { get; set; }
        //public DbSet<LetsLearn.Models.UserModel> userModel { get; set; }

        //internal Task GetById<T>(string? id)
        //{
        //    throw new NotImplementedException();
        //}

        //public DbSet<LetsLearn.Models.GradeModel> GradeModel { get; set; }

        //public DbSet<LetsLearn.Models.HomeworkModel> HomeworkModel { get; set; }

        //public DbSet<ManagementOfExams.Models.TeacherIndexListingModel> TeacherIndexListingModel { get; set; }
    }
}
