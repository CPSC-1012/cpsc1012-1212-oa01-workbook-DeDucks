/* Purpose: Sum the digits of a number.
 * 
 * Inputs:A three digit number. 
 * 
 * Outputs: The sum of digits of the number.
 * 
 */
using System;

namespace ArithmeticProblems_Question04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int origNum,
                number,
                digit1,
                digit2,
                digit3,
                sum;

            Console.WriteLine("Enter a three digit number: ");
            origNum = int.Parse(Console.ReadLine());
            number = origNum;
            digit1 = number % 10;
            number = number / 10;

            digit2 = number % 10;
            number = number / 10;

            digit3 = number % 10;
            number = number / 10;

            sum = digit1 + digit2 + digit3;

            Console.WriteLine($"The sum of the number is {sum}");





        }
    }
}
