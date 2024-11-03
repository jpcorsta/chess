using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    internal class Box
    {
        // member variables
        private int length;
        private int heigth;
        //public int width;
        private int volume;

        public int Width { get; set; }

        public int Volume
        {
            get
            {   
                return this.length * this.heigth * this.Width; 
            }
        }

        /*
        public int Width
        {
            get
            {
                return this.width;
            }
            set
            { 
                this.width = value;
            }
        }
        */

        //propertie
        public int Heigth
        {
            get 
            { 
                return heigth; 
            }
            set
            {
                if (value < 0)
                {
                    heigth = -value;
                }
                else
                {
                    heigth = value;
                }
            }
        }

        public Box(int length, int heigth, int width)
        {
            this.length = length;
            this.Heigth = heigth;
            Width = width;
        }

        public void SetLength(int length)
        {
            if (length < 0)
            {
                throw new Exception("Length should be higher than 0");
            }
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }

        
             public void displayInfo()
        {
            Console.WriteLine("length is {0} and heigth is {1} and width is {2} so the volume is {3}",
                 length, heigth, Width, volume = length * heigth * Width);
        }


    }
}
