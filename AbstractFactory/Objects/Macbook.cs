using System;

namespace AbstractFactory.Objects
{
    public class Macbook : IProduct
    {
        public void CreateButton()
        {
            Console.WriteLine("Macbook Button created.");
        }

        public void CreateInput()
        {
            Console.WriteLine("Macbook input created.");
        }
    }
}
