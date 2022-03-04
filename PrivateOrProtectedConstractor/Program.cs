using System;
using System.Reflection;

namespace PrivateOrProtectedConstractor
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Usually private constructor can not let use to create any object
            //We can create object forcefully, with Reflection.

            //1. Object from Private Constructor using : Type
            var constructor = typeof(PrivateOrProtectedConstactorClass).GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[0], null);
            var instanceByType = (PrivateOrProtectedConstactorClass)constructor.Invoke(null);

            //2. Object from Private Constructor using : Activator
            var instanceByActivator = (PrivateOrProtectedConstactorClass)Activator.CreateInstance(typeof(PrivateOrProtectedConstactorClass), true);

            //3. Object from public Constructor
            var instanceByPublicConstractor = new PrivateOrProtectedConstactorClass(4);

            instanceByType.DoIt();
            instanceByActivator.DoIt();
            instanceByPublicConstractor.DoIt();
        }


        //YOU CAN NOT(CONDITION APLICABLE) INSTANTIATE ME. (See Main Method)
        public class PrivateOrProtectedConstactorClass
        {
            private readonly int number = 0;

            private PrivateOrProtectedConstactorClass()
            {
            }

            public PrivateOrProtectedConstactorClass(int num)
            {
                number = num;
            }

            public void DoIt()
            {
                Console.Write(number);
            }
        }

    }
}
