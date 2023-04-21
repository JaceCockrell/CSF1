using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block4
{
    internal class ArrayLab
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5];
            Console.WriteLine("Give the first of 5 test scores.");
            scores[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Give the second of 5 test scores.");
            scores[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Give the third of 5 test scores.");
            scores[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Give the fourth of 5 test scores.");
            scores[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("Give the last of 5 test scores.");
            scores[4] = int.Parse(Console.ReadLine());
            Array.Sort(scores);
            Console.WriteLine($"{scores[0]} is the lowest score, {scores[4]} is the highest score.");
            int allScores = scores.Sum();
            allScores = allScores / 5;
            Console.WriteLine($"Your average score was: {allScores}");






        }//main
    }//class
}//name
