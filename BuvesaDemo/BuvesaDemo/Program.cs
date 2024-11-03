using System;
using System.Net.NetworkInformation;

namespace BuvesaDemo
{

    class Program
    {
        static void Main(string[] args)
        {
            string mijnNaam = "Maarten";
            int leeftijd = 50;

            Console.WriteLine("Hallo mijn naam is " + mijnNaam);
            Console.WriteLine("ik ben "+ leeftijd +" jaar oud");
            Console.WriteLine("De naam van mijn neef is ook " + mijnNaam);
            Console.WriteLine("Hij is iets ouder dan "+ leeftijd +" jaar");
        }

    }

}
