using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block3
{
    internal class StringsRevisited
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strings Revisited!");
            // force something to become a string = ToString() called from the object name
            int number = 42;
            string text = number.ToString();                  // {0}  {1}
            Console.WriteLine("Number is: {0}\nText is: {1}",number, text);


            decimal someDecimal = 124154.2392m;
            // in th console it is useful for the abbillity to pass format specifiers to the ToString() to format the numbers or dates
            Console.WriteLine(someDecimal.ToString("n") + " with n");// (n) means number and defaults 2 decimal places
            Console.WriteLine(someDecimal.ToString("n6") + " with n6");//a number after tells specifically how many numbers to show
            Console.WriteLine(someDecimal.ToString("c") + " with c");//c for currency
            Console.WriteLine(someDecimal.ToString("e") + " with e");//e for exponential

            Console.WriteLine($"{someDecimal:n}");
            //format specifer always : then specifier 
            //Escape sequences
            //special codes used inside of a string that will ignore certain characters.
            //\n new line inside of a string.
            //\" escapes the " and allows it to become a character 
            Console.WriteLine("\"I like turtles,\" Zombie Kid said.");
            // \\ escapes the escape
            Console.WriteLine("C:\\users\\student\\document\\vs22\\projects\\csf1");

            //verbatim character = @
            //similar to escape sequences, but instead it captures all characters litterally
            string greeting = $@"Bob Barker says
""hello"" and that
        file is         at
C:\Barker\Dox{someDecimal}.dox";
            Console.WriteLine(greeting);
            //console.writeline + @" ascii art
            Console.WriteLine(@"___________________________________________________
@@@@@@@@@@@@@@@@@@@@@**^^""""~~~""^@@^*@*@@**@@@@@@@@@
@@@@@@@@@@@@@*^^'""~   , - ' '; ,@@b. '  -e@@@@@@@@@
@@@@@@@@*^""~      . '     . ' ,@@@@(  e@*@@@@@@@@@@
@@@@@^~         .       .   ' @@@@@@, ~^@@@@@@@@@@@
@@@~ ,e**@@*e,  ,e**e, .    ' '@@@@@@e,  ""*@@@@@'^@
@',e@@@@@@@@@@ e@@@@@@       ' '*@@@@@@    @@@'   0
@@@@@@@@@@@@@@@@@@@@@',e,     ;  ~^*^'    ;^~   ' 0
@@@@@@@@@@@@@@@^""""^@@e@@@   .'           ,'   .'  @
@@@@@@@@@@@@@@'    '@@@@@ '         ,  ,e'  .    ;@
@@@@@@@@@@@@@' ,&&,  ^@*'     ,  .  i^""@e, ,e@e  @@
@@@@@@@@@@@@' ,@@@@,          ;  ,& !,,@@@e@@@@ e@@
@@@@@,~*@@*' ,@@@@@@e,   ',   e^~^@,   ~'@@@@@@,@@@
@@@@@@, ~"" ,e@@@@@@@@@*e*@*  ,@e  @@""""@e,,@@@@@@@@@
@@@@@@@@ee@@@@@@@@@@@@@@@"" ,e@' ,e@' e@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@"" ,@"" ,e@@e,,@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@~ ,@@@,,0@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@,,@@@@@@@@@@@@@@@@@@@@@@@@@
""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""
");

        }//end main()
    }//end class
}//end namspace
