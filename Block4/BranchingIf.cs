using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Block4
{
    internal class BranchingIf
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Branching with IF");

            #region If TREE NOTES
            /*If statment allows you to test for a condition. If that statement os true,, it runs the code inside the scope
             * otherwise the scope is skipped.
             * if (condition)
             * {
             *      //code if condition is true
             * }
             * else if (another condition) //optional
             * }
             * {
             *      //alternitive code
             * }     
             *
            */
            #endregion
            Console.Write("What day is it? Monday, Tuesday, ect. ");
            string strDay = Console.ReadLine().ToLower();

            if ( strDay == "thursday" )
            {
                //This code will only run if the above is true
                Console.WriteLine("I never could get the hang of Thursdays...");

            }//end if
            else 
            {
                //if they type anything other than thursday
                Console.WriteLine("It's definitly a Thursday, liar!");
            }//end else
            Console.WriteLine("\nMoving Along\n");

            //full if tree
            int monsterStrength = 100;
            Console.WriteLine("IN this cave you see bones and a white rabbit. \n" + "Enter your strengh: ");
            int heroStrength = int.Parse(Console.ReadLine());
            string response = "";//empty string
            if (heroStrength > monsterStrength)//101+
            {
                response = "You use the Holy Hand Grenade of Antioch " + "and blow the rabbit to tiny bits.";

            }//end if 101+
            else if (heroStrength == monsterStrength)
            {
                response = "Alright then, we'll call it a draw.";
            }//end else if tie
            else if (heroStrength >= monsterStrength * .75)
            {
                response = "You die a valient death, but put up a great fight.";
            }//end else if 75%
            else if (heroStrength > 0)
            {
                response = "You join the pile of bones!";
            }//end else > 0
            else if (heroStrength > 20)
            {
                Console.WriteLine("This line will never run");
            }//end else if > 20 
            else //no condition 
            {
                //this will run if they enter something less than 0
                Console.WriteLine("Dude, you're already dead...");
            }//end else

            Console.WriteLine(response);
            bool runMe = true;
            if ( runMe )
            {
                Console.WriteLine("\nProgram Running...\n");
            }//end run me true
            runMe = false;
            if (!runMe)
            {
                Console.WriteLine("\nProgram Terminated....\n");
            }//end run me false

            //capture user input to determine if the user should have access to some functionallity
            bool isAdmin = false;
            Console.Write("Username: ");
            string username = Console.ReadLine();
            if (username.ToLower() == "jace")
            {
                isAdmin = true;
            }
            //bool isAdmin = username.ToLower() == "jace";
            if (isAdmin)
            {
                Console.WriteLine("Your an Admin!");
            }
            else 
            {
                Console.WriteLine("Youre a pleb!");
             }


            if (heroStrength > monsterStrength)
            {
                Console.WriteLine("That's a lot of damage.");
                if (heroStrength > monsterStrength * 1.5)
                {
                    Console.WriteLine("You must be a hacker\a");//plays a window error alert
                }//inner if
            }//outter if
            //MINI LAB            //Ask the user for the score on their last Klingon exam.            //Tell them the letter grade. 90+ A, 80-89 B, 70-79 C, 60-69 D, anything less is an F.
            Console.WriteLine("What score did you have on your last Kingon exam? ");
            int grade = int.Parse(Console.ReadLine());
            if (grade >= 90)
            {
                Console.WriteLine(" Congradulations! You got an A! ");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("You got a B!");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("you got a C!");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("You got a D!");
            }
            else
            {
                Console.WriteLine("You got a f");
            }

        }//end main
    }//end class
}//end name
