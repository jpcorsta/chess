using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loops_Buvesa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             for loops gebruiken we wanneer we precies weten hoevaak we door een stukje code willen loopen.

            for(statement 1, statement 2, statement 3)
            {
                codeblock to be executed
            }

            statement 1 wordt 1 keer uitgevoerd voor de rest van deze code.

            statement 2 stelt de voorwaarde voor dit codeblok.

            statement 3 wordt elke keer uitgevoerd totdat we uit deze code loopen
            */

            for (int i = 1; i < 5; i += 2)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i <= 10; i = i + 2)
            {
                Console.WriteLine(i);
            }

            string[] automerken = { "Volvo", "Bmw", "Ford", "Mazda", "Opel" };
            foreach (string merk in automerken) 
            {
                Console.WriteLine(merk);
            }
            Console.ReadLine();
        }
    }
}
