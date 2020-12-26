using System;
using System.Collections.Generic;
using System.Text;

namespace Liscov
{
    public class Penguin : BirdCanWalk
    {
        public override void eat()
        {
            Console.WriteLine("I Can eat like penguin");
        }

        public override void walk()
        {
            Console.WriteLine("I Can walk like penguin");
        }
    }
}
