// Access and Modify Static Fields: Create a Configuration class with a private static
// field API_KEY. Use Reflection to modify its value and print it.

using System;
using System.Reflection;

namespace CSharp_Reflection.Reflection.UpdateApiKey
{
    public class Update
    {
        public static void Execute()
        {
            // Before modification
            Configuration.PrintKey();

            // Get type information
            Type type = typeof(Configuration);

            // Get the private static field
            FieldInfo field = type.GetField("API_KEY",BindingFlags.NonPublic | BindingFlags.Static);

            // Modify its value (null because it's static)
            field.SetValue(null, "UPDATED_SECRET_KEY");

            // After modification
            Configuration.PrintKey();
        }
    }
}
