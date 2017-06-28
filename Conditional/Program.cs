using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            /* //How many people in your party
             //Total cost of one meal
             //Total cost of whole party
             //Total of splitting meals by party
             //Discount of 10% over $50 and 5% under $50

             Console.WriteLine("Thank you for eating here at");

             Console.WriteLine("How many people in your party?");
             double totalParty = double.Parse(Console.ReadLine());

             Console.WriteLine("How much did meal cost?");
             double mealCost = double.Parse(Console.ReadLine());

             Console.WriteLine("10% discount meals over $50 and 5% discount meals under %50");
             double indiviualCost = (mealCost / totalParty);



              double cost = mealCost;

              if (cost >= 50)
              {
                 Console.WriteLine("You get a 10% discount");
                 double bigDiscount = (mealCost * .90);

                 Console.WriteLine(bigDiscount);
                 double finalCost = (bigDiscount / totalParty);

                 Console.WriteLine("Cost after split");
                 Console.WriteLine(finalCost);

             }
             else
             {
                 Console.WriteLine("You get a 5% discount");
                 double littleDiscount = (mealCost * .95);

                 Console.WriteLine(littleDiscount);
                 double finalCost = (littleDiscount / totalParty);

                 Console.WriteLine("Cost after split");
                 Console.WriteLine(finalCost);    */




            /*
            int age = 0;
            if (age =)

            {
                Console.WriteLine("Still in Mamas arm");
            }
            else if (age >= 3 && age <= 4);

            {
                Console.WriteLine("Preschool Maniac");
            }
            else if (age <= 5 && age >= 11);
            
            */



            Console.WriteLine("Please enter a number from word form");
            string numberWord = Console.ReadLine();

         
            switch (numberWord)

            {
                case "zero":
                    Console.WriteLine("0 ");
                    break;

                case "one":
                    Console.WriteLine("1");
                    break;

                case "two":
                    Console.WriteLine("2");
                    break;

                case "three":
                    Console.WriteLine("3");
                    break;

                case "four":
                    Console.WriteLine("4");
                    break;

                case "five":
                    Console.WriteLine("5");
                    break;

                case "six":
                    Console.WriteLine("6");
                    break;

                case "seven":
                    Console.WriteLine("7");
                    break;

                default:
                    Console.WriteLine("invalid");
                    break;

                    



            }

















        }
    }
}