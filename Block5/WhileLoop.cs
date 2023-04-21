using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block5
{
    internal class WhileLoop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Looping with WHILE");
            Console.Title = "Looping with WHILE";
            /*While loop - best for when you want to run code
             * an indeterminable number of times
             * (0 to ???)
             * 
             * COUNTER
             * 
             * while (CONDITION)
             * {
             *      //code to run
             *      UPDATE
             * }
             */

            int cookie = 1;
            while (cookie <= 5)//condition
            {
                Console.WriteLine($"Yum! You have eaten {cookie} cookie{(cookie == 1 ? "" : "s")}!");
                cookie++;//update
                //Ternary Operator quick inline if/else statement
                //Boolean Expression ? truePart : falsePart
            }//end  while 

            //It is most common to use a while loop with a bool for a counter
            //that allows us to conditionallly change the bool when we want to exit the loop
            bool moreBags = true;
            while (moreBags) 
            {
                Console.WriteLine("You have unloaded some groceries.\n");
                Console.Write("Do you have any more bags? Y/N:");
                //consoleKey
                ConsoleKey answer = Console.ReadKey(true).Key;
                if (answer == ConsoleKey.N)
                {
                    moreBags = false;//update
                }//if
            }//while

            Console.Write("Would you like to play a game? Y/N: ");
            bool play = Console.ReadKey().KeyChar.ToString().ToUpper() == "Y";
            while (play)
            {
                Console.WriteLine("\nYou WIN!!");
                Console.Write("Play again? Y/N");
                play = Console.ReadKey().KeyChar.ToString().ToUpper() == "Y";

            }//end while
            Console.WriteLine();




            #region Footer
            Console.WriteLine("All code has finished. Press any key to terminate the program...");
            Console.ReadLine();

            #endregion

        }//main
    }//class
}//name
