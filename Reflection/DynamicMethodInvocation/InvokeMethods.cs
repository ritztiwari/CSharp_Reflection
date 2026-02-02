using System;

namespace CSharp_Reflection.Reflection.DynamicMethodInvocation
{
    public class InvokeMethods
    {
        public static void Invoke()
        {
            MathOperations operations = new MathOperations();

            Type type = operations.GetType();

            while (true)
            {
                System.Console.WriteLine("press 1 to call Add Method");
                System.Console.WriteLine("press 2 to call subtract Add Method");
                System.Console.WriteLine("press 3 to call multiply Add Method");
                System.Console.WriteLine("press 4 to exit");
                int.TryParse(Console.ReadLine() ?? "",out int n);

                if(n == 1)
                {
                    System.Console.WriteLine("enter the number 1");
                    int.TryParse(Console.ReadLine() ?? "",out int k);

                    System.Console.WriteLine("enter the number 2");
                    int.TryParse(Console.ReadLine() ?? "",out int l);
                    
                    object[] temp = {k,l};
                    type.GetMethod("Add").Invoke(operations,temp);

                    System.Console.WriteLine("adding operations done");
                }
                else if(n == 2)
                {
                    System.Console.WriteLine("enter the number 1");
                    int.TryParse(Console.ReadLine() ?? "",out int k);

                    System.Console.WriteLine("enter the number 2");
                    int.TryParse(Console.ReadLine() ?? "",out int l);
                    
                    object[] temp = {k,l};
                    type.GetMethod("Subtract").Invoke(operations,temp);

                    System.Console.WriteLine("subtraction operations done");
                }
                else if(n == 3)
                {
                    System.Console.WriteLine("enter the number 1");
                    int.TryParse(Console.ReadLine() ?? "",out int k);

                    System.Console.WriteLine("enter the number 2");
                    int.TryParse(Console.ReadLine() ?? "",out int l);
                    
                    object[] temp = {k,l};
                    type.GetMethod("Multiply").Invoke(operations,temp);

                    System.Console.WriteLine("multiplication operations done");
                }
                else
                {
                    break;
                }
            }
        }
    }
}