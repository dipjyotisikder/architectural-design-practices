namespace Factory.FileFactory
{
    public interface IFileHandlerFactory
    {
        IFileHandler CreateDesiredObject();
    }
}
