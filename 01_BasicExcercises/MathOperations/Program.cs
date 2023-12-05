using System;
namespace MathOperations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Subtracting two numbers and the are negative
            int result = Calculator.SubtractNumbers(-10, -20);
            System.Console.WriteLine("Subtracted numbers: " + result);

            //input maximum allowed value upto 100 and returns the second power of that number
            System.Console.WriteLine("Enter an integer up to 100");
            if (int.TryParse(Console.ReadLine(), out int userInput))
            {
                if (userInput <= 100)
                {
                    int square = (int)Calculator.CalculateSquare(userInput);
                    Console.WriteLine("The second power of " + userInput + ": " + square);
                }
                else
                {
                    Console.WriteLine("Input value exceeds the maximum allowed value of 100.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            //returns the squareroot of the integer number
            Console.WriteLine("Enter an integer:");
            if (int.TryParse(Console.ReadLine(), out int userInput2))
            {
                double result3 = Calculator.CalculateSquareRoot(userInput2);
                Console.WriteLine("The square root of " + userInput2 + ": " + result3);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            //finding the smallest number in a list of type double 
            List<double> list = new List<double> { 2, 6, 10, 3, 15 };
            int smallestNumber = (int)Calculator.FindSmallestNumber(list);
            Console.WriteLine("The smallest number in the list is: " + smallestNumber);

            //finding the largest number in a list of type int
            List<int> list2 = new List<int> { 5, 2, 8, 10, 3, 1, 7 };
            int largestNumber = Calculator.FindLargestNumber(list2);
            Console.WriteLine("The largest number in the list is: " + largestNumber);

            //calculates the average of the numbers in a list of type float
            List<float> list3 = new List<float>{4f,14f, 20f, 6f, 8f};
            float averageNumber = Calculator.FindAverageNumber(list3);
            System.Console.WriteLine("The average number in the list is: " + averageNumber);

        }

    }
}
