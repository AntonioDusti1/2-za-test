using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Upisi rijec: ");
            string input = Console.ReadLine();

            string output = input;

            if (input.Length >= 5)
            {
                output = input.Substring(2, input.Length - 4);
            }

            Console.WriteLine("Modificiraj rijec: " + output);
            Console.ReadLine();
        }
    }
}
