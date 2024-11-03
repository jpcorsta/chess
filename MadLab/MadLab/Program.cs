namespace MadLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num = Convert.ToInt32("45");
            //Console.WriteLine(num + 6);

           Console.Write("Enter a number: ");
           double num1 = Convert.ToDouble(Console.ReadLine()); 
           Console.WriteLine("Enter another number: ");
           double num2 = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine(num1 + num2);

            
        }
    }
}