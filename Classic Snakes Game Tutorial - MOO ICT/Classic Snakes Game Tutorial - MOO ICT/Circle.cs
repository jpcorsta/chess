using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classic_Snakes_Game_Tutorial___MOO_ICT
{
    internal class Circle
    {
        public int X { get; set; }//properties are similar to variables except they give a littlebit more control on how to use them
        public int Y { get; set; }  
        
        public Circle()//constructor always has the smae name as the class
        {
            X = 0;
            Y = 0;
        }
    }
}
