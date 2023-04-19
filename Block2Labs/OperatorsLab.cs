using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Block2Labs
{
    internal class OperatorsLab
    {
        static void Main(string[] args)
        {
            int sides = 75;
            int squarePerm = sides *= 4;
            Console.WriteLine("1. Perimeter of the square. " + squarePerm + " inches");
            int height = 45, depth = 20, length = 65;
            Console.WriteLine("2. Volume of a cuboid " + (height * depth * length)+ " inches");
            int people = 146, vans, peopleLeft;
            vans = people / 9;
            peopleLeft = people % 9;
            Console.WriteLine("3. There were " + vans + " vans" + " and " + peopleLeft + " people left.");
            int gsc = 5;
            Console.WriteLine("4. A girl scout had " + gsc + " boxes of cookies. She sold 2 boxes to her neighbor.");
            gsc = gsc -= 2;
            Console.WriteLine("She now has " + gsc + " boxes left to sell to the next house.");
            int aliens = 5;
            Console.WriteLine(aliens + " aliens came to earth but one went home. There were then four aliens. Two more aliens came to earth which means there were a total of " + (aliens = aliens + 1) + ". Another alien came to earth making the total" + (aliens = aliens + 1) + " Most of the aliens formed pairs and traveled to other planets but there was " + (aliens = aliens - 6) + " alien left alone on earth.");






        }
    }
}
