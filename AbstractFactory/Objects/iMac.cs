using System;

namespace AbstractFactory.Objects
{
    public class iMac : IProduct
    {
        public void CreateButton()
        {
            Console.WriteLine("iMac Button created.");
        }

        public void CreateInput()
        {
            Console.WriteLine("iMac Input created.");
        }
    }
}
