using System.Runtime.InteropServices;
using System.Reflection;
using Xunit;
namespace MathOperations
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(10, -5, 15)]  // Test carse for Positive - Negative = Positive
        [InlineData(-10, -5, -5)] // Test carse for Negative - Negative = Negative
        [InlineData(-10, 5, -15)] // Test carse for Negative - Positive = Negative
        [InlineData(0, -5, 5)]    //Test carse for  Zero - Negative = Positive
        public void SubtractNumbers(int a, int b, int expectedNumber)
        {
            // //Arranage (setup)
            // int a = 2;
            // int b = 1;

            // act(Execution)
            int result = Calculator.SubtractNumbers(a, b);
            System.Console.WriteLine("Hei");

            //Assert(verification)
            Assert.Equal(expectedNumber, result);
        }

        [Theory]
        [InlineData(0, 0)]  // Test case for the minimum allowed value
        [InlineData(5, 25)]  // Test case for a random valid input
        [InlineData(10, 100)] // Test case for another random valid input
        [InlineData(100, 10000)]// Test case for the maximum allowed value
        public void CalculateSquare(int input, double expectednumber)
        {
            //Act
            double result = Calculator.CalculateSquare(input);

            //Assert
            Assert.Equal(expectednumber, result);
        }

        [Theory]
        [InlineData(4, 2)]  // Test case for the square root of 4
        [InlineData(9, 3)]  // Test case for the square root of 9
        [InlineData(25, 5)]  // Test case for the square root of 25
        public void CalculateSquareRoot(int input, double expected)
        {
            double result = Calculator.CalculateSquareRoot(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new double[] { 35, 12, 50, 28, 89 }, 12)] // Test case for Smallest in the list is 12
        [InlineData(new double[] { 2, 6, 10, 13, 20 }, 2)]  // Test case for Smallest in the list is 2
        [InlineData(new double[] { 30, 26, 50, 28, 15 }, 15)]  // Test case for Smallest in the list is 15
        public void FindSmallestNumber(double[] numbers, double expectedResult)
        {
            //Act
            double result = Calculator.FindSmallestNumber(new List<double>(numbers));

            //Assert
            Assert.Equal(expectedResult, result, precision: 15); 
            //Precision refers to the level of detail or accuracy in a measurement or calculation
            //it specify how closely a calculated result should match an expected or desired result.
        }

        [Theory]
        [InlineData(new int[] { 35, 12, 50, 28, 89 }, 89)] // Test case for largest in the list is 12
        [InlineData(new int[] { 2, 6, 10, 13, 20 }, 20)]  // Test case for largest in the list is 2
        [InlineData(new int[] { 30, 26, 50, 28, 15 }, 50)]  // Test case for largest in the list is 15
        public void FindLargestNumber(int[] numbers, double expectedResult)
        {
            //Act
            int result = Calculator.FindLargestNumber(new List<int>(numbers));

            //Assert
            Assert.Equal(expectedResult, result, precision: 15);
        }

        [Theory]
        [InlineData(new float[] { 4f, 14f, 20f, 6f, 8f }, 10.3999996)] // Test case for largest in the list is 12
        [InlineData(new float[] { 2f, 6f, 10f, 13f, 20f }, 10.1999998)]  // Test case for largest in the list is 2
        [InlineData(new float[] { 30f, 26f, 50f, 28f, 15f }, 29.7999992)]  // Test case for largest in the list is 15
        public void FindAverageNumber(float[] numbers, float expectedResult)
        {
            //Act
            float result = Calculator.FindAverageNumber(new List<float>(numbers));
            //Assert
            Assert.Equal(expectedResult, result, precision: 15);

        }


    }
}

