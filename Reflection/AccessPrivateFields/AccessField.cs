// Create a class Person with a private field age. Use Reflection to
// modify and retrieve its value.

using System;
using System.Net.WebSockets;
using System.Reflection;

namespace CSharp_Reflection.Reflection.AccessPrivateFields
{
    public class AccessField
    {
        public static void Get()
        {
            Person person = new Person("rishabh");

            Type type = person.GetType();

            type.GetField("name", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(person, "hardik");

            FieldInfo info = type.GetField("name",BindingFlags.NonPublic| BindingFlags.Instance);

            System.Console.WriteLine(info.GetValue(person));
        }
    }
}