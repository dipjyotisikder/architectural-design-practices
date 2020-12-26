using Factory.FileFactory;
using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {

            var fileHandler = new FileHandlerFactory("a");
            var creator = fileHandler.Create();

            creator.upload();
            creator.download();
        }
    }
}
