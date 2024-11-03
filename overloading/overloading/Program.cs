using System;

namespace MyFirstProgram
{ 
    class Program
    {
        static void Main(string[] args)
        {
            // overloaded constructors = technique to create multiple constructors,
            //                           with a differrent set of parameters.
            //                           name + parameters = signature

            Pizza pizaa = new Pizza("stuffed crust", "Creme fraiche");


            Console.ReadKey();
        }
    }
    class Pizza
    {
        String bread;
        String sauce;
        String cheese;
        String topping;

        public Pizza(String bread)
        {
            this.bread = bread;
        }
        public Pizza(String bread, String sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
        }
            public Pizza(String bread, String sauce, String cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }  
         public Pizza(String bread, String sauce, String cheese, String topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }
    }
}