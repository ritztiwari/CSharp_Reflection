// Write a program to accept a class name as input and display
// its methods, fields, and constructors using Reflection.

using System;
using System.Reflection;

namespace CSharp_Reflection.Reflection.GetInformation
{
    public class GetInfo
    {
        public static void Get()
        {
            Employee employee = new Employee("rishabh");

            Type type = employee.GetType();

            //printing the name of class employee using reflection
            Console.WriteLine(type.Name);

            ConstructorInfo constructor = type.GetConstructor(new Type[] { typeof(string) });

            object emp = constructor.Invoke(new object[] { "haridk" });

            FieldInfo variable = type.GetField("name",BindingFlags.NonPublic | BindingFlags.Instance);

            System.Console.WriteLine(variable.GetValue(employee));

            //accessing its methods like GetAge()
            MethodInfo method = type.GetMethod("GetAge");

            method.Invoke(employee,null);
        }
    }
}