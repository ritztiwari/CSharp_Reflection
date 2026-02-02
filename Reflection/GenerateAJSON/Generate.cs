// Generate a JSON Representation: Write a program that converts an object to a
// JSON-like string using Reflection by inspecting its fields and values.

using System;
using System.Reflection;

namespace CSharp_Reflection.Reflection.GenerateAJSON
{
    public class Generate
    {
        public static void Execute()
        {
            SampleClass sampleClass = new SampleClass();

            Type type = sampleClass.GetType();

            MethodInfo methodInfo = type.GetMethod("GenerateJson");

            methodInfo.Invoke(sampleClass,null);
        }
    }
}