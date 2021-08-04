using AbstractFactory.Objects;
using System;

namespace AbstractFactory.Factory
{
    public class AppleFactory : IProductFactory
    {
        public T Create<T>() where T : IProduct
        {
            return Activator.CreateInstance<T>();
        }
    }
}
