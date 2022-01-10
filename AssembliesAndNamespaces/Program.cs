using System;
using System.IO;
namespace AssembliesAndNamespaces
{
    class program
    {
        static void Main(string[] args)
        {
            string text =
            "A class is the most powerful data type in C#. Like a structure, " +
            "a class defines the data and behavior of the data type. ";

            File.WriteAllText("C:/lesson 17/WriteText.txt", text);


            Console.WriteLine("Hello, World!");
            Console.ReadLine();
        }
    }
}
