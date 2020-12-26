using System;
using System.Collections.Generic;
using System.Text;

namespace Liscov
{
    public interface IBird
    {
        void eat();
    }

    public interface IBirdCanFly : IBird
    {
        void fly();
    }

    public interface IBirdCanWalk : IBird
    {
        void walk();
    }
}
