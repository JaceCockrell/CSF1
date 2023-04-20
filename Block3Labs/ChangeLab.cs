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
            //variable is equal to is remaining %=
            Console.WriteLine("How much money do you have?");
            double totalMoney = double.Parse(Console.ReadLine());
            int pennies = (int)(totalMoney * 100);
            int quarter = pennies / 25;
            pennies %= 25;
            int dime = pennies / 10;
            pennies %= 10;
            int nickle = pennies / 5;
            pennies %= 5;
            int penny = pennies / 1;
            Console.WriteLine($"You have: {quarter} quarters {dime} dimes, {nickle} nickles, and {penny} pennies.");
            

        }//end main()
    }//end class
}//end name
