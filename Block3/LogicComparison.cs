using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block3
{
    internal class LogicComparison
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logical and Comparison Operators");

            //Comparison Operators:
            //"relational" and "Equality" operators
            //returns a boolean value comparing 2 different values.
            //greater than >
            //less than <
            // "or equal to" <=
            int max = 20, mid = 12, min = 2;

            bool isMaxHigher = max > mid;
            Console.WriteLine(isMaxHigher);
            Console.WriteLine(mid > max);
            Console.WriteLine(min <= max);

            // a single = is assignment to test equality we use 2 = (Really equals)
            Console.WriteLine(mid == max);
            // for nor equal, we use != an ! in C# gernerally means "not"
            Console.WriteLine(mid != max);
            Console.WriteLine(mid >= 0);
            Console.WriteLine(!(mid < 0));
            bool isActive = true;
            Console.WriteLine(isActive == true);
            Console.WriteLine(isActive);
            Console.WriteLine(isActive == false);
            Console.WriteLine(!isActive);//anywhere isActive == false

            //logical operators
            // "and" returns true if both expressions resolve to true. &&. and also
            // "or" returns true if one or both expressions resolve to true. || or else

            Console.WriteLine();
            Console.WriteLine(true && true);//true
            Console.WriteLine(true && false);//false
            Console.WriteLine(false && true);//false
            Console.WriteLine(false && false);//false

            Console.WriteLine(true || true);//true
            Console.WriteLine(true || false);//true
            Console.WriteLine(false || true);//true
            Console.WriteLine(false || false);//false

            //comparing strings
            string b1 = "batman";
            string b2 = "BATMAN";
            Console.WriteLine("is b1 equal to b2? " + (b1 == b2));
            //var == "BATMAN" || VAR == "batman" || var == bAtMan
            Console.WriteLine("case INSENSITVE, is b1 equal to b2? " + (b1.ToUpper() == b2));
                              // false   || false
            //.ToLower()     //false     || (ture      &&  false) 
            Console.WriteLine('a' == 'b' || max > min && mid < min);//false

            //!(true) -> false. flips it



        }//end main()
    }//end class
}//end name
