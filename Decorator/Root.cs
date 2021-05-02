using System;

namespace Decorator
{
    public class Root : IRoot
    {
        public void OnCreate()
        {
            Console.WriteLine("Created ROOT");
        }

        public void OnUpdate()
        {
            Console.WriteLine("Updated ROOT");
        }
    }
}