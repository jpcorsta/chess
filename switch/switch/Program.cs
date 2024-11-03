using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dag = 7;

            switch (dag)
            {
                case 1:
                    Console.WriteLine("Maandag");
                    break;
                case 2:
                    Console.WriteLine("Dinsdag");
                    break;
                case 3:
                    Console.WriteLine("Woensdag");
                    break;
                case 4:
                    Console.WriteLine("Donderdag");
                    break;
                case 5:
                    Console.WriteLine("Vrijdag");
                    break;
                case 6:
                    Console.WriteLine("Zaterdag");
                    break;
                case 7:
                    Console.WriteLine("Zondag");
                    break;
                default:
                    Console.WriteLine("Geef een dag van de week in");
                    break;

            }
        }    
    }
}
