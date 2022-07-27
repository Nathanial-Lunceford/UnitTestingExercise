using System;
using Xunit;
using UnitTestingExercise;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 5, 3, 10)]
        [InlineData(1, 2, 3, 6)]
        [InlineData(5, 5, -5, 5)]
        [InlineData(0, 5, 10, 15)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            UnitTestMethods testAdd = new UnitTestMethods();

            //Act
            var actual = testAdd.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(20, 2, 18)]
        [InlineData(0, 10, -10)]
        [InlineData(4, -2, 6)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var testSubtract= new UnitTestMethods();

            //Act
            var actual = testSubtract.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 10, 20)]
        [InlineData(5, 3, 15)]
        [InlineData(0, 10, 0)]
        [InlineData(-2, -3, 6)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var testMult = new UnitTestMethods();

            //Act
            var actual = testMult.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20, 5, 4)]
        [InlineData(6, 3, 2)]
        [InlineData(-10, 2, -5)]
        [InlineData(30, 10, 3)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var testDivide = new UnitTestMethods();
            //Act
            var actual = testDivide.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void YourMethodName()
        {
            //Arrange
            var expected = "Hello World";
            var testMethodOne = new UnitTestMethods();
            //Act
            var actual = testMethodOne.MyMethodOne();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange
            var expected = "This is a test";
            var testMethodTwo = new UnitTestMethods();

            //Act
            var actual = testMethodTwo.MyMethodTwo();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
