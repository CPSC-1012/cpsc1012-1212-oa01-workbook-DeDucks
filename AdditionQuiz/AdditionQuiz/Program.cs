using System;

namespace AdditionQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int minNumber = 1; //Const = number will not change
            const int maxNumber = 9;

            Random rand = new Random();
            int number1 = rand.Next(minNumber, maxNumber + 1);
            int number2 = rand.Next(minNumber, maxNumber + 1);
            int correctAnswer = number1 + number2;
            Console.Write($"What is {number1} + {number2} = ");
            int userAnswer = int.Parse(Console.ReadLine());
            Console.WriteLine($"{number1} + {number2} = {userAnswer} is {userAnswer == correctAnswer}");
        }
    }
}
