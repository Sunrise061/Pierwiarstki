using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pierwiastki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Podaj zmienną A:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj zmienną B:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj zmienną C:");
            c = double.Parse(Console.ReadLine());
            //ax2 + bx + c = 0.
            var delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("Równanie nie ma rozwiązań");
                Console.ReadKey();
            }
            else if (delta == 0)
            {
                var ZERO = -b / (2 * a);
                Console.WriteLine($"Równanie ma jedno rozwiązanie x0={Math.Round(ZERO, 2)}");
            }
            else if (delta > 0) 
            {
                var JEDEN = (-b + Math.Sqrt(delta)) / (2 * a);
                var DWA = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Równanie ma dwa rozwiązania: x1={Math.Round(JEDEN, 2)} x2={Math.Round(DWA, 2)}");             
                Console.ReadKey();
            }






        }
    }
}
