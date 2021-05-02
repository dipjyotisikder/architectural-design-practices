using Factory.FileFactory;
using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plese enter a value: ");
            Console.WriteLine("Photo: 'a' ");
            Console.WriteLine("PDF: 'b' ");
            Console.WriteLine("XML: 'c' ");

            var value = Console.ReadLine();

            var fileHandler = new FileHandlerFactory(value);
            var creator = fileHandler.CreateDesiredObject();

            creator.upload();
            creator.download();
        }
    }
}
