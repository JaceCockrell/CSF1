using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block1
{
    internal class VariablesLab
    {
        static void Main(string[] args)
        {
            string bob = "byte:";
            byte minValue = 1;
            byte maxValue = 255;
            Console.WriteLine(bob + minValue);
            Console.WriteLine(bob + maxValue);
            short min = -32_000;
            short max = 32_000;
            string sure = "short:";
            Console.WriteLine(sure + min);
            Console.WriteLine(sure + max);
            string IS = "int:";
            int small = -2_000_000_000;
            int big = 2_000_000_000;
            Console.WriteLine(IS + small + big);
            string loving = "long:";
            long neg = -9000000000000000000;
            long pos = 9000000000000000000;
            Console.WriteLine(loving + neg + pos);



        }
    }
}
