using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi broj: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 4 == 0 && number % 6 == 0)
            {
                Console.WriteLine("Broj je 4 i 6");
            }
            else if (number % 4 == 0)
            {
                Console.WriteLine("Broj je  4");
            }
            else if (number % 6 == 0)
            {
                Console.WriteLine("Broj je  6");
            }
            else
            {
                Console.WriteLine("Broj nije visibilan 4 ili 6");

            }
            Console.ReadLine();
        }
    }
}
