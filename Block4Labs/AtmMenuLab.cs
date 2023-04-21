using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block4Labs
{
    internal class AtmMenuLab
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ATM Lab\n\n");
            decimal strBal = 100;
            Console.WriteLine("ATM");
            Console.WriteLine("Enter pin number: ");
            int pin = int.Parse(Console.ReadLine());
            if (pin == 1260)
            {
                Console.WriteLine("Welcome!");
            }
            else
            {
                Console.WriteLine("Invalid PIN");
            }
            Console.WriteLine("Please type what action you would like to complete below, The options are: Balance, Deposit, Withdraw, or Exit.");
            string action = Console.ReadLine().ToLower();
            switch (action)
            {
                case "balance":
                    Console.WriteLine(strBal);
                    break;
                case "deposit":
                    Console.WriteLine("How much do you want to deposit?");
                    decimal dep = decimal.Parse(Console.ReadLine());
                    Console.WriteLine($"You have {dep:c} deposited into your account.");
                    Console.WriteLine($"Your new balance is {strBal + dep:c}");
                    break;
                case "withdraw":
                    Console.WriteLine("How much do you want to withdraw?");
                    decimal wit = decimal.Parse(Console.ReadLine());
                    Console.WriteLine($"You have withdrawn {wit:c} from your account.");
                    Console.WriteLine($"Your new balance is {strBal - wit}");
                    break;
                case "exit":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("INPUT NOT FOUND\a - please try again..");
                    break;
            }


        }//main
    }//class
}//name
