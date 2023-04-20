using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block3Labs
{
    internal class ChangeLab
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coin Sorter");
            Console.WriteLine("");
            //variable is equal to the remaining after division ** %= **
            Console.WriteLine("How much money do you have?");
            decimal totalMoney = decimal.Parse(Console.ReadLine());
            int pennies = (int)(totalMoney * 100);
            Console.WriteLine(pennies);
            int quarter = pennies / 25;
            pennies %= 25;
            Console.WriteLine(pennies);
            int dime = pennies / 10;
            pennies %= 10;
            Console.WriteLine(pennies);
            int nickle = pennies / 5;
            pennies %= 5;
            Console.WriteLine(pennies);
            Console.WriteLine($"You have: {quarter} quarters {dime} dimes, {nickle} nickles, and {pennies} pennies.");
            

        }//end main()
    }//end class
}//end name
