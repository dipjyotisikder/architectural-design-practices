using AbstractFactory.Factory;
using AbstractFactory.Objects;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var appleFactory = AbstractProductFactory.CreateFactory<AppleFactory>();
            var imac = appleFactory.Create<iMac>();

            imac.CreateButton();
            imac.CreateInput();

            var windowsFactory = AbstractProductFactory.CreateFactory<WindowsFactory>();
            var win = windowsFactory.Create<Windows>();

            win.CreateButton();
            win.CreateInput();

            var macbook = appleFactory.Create<Macbook>();
            macbook.CreateButton();
            macbook.CreateInput();


            Console.ReadLine();
        }
    }
}
