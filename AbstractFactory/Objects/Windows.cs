using System;

namespace AbstractFactory.Objects
{
    public class Windows : IProduct
    {
        public void CreateButton()
        {
            Console.WriteLine("Windows Button created.");
        }

        public void CreateInput()
        {
            Console.WriteLine("Windows input created.");
        }
    }
}
