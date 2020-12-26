using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class XMLFileHandler : IFileHandler
    {
        public void download()
        {
            Console.WriteLine("downloaded xml");
        }

        public void upload()
        {
            Console.WriteLine("uploaded xml");
        }
    }
}
