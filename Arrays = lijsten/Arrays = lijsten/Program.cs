using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays___lijsten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] auto = { "volvo", "bmw", "ford", "mazda", "opel" };
            //auto[2] = "opel";
            Array.Sort(auto);
            foreach (string i in auto)
            {
                Console.WriteLine(i);
            }

            int[] mijnGeluksgetallen ={2, 9, 11, 5};
            Array.Sort(mijnGeluksgetallen);
            foreach(int i in mijnGeluksgetallen)
            { 
                Console.WriteLine(i); 
            }




        }
    }
}
