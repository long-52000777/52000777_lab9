using StudentServiceLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudentTest
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void studentSore8_returnA()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Long";
            s.Age = 20;
            s.Score = 8;

            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);
        }

        [TestMethod]
        public void studentSore7_returnB()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Long";
            s.Age = 20;
            s.Score = 7;

            char letter = s.getLetterScore();
            Assert.AreEqual('B', letter);
        }

        [TestMethod]
        public void studentSore6_returnC()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Long";
            s.Age = 20;
            s.Score = 6;

            char letter = s.getLetterScore();
            Assert.AreEqual('C', letter);
        }

        [TestMethod]
        public void studentSore3_returnE()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Long";
            s.Age = 20;
            s.Score = 3;

            char letter = s.getLetterScore();
            Assert.AreEqual('E', letter);
        }

        [TestMethod]
        [ExpectedException(typeof(SystemException))]
        public void studentScoreLessThan0_throwSystemException()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Long";
            s.Age = 20;
            s.Score = -1;
        }

        [TestMethod]
        [ExpectedException(typeof(SystemException))]
        public void studentScoreMoreThan0AndLessThan10_notThrowSystemException()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Long";
            s.Age = 20;
            s.Score = 8;
        }

        [TestMethod]
        [ExpectedException(typeof(SystemException))]
        public void studentScoreMoreThan10_throwSystemException()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Long";
            s.Age = 20;
            s.Score = 11;
        }
    }
}