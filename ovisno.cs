using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provjera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;
            int z = 5;

            if (x > 0 && y > 0 && z > 0)
            {
                if (x * x + y * y == z * z || x * x + z * z == y * y || y * y + z * z == x * x)
                {
                    Console.WriteLine("Vrijednost iz varijable.");
                }
                else
                {
                    Console.WriteLine("Vriednost nije iz varijable .");
                }
            }
            else
            {
                Console.WriteLine("Nemože se unesti u varijablu.");
            }
            Console.ReadLine();
        }
    }
}
