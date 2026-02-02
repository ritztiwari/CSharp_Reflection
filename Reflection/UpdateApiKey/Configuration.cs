using System;

namespace CSharp_Reflection.Reflection.UpdateApiKey
{
    class Configuration
    {
        private static string API_KEY = "ORIGINAL_KEY";

        public static void PrintKey()
        {
            Console.WriteLine("API Key: " + API_KEY);
        }
    }
}