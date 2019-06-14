using System;
using LetsLearn.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class DataGridTests
    {
        [TestMethod]
        public void TestGrid_With_Consturctor()
        {
            //Arrange
            string title = "TestTitle";
            string container = "TestCOntainer";
            string correctAnswer = "TestCorectAnswer";
            string answer1 = "Answer1";
            string answer2 = "Answer2";
            string answer3 = "Answer3";
            int week = 3;
            System.DateTime dateStart = DateTime.Now;
            System.DateTime dateEnd = DateTime.Now;
            string clasa = "clasa I A";
            string teacherId = "Test for teacherId";


            //Act
            LetsLearn.Data.GridExercice exercice = new LetsLearn.Data.GridExercice(title, container, correctAnswer, answer1, answer2, answer3, week, dateStart, dateEnd, clasa, teacherId);

            //Assert
            Assert.AreEqual(title, exercice.Title);
            Assert.AreEqual(container, exercice.Container);
            Assert.AreEqual(correctAnswer, exercice.CorrectAnswer);
            Assert.AreEqual(answer1, exercice.Answer1);
            Assert.AreEqual(answer2, exercice.Answer2);
            Assert.AreEqual(answer3, exercice.Answer3);
            Assert.AreEqual(week, exercice.Week);
            Assert.AreEqual(dateStart, exercice.DateStart);
            Assert.AreEqual(dateEnd, exercice.DateEnd);
            Assert.AreEqual(clasa, exercice.Clasa);
            Assert.AreEqual(teacherId, exercice.TeacherId);
        }

        [TestMethod]
        public void TestGrid_WithOut_Consturctor()
        {
            //Arrange
            string title = "TestTitle";
            string container = "TestCOntainer";
            string correctAnswer = "TestCorectAnswer";
            string answer1 = "Answer1";
            string answer2 = "Answer2";
            string answer3 = "Answer3";
            int week = 3;
            System.DateTime dateStart = DateTime.Now;
            System.DateTime dateEnd = DateTime.Now;
            string clasa = "clasa I A";
            string teacherId = "Test for teacherId";

            //Act
            LetsLearn.Data.GridExercice exercice = new GridExercice();

            exercice.Title = title;
            exercice.Container = container;
            exercice.CorrectAnswer = correctAnswer;
            exercice.Answer1 = answer1;
            exercice.Answer2 = answer2;
            exercice.Answer3 = answer3;
            exercice.Week = week;
            exercice.DateStart = dateStart;
            exercice.DateEnd = dateEnd;
            exercice.Clasa = clasa;
            exercice.TeacherId = teacherId;

            //Assert
            Assert.AreEqual(title, exercice.Title);
            Assert.AreEqual(container, exercice.Container);
            Assert.AreEqual(correctAnswer, exercice.CorrectAnswer);
            Assert.AreEqual(answer1, exercice.Answer1);
            Assert.AreEqual(answer2, exercice.Answer2);
            Assert.AreEqual(answer3, exercice.Answer3);
            Assert.AreEqual(week, exercice.Week);
            Assert.AreEqual(dateStart, exercice.DateStart);
            Assert.AreEqual(dateEnd, exercice.DateEnd);
            Assert.AreEqual(clasa, exercice.Clasa);
            Assert.AreEqual(teacherId, exercice.TeacherId);
        }
    }
}
