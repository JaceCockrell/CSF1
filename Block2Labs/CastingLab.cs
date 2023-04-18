using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block2Labs
{
    internal class CastingLab
    {
        static void Main(string[] args)
        {
            byte puddle = 100;

            short pond = 29456;

            int lake = 100000; //one hundred thousand

            long ocean = 5;

            //1. cast the value of lake into ocean and display it
            ocean = lake;
            Console.WriteLine(ocean + " Implicit");

            //2. cast the value of pond into puddle and display it
            puddle = (byte)pond;
            Console.WriteLine(puddle + " Explicit");

            //3. cast the value of pond into ocean and display it
            ocean = pond;
            Console.WriteLine(ocean + " Implicit");

            //4. cast the value of ocean into lake and display it
            lake = (int)ocean;
            Console.WriteLine(lake + " Explicit");

            //5. cast the value of puddle into ocean and display it
            ocean = puddle;
            Console.WriteLine(ocean + " Implicit");

            //for each casting, include a comment categorizing it as:

            //implicit casting

            //explicit casting

            //explicit casting with truncation
        }
    }
}
