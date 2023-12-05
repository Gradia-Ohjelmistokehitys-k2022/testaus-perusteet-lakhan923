using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathOperations
{
    public class Calculator
    {
        /// @author Laiba khan
        /// <summary>
        ///  Subtract two negative numbers
        /// </summary>
        /// <param name="number1">First number</param>
        /// <param name="number2">Second number</param>
        /// <returns>Combined number</returns> <summary>
        /// Prints the result of two negative numbers
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public static int SubtractNumbers(int number1, int number2)
        {
            return number1 - number2;
        }

        /// <summary>
        /// calculate the square/second power of the number
        /// </summary>
        /// <param name="n">number</param>
        /// <returns>prints the square/second power of the number</returns>
        public static double CalculateSquare(int n)
        {
            return n * n;
        }


        /// <summary>
        /// calculate the squareroot of the integer number
        /// </summary>
        /// <param name="number">number</param>
        /// <returns>prints the squareroot of the integer number</returns>
        public static double CalculateSquareRoot(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Input must be a non-negative integer.");
            }

            return Math.Sqrt(number);
        }

        /// <summary>
        /// Finding the smallest number in a list of type double 
        /// </summary>
        /// <param name="numbers">List<double> numbers</param>
        /// <exception cref="ArgumentException"></exception> <summary>
        /// throw an argument exception if the list empty or null.
        /// </summary>
        /// <returns>prints the smallest number in a list of type double </returns>
        public static double FindSmallestNumber(List<double> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("The list cannot be null or empty.");
            }

            double smallestNumber = numbers[0];
            foreach (double number in numbers)
            {
                if (number < smallestNumber)
                {
                    smallestNumber = number;
                }
            }

            return smallestNumber;
        }

        /// <summary>
        /// finding the largest number in a list of type int
        /// </summary>
        /// <param name="numbers">List<int> numbers</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception> <summary>
        /// throw an argument exception if the list empty or null.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>prints the largest number in a list of type int</returns>
        public static int FindLargestNumber(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("The list cannot be null or empty.");
            }

            int largestNumber = numbers[0];
            foreach (int number in numbers)
            {
                if (number > largestNumber)
                {
                    largestNumber = number;
                }
            }
            return largestNumber;
        }

        /// <summary>
        /// calculates the average of the numbers in a list of type float
        /// </summary>
        /// <param name="numbers">List<float> numbers</param>
        /// <returns>prints the average of the numbers in a list of type float</returns>
        public static float FindAverageNumber(List<float> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("List is empty or null");
            }

            float averageNumber = 0;
            foreach(float number in  numbers)
            {
                averageNumber += number;
            }
            return averageNumber/numbers.Count;

        }
    }
}