using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block5Lab
{
    class AtmLab
    {
        static void Main(string[] args)
        {
            // set the hard-coded account and PIN numbers
            string accountNumber = "12345";
            string pinNumber = "1234";

            // prompt the user to enter their account number and PIN
            string enteredAccountNumber, enteredPinNumber;
            do
            {
                Console.Write("Enter your account number: ");
                enteredAccountNumber = Console.ReadLine();

                Console.Write("Enter your PIN: ");
                enteredPinNumber = Console.ReadLine();

                if (enteredAccountNumber != accountNumber || enteredPinNumber != pinNumber)
                {
                    Console.WriteLine("Incorrect account number or PIN. Please try again.");
                }
            } while (enteredAccountNumber != accountNumber || enteredPinNumber != pinNumber);

            Console.WriteLine("Welcome to the ATM Application!");

            // Set the starting amount for the account
            double accountBalance = 0;

            bool isRunning = true;

            while (isRunning)
            {
                // Display the menu options to the user
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Balance");
                Console.WriteLine("4. Exit");

                // Prompt the user to enter their selection
                Console.Write("Enter your selection: ");
                string selection = (Console.ReadLine().ToLower());

                // Handle the user's selection
                switch (selection)
                {
                    case "deposit":
                        Console.Write("\nEnter the amount you want to deposit: $");
                        double depositAmount = double.Parse(Console.ReadLine());
                        accountBalance += depositAmount;
                        Console.WriteLine("$" + depositAmount + " has been deposited into account. " + " Your new account balance is: $" + accountBalance);
                        break;

                    case "withdraw":
                        Console.Write("\nEnter the amount you want to withdraw: $");
                        double withdrawAmount = double.Parse(Console.ReadLine());
                        if (withdrawAmount <= accountBalance)
                        {
                            accountBalance -= withdrawAmount;
                            Console.WriteLine("$" + withdrawAmount + " has been withdrawn from your account. " + " Your new account balance is: $" + accountBalance);
                        }
                        else
                        {
                            Console.WriteLine("Insufficient funds. Your current account balance is: $" + accountBalance);
                        }
                        break;

                    case "balance":
                        Console.WriteLine("\nYour current account balance is: $" + accountBalance);
                        break;

                    case "exit":
                        Console.WriteLine("\nThank you for your business!");
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("\a\nInvalid selection. Please try again.");
                        break;
                }

                if (isRunning)
                {
                    // Prompt the user if they want to do another transaction or exit the application
                    Console.Write("\nWould you like to do another transaction? (Y/N): ");
                    string response = Console.ReadLine();

                    if (response.Equals("N"))
                    {
                        Console.WriteLine("\nThank you for your business!");
                        isRunning = false;
                    }
                }
            }

            Console.ReadLine(); // Wait for user input before closing the console window
        }//end main
    }//class
}//name
