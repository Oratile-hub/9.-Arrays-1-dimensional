using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] luckyNumbers = { 1, 2, 5, 9, 7, 8, 10, 11, 12 };

            Console.WriteLine(luckyNumbers.Length);
            Console.WriteLine(luckyNumbers[0]);
            Console.WriteLine("The max is " + luckyNumbers.Max());

            string[] friends = new string[5];
            friends[0] = "Peter";
            friends[1] = "John";
            friends[2] = Console.ReadLine();
            friends[3] = "Tim";

            Console.WriteLine(friends[1]);

            //freeze console
            Console.ReadLine();


        }
    }
}
