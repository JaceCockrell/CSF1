using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Using statements in C# define resources from .NET that this file needs to be able to execute.
//In .NET 6 (Core), some using statements are implicit (automatically added by the compiler).
//System.Console.WriteLine () 
//as you need more resources for >NET or other sources, we will add more statements.


namespace Block1
{
    internal class DataTypes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Types: Bob Sure Is Loving");
            //Declaration - Give it a name and a datatype
            byte byteNbr;// poor example of Hungarian/Lezinski case. camelCase but the first word is descriptive of the datatype/ how it will be used
            //Initialization
            byteNbr = 0;
            //(re)Assignment
            byteNbr = 255;


            //declare and initialize
            short shortNbr = 1234;//can use _ for a comma
            int intNbr = 2_123_009_381;
            long longNbr = 3025561610205031313;

            sbyte sbyteNbr;
            ushort ushortNbr;
            uint uintNbr;
            ulong ulongNbr;

            //FLOATING POINT TYPES  
            float fraction1 = 29.3f;// f for float - 32 bits, 45 digits.
            double fraction2 = 12.9;//no suffix - 64 bits, 324 digits.
            decimal fraction3 = 23.14m;//MMM decimal - 128 bits, 29 digits. supports the greatest accuracy, 
            //often used for money or science maybe.
            //1 / 2 = (0.5)
            Console.WriteLine(1.0 / 2);

            bool isTired = true;
            bool drankCoffee = false;
            Console.WriteLine("Human is tired?" + isTired);

            //char, unlike string, uses single ticks instead of quotes. '
            char letter = 'A';
            char izard = '%';

        }//end Main()
    }//end class
}//end namspace
