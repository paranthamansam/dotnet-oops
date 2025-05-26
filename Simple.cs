//simple class
using System;
namespace SimpleNamespace
{
    public class Simple
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Simple(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}