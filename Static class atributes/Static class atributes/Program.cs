using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_class_atributes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Song holiday = new Song("Holiday", "Greenday", 200);
            Console.WriteLine(Song.songCount);
            Song kashmir = new Song("kashmir", "Led zeppelin", 150);
            Console.WriteLine(kashmir.GetSongCount());
            
            Console.ReadLine();
        }
    }
}
