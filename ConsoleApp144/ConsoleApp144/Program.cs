string hello = "hello";
string world = "world";

string a = string.Intern(hello + " " + world);
string b = string.Intern(hello + " " + world);

bool areSame = ReferenceEquals(a, b);

Console.WriteLine(areSame);