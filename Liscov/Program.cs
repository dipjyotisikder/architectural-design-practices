using System;

namespace Liscov
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();

            Dove doveObject = new Dove();
            doveObject.SetName(name);
            doveObject.Eat();
            doveObject.Fly();

            Penguin penguinObject = new Penguin();
            penguinObject.SetName(name);
            penguinObject.Eat();
            penguinObject.Walk();
        }
    }
}
