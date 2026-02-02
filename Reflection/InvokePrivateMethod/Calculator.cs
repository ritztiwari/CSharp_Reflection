using System;
using System.Collections.Concurrent;

namespace CSharp_Reflection.Reflection.InvokePrivateMethod
{
    public class Calculator
    {
        private int a;
        private int b;

        public Calculator()
        {
        }

        public void Multiply(int a,int b)
        {
            System.Console.WriteLine(a*b);
        }
    }
}