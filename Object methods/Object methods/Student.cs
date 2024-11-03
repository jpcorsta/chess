﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_methods
{
    internal class Student
    {
        public string Name;
        public string Major;
        public double Gpa;

        public Student(string aName, string aMajor, double aGpa)
        { 
            Name = aName;
            Major = aMajor;
            Gpa = aGpa;
        }
        public bool HasHonors()
        {
            if (Gpa >= 2.5)
            {
                return true;
            }
            return false;
        }

    }
}
