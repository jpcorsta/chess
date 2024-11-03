using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuvesaDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef je naam in ");
            string naam = Console.ReadLine();
            Console.Write("Geef je leeftijd in ");
            string leeftijd = Console.ReadLine();

            Console.WriteLine("Hallo " + naam + ". Jij bent " + leeftijd + " jaar oud");
            Console.WriteLine($"Hallo {naam}. Jij bent {leeftijd} jaar oud.");
        }
    }
}
