using System;

namespace Liscov
{
    public class Penguin : IWalkingBird
    {
        public string Name { get; private set; }

        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public void Eat()
        {
            Console.WriteLine($"I am {Name} ,I Can eat like penguin");
        }

        public void Walk()
        {
            Console.WriteLine($"I am {Name} ,I Can walk like penguin");
        }
    }
}
