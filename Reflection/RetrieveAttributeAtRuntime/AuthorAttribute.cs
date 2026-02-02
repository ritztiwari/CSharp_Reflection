using System;


namespace CSharp_Reflection.Reflection.RetrieveAttributeAtRuntime
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AuthorAttribute : Attribute
    {
        public string Name { get; }

        public AuthorAttribute(string name)
        {
            Name = name;
        }
    }
}
