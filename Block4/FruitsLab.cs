using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block4
{
    internal class FruitsLab
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fruits lab");
            string[] fruit = new string[5];
            fruit[0] = "Banana";
            fruit[1] = "Grape";
            fruit[2] = "Strawberry";
            fruit[3] = "Raspberry";
            fruit[4] = "Dragon Fruit";
            Console.WriteLine(fruit[0].Substring(0, 1));
            Console.WriteLine(fruit[1].Substring(0, 2));
            Console.WriteLine(fruit[2].Substring(0, 3));
            Console.WriteLine(fruit[3].Substring(0, 1));
            Console.WriteLine(fruit[4].Substring(0, 2));




        }//end main
    }//end class
}//end name
