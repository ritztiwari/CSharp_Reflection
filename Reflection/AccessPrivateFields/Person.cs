using System;
using System.ComponentModel.DataAnnotations;

namespace CSharp_Reflection.Reflection.AccessPrivateFields
{
    public class Person
    {
        private string name;
        private int age = 22;

        public Person(string name)
        {
            this.name = name;
        }

        public void Greet()
        {
            Console.WriteLine($"hello {name}");
        }
    }
}