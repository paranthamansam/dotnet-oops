//write class Program and call Simple
using System;
using SimpleNamespace;
namespace ProgramNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Simple class
            Simple simpleObject = new Simple("John Doe", 30);
            
            // Call the DisplayInfo method to print the details
            simpleObject.DisplayInfo();
        }
    }
}