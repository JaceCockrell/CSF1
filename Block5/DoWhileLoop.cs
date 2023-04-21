using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block5
{
    internal class DoWhileLoop
    {
        static void Main(string[] args)
        {
            Console.Title = "Looping Do While";
            Console.WriteLine(Console.Title);

            /* Do While Loop - best for when you want to run code
             * an indeterminable number of times BUT
             * at least once!!!
             * (1 to ???)
             * 
             * COUNTER
             * 
             * do
             * {
             *      //code to run
             *      UPDATE
             *      
             * } while (CONDITION);
             */
            int count = 3;
            do
            {
                Console.WriteLine("Count: " + count);
                count += 3;
            } while (count <= 42);
            Console.WriteLine(count);
            count = 10;
            do
            {
                Console.WriteLine("Count: " + count);
                count--;
            } while (count >= 0);
            bool quit = false;
            do
            {
                Console.Write("\nProgram Running\nQuit? Y/N: ");
                ConsoleKey answer = Console.ReadKey().Key;
                switch (answer)
                {
                    case ConsoleKey.Y:
                        //return;
                        quit = true;
                        break;
                    case ConsoleKey.N:
                        continue;
                    default:
                        Console.WriteLine("Input not understood. Please try again..");
                        break;
                }
                //} while (true);// while (true) will run forever use a return or break; if not in a switch

            } while (!quit);//!false = true // quit == false

            #region Footer
            Console.WriteLine("All code has finished. Press any key to terminate the program...");
            Console.ReadLine();

            #endregion
        }//main
    }//class
}//name
