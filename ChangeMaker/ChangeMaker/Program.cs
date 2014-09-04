using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //run our ChangeMaker function
            ChangeMaker(4.17);
            ChangeMaker(3.18);
            ChangeMaker(0.99);
            ChangeMaker(12.93);

            //keep console open
            Console.ReadKey();
        }

        //functions go here
        static void ChangeMaker(double amount)
        {
            //claim variables
            double total = amount;
            double quarters = 0;
            double dimes = 0;
            double nickels = 0;
            double pennies = 0;

        //run while loops for each denomination
            //use a while loop since we dont know when it will stop but while the total is still bigger than the largest coin denomination
            //while total is still greater than a quarter
            while (total > 0.25)
            {
                //each time theres a quarter, add it to our quarter count and add it to our total amount
                total -= 0.25;
                quarters++;
            }
            //while total is larger than a dime
            while (total > 0.10)
            {
                //add the times to the total and to the dimes count
                total -= 0.10;
                dimes++;
            }
            //while total is larger than a nickel
            while (total > 0.05)
            {
                //add to the total amount and to the nickels count
                total -= 0.05;
                nickels++;
            }
            //while total is lager than a penny
            while (total > 0.01)
            {
                //add the penny to the total amount and to the pennies count
                total -= 0.01;
                pennies++;
            }
            //print out in this order: the total amount, then the counts of all coins
            Console.WriteLine("Amount: $" + amount);
            Console.WriteLine("Quarters: " + quarters);
            Console.WriteLine("Dimes: " + dimes);
            Console.WriteLine("Nickels: " + nickels);
            Console.WriteLine("Pennies: " + pennies);

        }
    }
}
