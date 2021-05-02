using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new Root();

            Console.WriteLine("Printing Previous Data......................");

            root.OnCreate();
            root.OnUpdate();


            Console.WriteLine("Printing Decorated Data.......................");
            //PUSH THE ROOT FIRST
            var child = new Child(root);
            child.OnCreate();
            child.OnUpdate();

        }
    }
}
