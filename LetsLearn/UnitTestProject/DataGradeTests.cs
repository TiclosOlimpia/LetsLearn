using System;
using LetsLearn.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class DataGradeTests
    {
        [TestMethod]
        public void TestGrade_With_Consturctor()
        {
            //Arrange
            int value = 10;
            DateTime date = DateTime.Now;
            int week = 7;
            string homework = "nu";
            string studentId = "studentId";
            string teacherId = "Test for teacherId";


            //Act
            LetsLearn.Data.Grade grade = new LetsLearn.Data.Grade(value, date, week, homework, studentId, teacherId);

            //Assert
            Assert.AreEqual(value, grade.Value);
            Assert.AreEqual(date, grade.Date);
            Assert.AreEqual(week, grade.Week);
            Assert.AreEqual(homework, grade.Homework);
            Assert.AreEqual(studentId, grade.StudentId);
            Assert.AreEqual(teacherId, grade.TeacherId);
        }

        [TestMethod]
        public void TestGrade_WithOut_Consturctor()
        {
            //Arrange
            int value = 10;
            DateTime date = DateTime.Now;
            int week = 7;
            string homework = "TesteHomeworkId";
            string studentId = "TestStudentId";
            string teacherId = "Test for teacherId";

            //Act
            LetsLearn.Data.Grade grade = new Grade();

            grade.Value = value;
            grade.Date = date;
            grade.Week = week;
            grade.Homework = homework;
            grade.StudentId = studentId;
            grade.TeacherId = teacherId;

            //Assert
            Assert.AreEqual(value, grade.Value);
            Assert.AreEqual(date, grade.Date);
            Assert.AreEqual(week, grade.Week);
            Assert.AreEqual(homework, grade.Homework);
            Assert.AreEqual(studentId, grade.StudentId);
            Assert.AreEqual(teacherId, grade.TeacherId);
        }
    }
}
