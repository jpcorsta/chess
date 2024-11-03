using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    class Program
    {

        static void Main(string[] args)
        { 
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            Book book2 = new Book("Lord of the rings", "Tolkien", 600);
            Book book3 = new Book();  

            book2.title = "The hobbit";

            Console.WriteLine(book2.title);
            
            Console.ReadLine();
        }
    }

}
