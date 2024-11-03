
using NewLock;

var example = new Example();

Parallel.For(0, 50, i=> example.Add(i));

Console.WriteLine(example.Sum);