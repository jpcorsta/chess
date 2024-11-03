using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp68
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            string content = await client.GetStringAsync("http://marktplaats.nl");
            Console.WriteLine(content);
        }
    }
}
