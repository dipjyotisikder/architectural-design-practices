using System;
using System.Collections.Generic;
using System.Text;

namespace Liscov
{
    public class Bird : IBird
    {
        public virtual void eat()
        {
            Console.WriteLine("I Can eat");
        }
    }

    public class BirdCanFly : IBirdCanFly
    {
        public virtual void eat()
        {
            Console.WriteLine("I Can eat");
        }

        public virtual void fly()
        {
            Console.WriteLine("I Can fly");
        }
    }

    public class BirdCanWalk : IBirdCanWalk
    {
        public virtual void eat()
        {
            Console.WriteLine("I Can eat");
        }

        public virtual void walk()
        {
            Console.WriteLine("I Can walk");
        }
    }
}
