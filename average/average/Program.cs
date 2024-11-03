using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace average
{
    internal class Program
    {
                
        static void Main()
            {
                var arr = new double[] { 44, 51, 3 };
                double avg = Queryable.Average(arr.AsQueryable());
                Console.WriteLine($"Average = " + (avg));
            /*Console.WriteLine($"Average{0:d}", avg);
            .ToString("0.0")*/
        }
    }
    }
    
