using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class ItalianChef : Chef
    {
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes chicken parm");
        }

        public void MakePasta()
        { 
            Console.WriteLine("The chef makes pasta");
        }
    }
}
