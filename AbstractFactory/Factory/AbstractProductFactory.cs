using System;

namespace AbstractFactory.Factory
{
    public abstract class AbstractProductFactory
    {
        public static T CreateFactory<T>()
        {
            return Activator.CreateInstance<T>();
        }
    }
}
