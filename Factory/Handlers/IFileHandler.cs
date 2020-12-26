using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public interface IFileHandler
    {
        void upload();
        void download();
    }
}
