/*
 * Purpose: Ask user for the price of the item and quantity.
 * 
 * Input: priceAns, quantityAns.
 * 
 * Output: Subtotal, provincial tax, federal tax, total tax and total price.
 * 
 * Written by: Phoenix Del Mundo
 * 
 * Written for: Sam Wu
 * 
 * Section A01
 */
using System;

namespace CPSC1012_Lab01_Phoenix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            double subTotal,
                totalST,
                totalAnswer,
                totalTx,
                totalPrice;
            double provST = 0.06;
            double fedST = 0.05;

            //Questions
            Console.WriteLine("**********Welcome to the General Store**********");//Title
            Console.Write("Enter price of the item: "); //Calculating price of item
            double priceAns = double.Parse(Console.ReadLine());

            Console.Write("Enter the quantity being purchased: "); //Calcuation quantity of item
            int quantityAns = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nInvoice Summary \n==================");

            //Calculations
            subTotal = priceAns * quantityAns; // Total price before tax calculation
            provST = provST * subTotal; // Provincial tax calculation 
            fedST = fedST * subTotal; // Federal tax calculation
            totalTx = provST + fedST; // Total tax calculation
            totalPrice = subTotal + provST + fedST; // Total price calculation
           
            //Reciepts
            Console.WriteLine($"Subtotal: {subTotal :C}\n\nProvincial Tax: {provST :C}\nFederal Tax: {fedST :C}");
            Console.Write($"Total Tax: {totalTx :C}\n\nTotal Price: {totalPrice :C}\n==================\n\n\n");
        }
    }
}
