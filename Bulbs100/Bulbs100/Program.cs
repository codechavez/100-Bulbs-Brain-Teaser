using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulbs100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many people?");
            var people = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many bulbs?");
            var bulb = Convert.ToInt32(Console.ReadLine());

            var bulbs = new bool[bulb];

            for (int p = 1; p <= people; p++)
                for (int l = p; l <= bulb; l++)
                    if (l % p == 0)
                        bulbs[l - 1] = !bulbs[l - 1];

            Console.WriteLine("Bulbs");

            for (int i = 0; i < bulbs.Length; i++)
                if (bulbs[i])
                    Console.Write("O ");
                else
                    Console.Write("- ");

            Console.WriteLine();
            Console.WriteLine($"Total Bulbs ON:{bulbs.Count(x => x == true)}");
            Console.ReadLine();
        }
    }
}
