// Dynamically Create Objects: Write a program to create an instance of a Student class
// dynamically using Reflection without using the new keyword.

using System;

namespace CSharp_Reflection.Reflection.DynamicObjectCreation
{
    public class Create
    {
        public static void Instance()
        {
             // Get the type of the class
        Type type = typeof(Student);

        // Create object WITHOUT using 'new'
        object obj = Activator.CreateInstance(type);

        // Cast to Student (optional but useful)
        Student student = (Student)obj;

        // Set values using reflection
        type.GetField("Name").SetValue(student, "Rishabh");
        type.GetField("Age").SetValue(student, 22);

        // Call method using reflection
        type.GetMethod("Display").Invoke(student, null);
        }
    }
}