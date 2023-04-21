using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Block4
{
    internal class LoginLab
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Username: ? ");
            string userName = Console.ReadLine().ToLower();

            if (userName == "lenovo")
            {
                Console.WriteLine("Access: Granted");
                Console.WriteLine("Name of of the weeks catch phrases. ");
                string phrase = Console.ReadLine().ToLower();

                switch (phrase)
                {

                    case "mmmm decimal":
                        Console.WriteLine("Hello Jeremy!");
                        break;

                    case "css is the best!":
                        Console.WriteLine("Hello Spencer! ");
                        break;

                    case "i dont know":
                        Console.WriteLine("Welcome Student!");
                        break;


                    case "this is hard":
                        Console.WriteLine("Hello Jace!");
                        break;


                    case "im a pickle":
                        Console.WriteLine("Hello Rick!");
                        break;
                    default:
                        Console.WriteLine("You need to leave IMMEDIATELY\a");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Access: Denied");
            }















        }
    }
}
