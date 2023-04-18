using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block2
{
    internal class Operators
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mathematical Operaters");
            Console.WriteLine();
            Console.WriteLine("Hello");

            //+, -, *, / (solidus)
            //P(MD)(AS) left to right 
            int newCalc = 5 + 3 * 6 / 2 + 12;//26
            Console.WriteLine(newCalc + " without perens");
            newCalc = (5 + 3) * 6 / 2 + 12;//36
            Console.WriteLine(newCalc + " with perens");

            //Modulus
            // performs division but returns the remainder.
            //15 / 7 = 2 R1
            int legos = 15 + 27;
            //suppose it takes 9 pieces to make a lego car. how many cars can we make?
            int legoCars = legos / 9;
            //4.666666666... => 4 truncation always rounds down
            Console.WriteLine("We can make " + legoCars + " cars.");
            //Modulo is the symbol (%)
            int piecesLeftOver = legos % 9;
            Console.WriteLine("We have " + piecesLeftOver + " pieces left over.");//6
            //Modulus has the same importance/precedence as division/multiplication
            //shift-enter drop down
            //crtl-enter to pop up
            //75 nails
            //30 to make a dresser
            //how many dressers and how many nails left over
            //int nails, dressers, nails left over, required nails
            int nails = 75, dressers, nailsLeftOver, requiredNails = 30;//must have same data type to do multiple
            dressers = nails / requiredNails;
            nailsLeftOver = nails % requiredNails;
            //for both variables we asked the same question (divison) but asked for a different piece of the answer
            Console.WriteLine("We made " + dressers + "dressers and " + "have " + nailsLeftOver + " nails remaining");
            //x = x + 1
            //unary operaters are used to increment or decrement a variable's value.
            int hobbits = 2;
            Console.WriteLine("Hobbits: " + hobbits);
            // to add 1 the long way =
            hobbits = hobbits + 1;
            Console.WriteLine("Hobbits: " + hobbits);
            //shortcut unary opperator
            hobbits++;
            Console.WriteLine("Hobbits: " + hobbits);

            //decrease long way 
            hobbits = hobbits - 1;
            //unary
            hobbits--;
            Console.WriteLine("Hobbits: " + hobbits);
            //variable++/-- -> POST-FIX happens after everything
            //++/--variable -> PRE-FIX happens before everything

            int goblins = 12, orcs = 1;
            int badGuys = goblins + orcs++;//13
            Console.WriteLine("badGuys: " + badGuys);//badGuys was assigned before orcs incremented
            Console.WriteLine("orcs:" + orcs);

            Console.WriteLine();
            int xboxGames = 12, psGames = 1;
            int games = xboxGames + ++psGames;
            Console.WriteLine("games: " + games);//14| psGames was incremented before everything

            int players = 2;
            players = players + 4;
            Console.WriteLine(players);//6
            //Assignment Operator
            //Assignment -> =
            //Opperaor -> + - / * %
            players += 4;//+= can be used with concatention so be carefull
            Console.WriteLine(players);//10
            //Multiply by 3 the long way
            players = players * 3;
            Console.WriteLine(players);//30
            //short way
            players *= 3;
            Console.WriteLine(players);//90

            //divide by 3 the long way
            players = players / 3;
            Console.WriteLine(players);//30
            //short way
            players /= 3;
            Console.WriteLine(players);//10

            //subtract by 8 long way
            players = players - 8;
            Console.WriteLine(players);//2
            //short way
            players -= 8;
            Console.WriteLine(players);//-6

            //modulus by 2 short way 
            players %= 2;//0 no remainder
            Console.WriteLine(players);

            //modulus can tell us whether a given number is a multiple of another number.
            Console.WriteLine(67 % 2);//1 (odd)
            Console.WriteLine(74882 % 2);//0 (even)
            Console.WriteLine(396 / 3);//0 (divisible by 3)

            legos = 589;
            Console.WriteLine("out of " + legos + ", we were able to make:");
            int bigLegos = legos / 100;
            legos %= 100;//42(leftover)
            int medLegos = legos / 50;
            legos %= 50;//42
            int smallLegos = legos / 20;
            legos %= 20;//2
            Console.WriteLine("Big: " + bigLegos);
            Console.WriteLine("Medium: " + medLegos);
            Console.WriteLine("Small: " + smallLegos);
            Console.WriteLine("Remaining: " + legos);






        }//end main()
    }//end class
}//end namespace
