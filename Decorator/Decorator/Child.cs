using System;

namespace Decorator
{
    public class Child : IRootDecorator
    {
        public readonly IRoot _root;
        public Child(IRoot root)
        {
            _root = root;
        }


        public void OnCreate()
        {
            _root.OnCreate();
            Console.WriteLine("Created with CHILD");
        }

        public void OnUpdate()
        {
            _root.OnUpdate();
            Console.WriteLine("Updated with CHILD");
        }
    }
}