// Dynamic Method Invocation: Define a class MathOperations with multiple public
// methods (Add, Subtract, Multiply). Use Reflection to dynamically call any method
// based on user input.

using System;

namespace CSharp_Reflection.Reflection.DynamicMethodInvocation
{
    public class MathOperations
    {
        //fields
        private int a;
        private int b;

        //default constructor
        public MathOperations() { }

        //methods to invoke.
        public void Add(int a, int b)
        {
            System.Console.WriteLine($"addition result {a + b}");
        }
        public void Subtract(int a, int b)
        {
            System.Console.WriteLine($"subtraction result {a - b}");
        }
        public void Multiply(int a, int b)
        {
            System.Console.WriteLine($"multiplication result {a * b}");
        }
    }
}