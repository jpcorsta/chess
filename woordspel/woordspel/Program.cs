using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace woordspel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dier, getal, kleur;

            Console.Write("Wat is je favoriete dier? ");
            dier = Console.ReadLine();
            Console.Write("Wat is je favoriete getal? ");
            getal = Console.ReadLine();
            Console.Write("Wat is je favoriete kleur? ");
            kleur = Console.ReadLine();

            Console.Write("Jij bent een " + dier);
            Console.Write(" die " + getal + " poten heeft ");
            Console.Write("en " + kleur + " ziet. ");

        }
    }
}
