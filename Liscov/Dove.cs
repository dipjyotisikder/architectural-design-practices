using System;

namespace Liscov
{
    public class Dove : IFlyingBird
    {
        public string Name { get; private set; }

        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public virtual void Eat()
        {
            Console.WriteLine($"I am {Name} , I Can eat");
        }

        public virtual void Fly()
        {
            Console.WriteLine($"I am { Name} ,I Can fly");
        }


    }
}
