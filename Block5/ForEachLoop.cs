using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block5
{
    internal class ForEachLoop
    {
        static void Main(string[] args)
        {

            string[] fruits = { "Banana", "Grape", "Strawberry", "Raspberry", "Dragon Fruit" };
            Console.WriteLine("Looping with Foreach");
            Console.Title = "Looping with Foreach";

            /* FOREACH is a specialized loop made for collections.
             * It provides READONLY access
             * You can see the values in the collection, but you
             * can NOT change them in a foreach.
             * 
             * foreach (DATATYPE MADEUPNAME in COLLECTION)
             * {
             *      //code to run with MADEUPNAME
             * }
             * 
             * This is the easiest, least error-prone loop. 
             * It is preferred in many program contexts,
             * but we lose some flexibility with it.
             * 
             * The foreach-loop is versatile.
             * We will end up using them in strings,
             * string arrays, and even DataTables.
             */

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }//foreach
            //string is a collection of chars
            string letters = "abcdefghijklmnopqrstuvwxyz";
            foreach (char letter in letters)
            { Console.WriteLine(letter);
            }
        }//main
    }//class
}//name
