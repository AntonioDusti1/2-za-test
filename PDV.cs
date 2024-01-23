using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi cijenu bez PDV: ");
            decimal bezPDV = decimal.Parse(Console.ReadLine());

            Console.Write("Unesi cijenu PDV: ");
            decimal saPDV = decimal.Parse(Console.ReadLine());

            decimal PDV = saPDV  - bezPDV;

            Console.WriteLine("Vrijednost PDV je: " + PDV);
            Console.ReadLine();
        }
    }
}
