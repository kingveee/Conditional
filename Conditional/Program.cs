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
            //How many people in your party
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
                Console.WriteLine(finalCost);



            }

           






        }
    }
}