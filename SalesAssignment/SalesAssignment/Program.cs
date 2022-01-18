using System;

namespace SalesAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salePrice;
            const double saleTaxRate = 0.05;
            double saleTax;
            double saleTotal;
            string userAnswer;

            Console.Write("Enter is the sales price: ");
            userAnswer = Console.ReadLine();
            salePrice = double.Parse(userAnswer); //Converts string format to double format.

            saleTax = salePrice * saleTaxRate;
            saleTotal = salePrice + saleTax;

            Console.WriteLine($"The tax is: {saleTax}");
            Console.WriteLine($"The total price is: {saleTotal}");

        }
    }
}
