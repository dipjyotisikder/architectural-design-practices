using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class PhotoFileHandler : IFileHandler
    {
        public void download()
        {
            Console.WriteLine("downloaded photo");
        }

        public void upload()
        {
            Console.WriteLine("uploaded photo");
        }
    }
}
