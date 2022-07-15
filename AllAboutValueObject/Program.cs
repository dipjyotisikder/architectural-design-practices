using System;

namespace AllAboutValueObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    public class ValueObjectClass
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
    }


    public class Age : IEquatable<int>
    {
        public Age()
        {
        }

        public bool Equals(int other)
        {
            throw new NotImplementedException();
        }
    }

}
