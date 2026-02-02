using System;
using System.ComponentModel.DataAnnotations;

namespace CSharp_Reflection.Reflection.GetInformation
{
    public class Employee
    {
        private string name;
        private int age =22;

        public Employee(){}
        public Employee(string name)
        {
            this.name = name;
        }

        public void GetAge()
        {
            Console.WriteLine($"age is: {age}");
        }
        }
}