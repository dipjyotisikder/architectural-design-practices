namespace Factory.FileFactory
{
    public class FileHandlerFactory : IFileHandlerFactory
    {
        private readonly string _type = null;
        public FileHandlerFactory(string type)
        {
            _type = type;
        }
        public IFileHandler CreateDesiredObject()
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
