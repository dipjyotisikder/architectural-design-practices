using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.FileFactory
{
    public interface IFileHandlerFactory
    {
        IFileHandler CreateDesiredObject();
    }
}
