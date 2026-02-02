// Define a class Calculator with a private method Multiply(int
// a, int b). Use Reflection to invoke this method and display the result.

using System;
using System.Reflection;

namespace CSharp_Reflection.Reflection.InvokePrivateMethod
{
    public class InvokeMethod
    {
        public static void Execute()
        {
            Calculator calculator = new Calculator();

            Type type = calculator.GetType();

            MethodInfo method = type.GetMethod("Multiply");

            object[] parameter = {10,20};

            method.Invoke(calculator,parameter);
        }
    }
}