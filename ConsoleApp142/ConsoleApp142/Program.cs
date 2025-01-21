

using System.Diagnostics;
using System.Timers;

List<int> numbers = [1, 2, 3, 4];
List<string> strings = ["tim", "Corey", "Sue"];

List<object> objects = ["Tim", 4, 3.6];

foreach (string item in strings)
	Console.WriteLine(item);

Stopwatch sw = new();
sw.Start();
for (int i = 0; i < 1_000_000; i++)
{
	objects.Add(i);
}
sw.Stop();
Console.WriteLine($"List<objects> elapsed time: {sw.ElapsedMilliseconds}");

sw = new();
sw.Start();
for (int i = 0; i < 1_000_000; i++) 
{ 
	numbers.Add(i);
}
sw.Stop();
Console.WriteLine($"List<numbers> elapsed time: {sw.ElapsedMilliseconds}");

sw = new();
sw.Start();
for (int i = 0; i < 1_000_000; i++) 
{ 
	strings.Add("qq");
}
sw.Stop();
Console.WriteLine($"List<strings> elapsed time: {sw.ElapsedMilliseconds}");



Console.ReadLine();