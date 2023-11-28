using System;
using System.Security.Cryptography.X509Certificates;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(-1, -1, -2, -4)]
        [InlineData(0, 1, -1, 0)]
        [InlineData(2, 1, 1, 4)]
        //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            var c = new Calculator();
            // create a Calculator object

            //Act

            var actual = c.Add(num1, num2, num3);
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual

            //Assert
            Assert.Equal(expected, actual);

        }




        [Theory]
        [InlineData(3, 1, 2)]
        [InlineData(3, -4, 7)]
        [InlineData(1, 1, 0)]
        [InlineData(3, 6, -3)]

        //Add test data <-------
        public void SubtractTest(int num1, int num2, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var c = new Calculator();
            //Act
            var actual = c.Subtract(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, 6)]//Add test data <-------
        [InlineData(-2, 3, -6)]//Add test data <-------
        [InlineData(0, 3, 0)]//Add test data <-------
        [InlineData(-2, -3, 6)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var c = new Calculator();
            //Act
            var actual = c.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(9, 3, 3)]//Add test data <-------
        [InlineData(9, -3, -3)]//Add test data <-------
        [InlineData(9, 0, 0)]//Add test data <-------
        [InlineData(0, 9, 0)]//Add test data <-------
        [InlineData(-9, -3, 3)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var c = new Calculator();
            //Act
            var actual = c.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
