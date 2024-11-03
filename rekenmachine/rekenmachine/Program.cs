using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rekenmachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("geef getal 1 in: ");
            float getal1 = Convert.ToInt32(Console.ReadLine());
            //int replaced by float
            Console.Write("geef getal 2 in: ");
            float getal2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Welke bewerking wil je uitvoeren? ");
            string bewerking = Console.ReadLine();


            if (bewerking == "+")
            {
                Console.WriteLine(getal1 + getal2);
            }
            else if (bewerking == "-")
            {
                Console.WriteLine(getal1 - getal2);
            }
            else if (bewerking == "*")
            {
                Console.WriteLine(getal1 * getal2);
            }
            else
            {
                Console.WriteLine(getal1 / getal2);
            }
        }
    }
}
