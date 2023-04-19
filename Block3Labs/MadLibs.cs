using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block3Labs
{
    internal class MadLibs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MadLibs");
            Console.WriteLine("Please answer the following questions to create a story below: ");
            Console.WriteLine("");
            Console.WriteLine("1. Please give me 1 noun: ");
            string noun = Console.ReadLine();
            Console.WriteLine("2. Please give me 1 plural noun: ");
            string nounOne = Console.ReadLine();
            Console.WriteLine("3. Please give me 1 present-tence verb: ");
            string verb = Console.ReadLine();
            Console.WriteLine("4. Please give me 1 present-tence verb: ");
            string verbOne = Console.ReadLine();
            Console.WriteLine("5. Please give me 1 color: ");
            string color = Console.ReadLine();
            Console.WriteLine("6. Please give me 1 adjective: ");
            string adj = Console.ReadLine();
            Console.WriteLine("7. Please give me 1 plural noun: ");
            string nounTwo = Console.ReadLine();
            Console.WriteLine("8. Please give me 1 adjective: ");
            string adjOne = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"Today, every student has a computer small enough to fit into his {noun}. They can solve any math problem by simply pushing the computer's litte {nounOne}. Computers can add, multiply, divide, and {verb}. Computers can also {verbOne} better than any human. Some computers are {color}, others have a/an {adj} screen that shows all kinds of {nounTwo} and {adjOne} figures.");


        }//end main()
    }//end class
}//end name
