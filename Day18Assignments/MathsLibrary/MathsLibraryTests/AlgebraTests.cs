using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsLibrary.Tests
{
    [TestClass()]
    public class AlgebraTests
    {
        [TestMethod()]
        public void FactorialTest_Zero_Input()
        {
            //Arrange
            int n = 0;
            int expected = 1;

            //Actual
            int actual = Algebra.Factorial(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void FactorialTest_UptoSeven_Input()
        {
            //Arrange
            int n = 7;
            int expected = 5040;

            //Actual
            int actual = Algebra.Factorial(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void FactorialTest_LessthanZero_Input()
        {
            //Arrange
            int n = -5;
            int expected = -9999;

            //Actual
            int actual = Algebra.Factorial(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void FactorialTest_Greaterthan_Seven_Input()
        {
            //Arrange
            int n = 8;
            int expected = -999;

            //Actual
            int actual = Algebra.Factorial(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PalindromeTest_Correct_Input()
        {
            //Arrange
            int n = 121;
            string expected = "Palindrome";

            //Act
            string actual = Algebra.Palindrome(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PalindromeTest_Wrong_Input()
        {
            //Arrange
            int n = 132;
            string expected = "Not Palindrome";

            //Act
            string actual = Algebra.Palindrome(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}