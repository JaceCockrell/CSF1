using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block3Labs
{
    internal class TempLab
    {
        static void Main(string[] args)
        {
            //fah = cel * (9.0 / 5.0) + 32
            //cel = (5.0 / 9.0) * (fah - 32)
            Console.WriteLine("Temp Converter 2.0");
            Console.WriteLine("");
            Console.WriteLine("Celsius Temperatue: ");
            double cel = double.Parse(Console.ReadLine());
            double fah = cel * (9.0 / 5.0) + 32; 
            Console.WriteLine($"You have: {fah} degrees in Fahrenheit.");
            Console.WriteLine("Fahrenheit Temperature: ");
            fah = double.Parse(Console.ReadLine());
            cel = (5.0 / 9.0) * (fah - 32);
            Console.WriteLine($"You have: {cel} degrees in Celsius");
            



        }//end main()
    }//end class
}//end name 
