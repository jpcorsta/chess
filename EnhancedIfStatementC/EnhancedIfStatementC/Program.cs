using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnhancedIfStatementC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //condition ? first_expression : second_expression;
            //condition has to be true or false;
            //the conditional operator is right - associative;
            //the expression a ? b: c? d : e;
            //is evaluated as a ? b : (c ? d : e),
            //not as (a? b : c) ? d: e
            //the conditional operator cannot be overloaded.



            // in celsius
            int temperature = -5;
            string stateOfMatter;

            
            if (temperature < 0) 
               stateOfMatter = "solid";

            else if (temperature > 100)
                stateOfMatter = "gas";
            else
                stateOfMatter = "Liquid";

            Console.WriteLine("State of matter is: {0}", stateOfMatter);

            temperature += 20;


            // in short:
            temperature += 100;
            stateOfMatter = temperature < 0 ? "solid" : temperature > 100 ? "gas" : "liquid";
            Console.WriteLine("State of matter is: {0}", stateOfMatter);
            Console.WriteLine(temperature);

            Console.ReadKey();

        }
    }
}
