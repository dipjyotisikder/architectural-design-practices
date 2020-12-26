using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class PdfFileHandler : IFileHandler
    {
        public void download()
        {
            Console.WriteLine("downloaded pdf");
        }

        public void upload()
        {
            Console.WriteLine("uploaded pdf");

        }
    }
}
