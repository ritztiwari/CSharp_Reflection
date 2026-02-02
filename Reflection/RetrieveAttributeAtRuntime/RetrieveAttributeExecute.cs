// Retrieve Attributes at Runtime: Create a custom attribute [Author("Author Name")].
// Apply it to a class and use Reflection to retrieve and display the attribute value at
// runtime.

using System;
using System.Diagnostics;

namespace CSharp_Reflection.Reflection.RetrieveAttributeAtRuntime
{
    public class RetrieveAttributeExecute
    {
        public static void Execute()
        {
            Type type = typeof(SampleClass);

            // Get the Author attribute applied to the class
            object[] attributes = type.GetCustomAttributes(typeof(AuthorAttribute),false);

            if (attributes.Length > 0)
            {
                AuthorAttribute authorAttr = (AuthorAttribute)attributes[0];
                Console.WriteLine("Author of the class: " + authorAttr.Name);
            }
            else
            {
                Console.WriteLine("No Author attribute found.");
            }
        }
    }
}