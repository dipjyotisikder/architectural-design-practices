using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.FileFactory
{
    public class FileHandlerFactory : IFileHandlerFactory<IFileHandler>
    {
        private readonly string _type = null;
        public FileHandlerFactory(string type)
        {
            _type = type;
        }
        public IFileHandler Create()
        {
            if (_type == "a")
            {
                return new PhotoFileHandler();
            }
            else if (_type == "b")
            {
                return new PdfFileHandler();
            }
            else if (_type == "c")
            {
                return new XMLFileHandler();
            }
            return new PhotoFileHandler();
        }
    }
}
