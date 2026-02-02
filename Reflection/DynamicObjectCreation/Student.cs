using System;

namespace CSharp_Reflection.Reflection.DynamicObjectCreation
{
    public class Student
    {
        public string Name;
        public int Age;

        public Student()   // Default constructor
        {
            Console.WriteLine("Student object created!");
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}