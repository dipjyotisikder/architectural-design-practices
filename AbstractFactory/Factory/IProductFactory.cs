using AbstractFactory.Objects;

namespace AbstractFactory.Factory
{
    public interface IProductFactory
    {
        T Create<T>() where T : IProduct;
    }
}
