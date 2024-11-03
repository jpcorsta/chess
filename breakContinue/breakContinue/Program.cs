using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace breakContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int counter = 0; counter <10; counter++)
            {
                
                if(counter %2 ==0)
                {
                    Console.WriteLine("now comes a odd number");
                    continue;
                }
                Console.WriteLine(counter);
                
            }
        }
    }
}
