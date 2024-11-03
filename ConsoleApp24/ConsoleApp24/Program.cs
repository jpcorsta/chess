using System;
using System.IO;//input output namespace that allows to read files for example
using System.Threading.Tasks;//async
using System.Net.Http;
using System.Collections.Generic;

namespace asynchronous_await
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string URL = "https://raw.githubusercontent.com/130xer/Doggo/main/README.md";

            var tasks = new List<Task> { SummonDogLocally, SummonDogFromURL(URL) };
            await Task.WhenAll(tasks);
        }

        static async Task SummonDogLocally()//since this is a asynchronous method we return a task
        {                                   //returning a task is equivalent to a void method
            Console.WriteLine("1. Summoning Dog Locally ...");
            //since we print the content of the dile directly inside the method
            //if we would actually retun the string to the main method then we would return task string

            //read all the text inside the dog.txt async
            string dogText = await File.ReadAllTextAsync("dog.txt");

            //display the data inside the txt file
            Console.WriteLine($"2. Dog Summoned Locally nnnn\n{dogText}");

        }

        //A Task return type will eventually yield a void
        static async Task SummonDogFromURL(string URL)
        {
            Console.WriteLine("1. Summoning Dog from URL ...");

            using (var httpClient = new HttpClient())
            {
                string result = await httpClient.GetStringAsync(URL);

                //From this line and below, the execution will resume once the
                //above awaitable is done
                //using await keyword, it will do the magic of unwrapping
                //the Task<string> into string (result variable)
                Console.WriteLine($"2. Dog Summoned from URL \n{result}");
            }
        }
        static async Task<string> SummonDogLocally()//since this is a asynchronous method we return a task
        {                                   //returning a task is equivalent to a void method
            Console.WriteLine("1. Summoning Dog Locally ...");
            //since we print the content of the dile directly inside the method
            //if we would actually retun the string to the main method then we would return task string

            //read all the text inside the dog.txt async
            string dogText = await File.ReadAllTextAsync("dog.txt");

            //display the data inside the txt file
            Console.WriteLine($"2. Dog Summoned Locally nnn\n{dogText}");

            //so here let's say we were to return to retun this dogtext here
            return dogText;//this won't work because its a void method therefor insert <string> inthe static opeining line

        }
    }
}