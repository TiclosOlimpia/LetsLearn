using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class DataUserTests
    {
        [TestMethod]
        public void TestUser_With_Consturctor()
        {
            //Arrange
            string firstName = "TestF";
            string lastName = "TestL";
            string userName = "TestU";
            string password = "TestP";
            string emailAdress = "TestE";
            bool IsTeacher = false;
            string clasa = "clasa I A";
            float medie = 8.56f;
            string image = "/Image.jpg";

            //Act
            LetsLearn.Data.User student = new LetsLearn.Data.User(firstName, lastName, userName, password, emailAdress, IsTeacher, clasa, image, medie);

            //Assert
            Assert.AreEqual(firstName, student.FirstName);
            Assert.AreEqual(lastName, student.LastName);
            Assert.AreEqual(userName, student.UserName);
            Assert.AreEqual(password, student.Password);
            Assert.AreEqual(emailAdress, student.EmailAddress);
            Assert.AreEqual(IsTeacher, student.IsTeacher);
            Assert.AreEqual(clasa, student.Clasa);
            Assert.AreEqual(medie, student.Average);
            Assert.AreEqual(image, student.Image);
        }

        [TestMethod]
        public void TestUser_WithOut_Consturctor()
        {
            //Arrange
            string firstName = "TestF";
            string lastName = "TestL";
            string userName = "TestU";
            string password = "TestP";
            string emailAdress = "TestE";
            bool IsTeacher = false;
            string clasa = "clasa I A";
            float medie = 8.56f;
            string image = "/Image.jpg";

            //Act
            LetsLearn.Data.User student = new LetsLearn.Data.User();

            student.FirstName = firstName;
            student.LastName = lastName;
            student.EmailAddress = emailAdress;
            student.UserName = userName;
            student.Password = password;
            student.IsTeacher = IsTeacher;
            student.Clasa = clasa;
            student.Image = image;
            student.Average = medie;

            //Assert
            Assert.AreEqual(firstName, student.FirstName);
            Assert.AreEqual(lastName, student.LastName);
            Assert.AreEqual(userName, student.UserName);
            Assert.AreEqual(password, student.Password);
            Assert.AreEqual(emailAdress, student.EmailAddress);
            Assert.AreEqual(IsTeacher, student.IsTeacher);
            Assert.AreEqual(clasa, student.Clasa);
            Assert.AreEqual(medie, student.Average);
            Assert.AreEqual(image, student.Image);
        }
    }
}
