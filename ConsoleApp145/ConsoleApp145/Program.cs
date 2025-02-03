using System.Drawing;

string s1 = "Hello";
string s2 = "Hello";

Console.WriteLine(s1 == s2);

Point p1 = new(3, 4);
Point p2 = new(3, 4);

Console.WriteLine(p1 == p2);

Console.WriteLine(object.ReferenceEquals(p1, p2));
Console.WriteLine(s1.IndexOf('e'));