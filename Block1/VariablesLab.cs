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
            Console.WriteLine(IS + small + " to " + big);
            string loving = "long:";
            long neg = -9000000000000000000;
            long pos = 9000000000000000000;
            Console.WriteLine(loving + neg + " to " + pos);
            string first = "float:";
            float fOne = 1.1f;
            float fTwo = 2.2f;
            Console.WriteLine(first + fOne);
            Console.WriteLine(first + fTwo);
            string day = "double:";
            double dOne = 10.1;
            double dTwo = 20.2;
            Console.WriteLine(day + dOne);
            Console.WriteLine(day + dTwo);
            string did = "decimal:";
            decimal mOne = 10.10m;
            decimal mTwo = 20.20m;
            Console.WriteLine(did + mOne);
            Console.WriteLine(did + mTwo);
            string lett = "char:";
            char cOne = 'a';
            char cTwo = 'b';
            Console.WriteLine(lett + cOne);
            Console.WriteLine(lett + cTwo);
            string sup = "string:";
            string sOne = "This is a string.";
            string sTwo = "This is also a string.";
            Console.WriteLine(sup + sOne);
            Console.WriteLine(sup + sTwo);
            string boy = "bool:";
            bool bOne = false;
            bool bTwo = true;
            Console.WriteLine(boy + bOne);
            Console.WriteLine(boy + bTwo);




        }
    }
}
