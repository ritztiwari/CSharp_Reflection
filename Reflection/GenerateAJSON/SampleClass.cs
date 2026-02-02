using System;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace CSharp_Reflection.Reflection.GenerateAJSON
{
    public class SampleClass
    {
        public string Name{get; set;}
        public int Age{get; set;}

        public SampleClass(){}

        public void GenerateJson()
        {
            SampleClass sampleClass = new SampleClass
            {
                Name = "rishabh",
                Age = 22
            };

            string jsonString = JsonSerializer.Serialize(sampleClass,new JsonSerializerOptions{
                WriteIndented = true 
            }); 

            System.Console.WriteLine(jsonString);
        }
    }
}