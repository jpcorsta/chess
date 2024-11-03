using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            chef.MakeSpecialDish();

            ItalianChef Italianchef = new ItalianChef();
            Italianchef.MakeSpecialDish();

            Console.ReadLine();
        }
    }
}
