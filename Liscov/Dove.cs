using System;
using System.Collections.Generic;
using System.Text;

namespace Liscov
{
    public class Dove : BirdCanFly
    {
        public override void eat()
        {
            Console.WriteLine("I Can eat like dove");
        }

        public override void fly()
        {
            Console.WriteLine("I Can fly like dove");
        }
    }
}
