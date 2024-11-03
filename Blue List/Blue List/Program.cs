namespace Blue_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();

            names.Add("public");
            names.Add("private");
            names.Add("var");
            names.Add("partial");
            names.Add("class");
            names.Add("new");
            names.Add("namespace");
            names.Add("wait");
            names.Add("await");
            names.Add("false");
            names.Add("async");
            names.Add("bool");
            names.Add("using");
            names.Add("void");
            names.Add("internal");
            names.Add("sbyte");
            names.Add("byte");
            names.Add("short");
            names.Add("ushort");
            names.Add("int");
            names.Add("uint");
            names.Add("long");
            names.Add("ulong");
            names.Add("float");
            names.Add("double");
            names.Add("decimal");
            names.Add("char");
            names.Add("string");
            names.Add("sizeof");

            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
    }
}