using System;

namespace SeqeuenceStructureExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            EXERCISE 1
            string charName;
            int ageNum;
            double salaryNum;
            
            Console.Write("What is your name? ");
            charName = Console.ReadLine();

            Console.Write("Enter your age: ");
            ageNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is your expected salary in the future? ");
            salaryNum = double.Parse(Console.ReadLine());

            Console.WriteLine($"\nYour name is {charName}, your age is {ageNum} and your expected salary is ${salaryNum}");
            */


            /*EXERCISE 2

            double rNum;
            double lNum;
            double hNum;

            Console.Write("Enter the radius: ");
            rNum = double.Parse(Console.ReadLine());

            Console.Write("Enter the height: ");
            hNum = double.Parse(Console.ReadLine());    

            Console.Write("Enter the lenght: ");
            lNum = double.Parse(Console.ReadLine());

            double area = 2 * Math.PI * rNum * hNum + 2 * Math.PI * rNum * rNum; 
            double volume = Math.PI * rNum * rNum * hNum;

            Console.WriteLine($"\nThe area of the cylinder is: {area}");
            Console.WriteLine($"The volume of the cylinder is: {volume}\n");
            */


            /*EXERCISE 3
            
            double lS;
            double aN;

            Console.Write("Enter the length of the hexagon: ");
            lS = double.Parse(Console.ReadLine());

            aN = 3 * Math.Sqrt(3) / 2 * lS * lS;

            Console.WriteLine($"The area of the hexagon is {aN}");
            */

            double iA;
            double fV;
            double aIR;
            double mIR;
            double nY;

            Console.WriteLine($"Enter the invesment amount: ");
            iA = double.Parse(Console.ReadLine());

            Console.WriteLine($"Enter the annual interest rate in percentage: ");
            aIR = double.Parse(Console.ReadLine());

            Console.WriteLine($"Enter the number of years: ");
            nY = double.Parse(Console.ReadLine());

            mIR = aIR / 12 / 100;

            fV = iA * (1 + mIR) * nY;

            Console.WriteLine($"Future value is {fV}");
            



        }
    }
}
