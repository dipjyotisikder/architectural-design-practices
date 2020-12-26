using Factory.FileFactory;
using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var fileHandler = new FileHandlerFactory("c");
            var data = fileHandler.Create();
        }
    }
}
