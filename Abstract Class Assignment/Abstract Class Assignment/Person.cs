using System;

namespace Abstract_Class_Assignment
{
    // Abstract class - Person - with two string properties
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        // Give it the method SayName()
        public abstract void SayName();
    }
}