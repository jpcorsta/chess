using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Methods____methoden
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    HalloZeggen("Sander");
        //    HalloZeggen("Kristof");
        //    HalloZeggen("Ruud");
        //}

        //static void HalloZeggen(string naam)
        //{
        //    Console.WriteLine("Hallo " + naam);
        //}

        static void Main(string[] args)
        {
            Console.WriteLine(Kwadraat(5963));
        }
        static int Kwadraat(int getal)
        {
            int resultaat = getal * getal;
            return resultaat;
        }
    }
}
