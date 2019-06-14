using System;
using LetsLearn.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class DataExerciceTests
    {
        [TestMethod]
        public void TestExercice_With_Consturctor()
        {
            //Arrange
            string title = "TestTitle";
            string container = "TestCOntainer";
            string correctAnswer = "TestCorectAnswer";
            string finallyAnswer = "TestFinallyAnswer";
            int week = 3;
            System.DateTime dateStart = DateTime.Now;
            System.DateTime dateEnd = DateTime.Now;
            string clasa = "clasa I A";
            string teacherId = "Test for teacherId";

            

            //Act
            LetsLearn.Data.Exercice exercice = new LetsLearn.Data.Exercice(title, container, correctAnswer, finallyAnswer, week, dateStart, dateEnd, clasa, teacherId);

            //Assert
            Assert.AreEqual(title, exercice.Title);
            Assert.AreEqual(container, exercice.Container);
            Assert.AreEqual(correctAnswer, exercice.CorrectAnswer);
            Assert.AreEqual(finallyAnswer, exercice.FinallyAnswer);
            Assert.AreEqual(week, exercice.Week);
            Assert.AreEqual(dateStart, exercice.DateStart);
            Assert.AreEqual(dateEnd, exercice.DateEnd);
            Assert.AreEqual(clasa, exercice.Clasa);
            Assert.AreEqual(teacherId, exercice.TeacherId);
        }

        [TestMethod]
        public void TestExercice_WithOut_Consturctor()
        {
            //Arrange
            string title = "TestTitle";
            string container = "TestCOntainer";
            string correctAnswer = "TestCorectAnswer";
            string finallyAnswer = "TestFinallyAnswer";
            int week = 3;
            System.DateTime dateStart = DateTime.Now;
            System.DateTime dateEnd = DateTime.Now;
            string clasa = "clasa I A";
            string teacherId = "Test for teacherId";


            //Act
            LetsLearn.Data.Exercice exercice = new Exercice();

            exercice.Title = title;
            exercice.Container = container;
            exercice.CorrectAnswer = correctAnswer;
            exercice.FinallyAnswer = finallyAnswer;
            exercice.Week = week;
            exercice.DateStart = dateStart;
            exercice.DateEnd = dateEnd;
            exercice.Clasa = clasa;

            //Assert
            Assert.AreEqual(title, exercice.Title);
            Assert.AreEqual(container, exercice.Container);
            Assert.AreEqual(correctAnswer, exercice.CorrectAnswer);
            Assert.AreEqual(finallyAnswer, exercice.FinallyAnswer);
            Assert.AreEqual(week, exercice.Week);
            Assert.AreEqual(dateStart, exercice.DateStart);
            Assert.AreEqual(dateEnd, exercice.DateEnd);
            Assert.AreEqual(clasa, exercice.Clasa);
        }
    }
}
