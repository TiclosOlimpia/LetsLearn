using System;
using LetsLearn.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class DataSolvedHomeworkTests
    {
        [TestMethod]
        public void TestSolvedHomework_With_Consturctor()
        {
            //Arrange
            string studentId = "TesteStudentId";
            string homeworkId = "TestHomeworkId";
            string studentAnswer = "Test for answer";
            string correctAnswer = "Test for correct answer";   

            //Act
            LetsLearn.Data.SolvedHomework solvedHomework = new LetsLearn.Data.SolvedHomework(studentId, homeworkId, studentAnswer, correctAnswer);
            
            //Assert
            Assert.AreEqual(studentId, solvedHomework.StudentId);
            Assert.AreEqual(homeworkId, solvedHomework.HomeworkId);
            Assert.AreEqual(studentAnswer, solvedHomework.StudentAnswer);
            Assert.AreEqual(correctAnswer, solvedHomework.CorrectAnswer);
        }

        [TestMethod]
        public void TestSolvedHomework_WithOut_Consturctor()
        {
            //Arrange
            string studentId = "TesteStudentId";
            string homeworkId = "TestHomeworkId";
            string studentAnswer = "Test for answer";
            string correctAnswer = "Test for correct answer";

            //Act
            LetsLearn.Data.SolvedHomework solvedHomework = new SolvedHomework();

            solvedHomework.StudentId = studentId;
            solvedHomework.HomeworkId = homeworkId;
            solvedHomework.StudentAnswer = studentAnswer;
            solvedHomework.CorrectAnswer = correctAnswer;

            //Assert
            Assert.AreEqual(studentId, solvedHomework.StudentId);
            Assert.AreEqual(homeworkId, solvedHomework.HomeworkId);
            Assert.AreEqual(studentAnswer, solvedHomework.StudentAnswer);
            Assert.AreEqual(correctAnswer, solvedHomework.CorrectAnswer);
        }
    }
}
