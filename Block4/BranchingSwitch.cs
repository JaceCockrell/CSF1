using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block4
{
    internal class BranchingSwitch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Branching with Switch");
            /*
             * Switches are the other form of branching.
             * Not as flexible as IF (don't handle ranges well)
             * But GREAT at exact matching.
             * 
             * SYNTAX:
             * 
             * switch (valueToCheck)
             * {
             *      case TEST:
             *          //code
             *          break;
             *          
             *      default:
             *          //code
             *          break;
             * }
             */
            Console.Write("Enter a numer:");
            short number = Convert.ToInt16(Console.ReadLine());
            switch (number)
            {
                case 1:
                     Console.WriteLine("You typed 1");
                    break;
                case 2: 
                case 3:
                case 4:
                case 5:
                case 42:
                    Console.WriteLine("you typed 2-5 or 42");
                    break;
                    // treats multiple like ||
                default:
                    Console.WriteLine("You picked something else.");
                    break;
                    //optional has no test works like an else
            }//switch
            string response = "";
            switch (number)
            {
                case >= 90:
                    response = "A";
                    break;
                case >= 80:
                    response = "B";
                    break;
                case >= 70:
                    response = "C";
                    break;
                case >= 60:
                    response = "D";
                    break;
                default:
                    response = "F";
                    break;
            }//end switch
            Console.WriteLine(response);


        }//main
    }//class
}//name
