using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionTool
{
    internal class NumberAdder
    {
        public static void Main(string[] args)
        {
            double sum = 0;
            char userInput = ' ';

            while (userInput != 'q')
            {
                Console.WriteLine("Enter a number (or 'q' to quit): ");
                string input = Console.ReadLine();
                if (input.Length > 0)
                    userInput = input[0];
                else
                    userInput = ' ';
                if (char.IsDigit(userInput))
                {
                    sum += double.Parse(input);
                }
                else if (userInput != 'q')
                {
                    Console.WriteLine("Invalid input. Please enter a number or 'q' to quit.");
                }
            }

            Console.WriteLine("The sum of the numbers you entered is: " + sum);
        }
    }
}