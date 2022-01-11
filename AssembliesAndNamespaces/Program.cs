using System;
using System.IO;
namespace AssembliesAndNamespaces
{
    class program
    {
        static void Main(string[] args)
        {
            string text = "We want to write this to our file.";
            
            File.WriteAllText(@"C:/lesson 17/WriteText.txt", text);


            Console.WriteLine("Hello, World!");
            Console.ReadLine();
        }
    }
}
