using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.FileFactory
{
    public interface IFileHandlerFactory<T> where T : IFileHandler
    {
        T Create();
    }
}
