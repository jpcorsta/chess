using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes__Basics
{
    //this class is a blueprint for a datatype
    internal class Human
    {
        //member variable
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        //default constructor
        public Human()
        {
            Console.WriteLine("Constructor called. Object created ");
        }

        public Human(string firstName)
        {
            this.firstName = firstName;
            
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            
        }

        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }
        public Human(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        //parameterized constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        //member method
        public void IntroduceMyself()
        {
            if (age != 1 && lastName != null && eyeColor != null && firstName != null)
                Console.WriteLine("Hi, I am {1} {0} and {2} years old, my eyecolor is {3}", firstName, lastName, age, eyeColor);
            else if (age != 1 && lastName != null && firstName != null)
            {
                Console.WriteLine("Hi, I am {1} {0} and {2} years old.", firstName, lastName, age);
            }
            else if (lastName != null && firstName != null)
            {
                Console.WriteLine("Hi, I am {1} {0}.", firstName, lastName);
            }
            else if (firstName != null)
            {
                Console.WriteLine("Hi, I am {0}.", firstName);
            }
        }
    }
}
