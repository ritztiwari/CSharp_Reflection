// Method Execution Timing: Use Reflection to measure the execution time of methods
// in a given class dynamically.

using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;

namespace CSharp_Reflection.Reflection.MethodExecutionTiming
{
    public class TimeMethodExecution
    {
        public static void Execute()
        {
            Stopwatch timer = Stopwatch.StartNew();
            
            SampleClass sampleClass = new SampleClass();

            Type type = sampleClass.GetType();

            MethodInfo methodInfo = type.GetMethod("Display");

            object[] temp = {};

            methodInfo.Invoke(sampleClass,temp);

            timer.Stop();
            System.Console.WriteLine(timer);

        }
    }
}