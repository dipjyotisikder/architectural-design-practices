using System;
using System.Reflection;

namespace CanNotCreateObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //////HERE IS SOME TECHNIQUES TO CREATE INSTANCE OF PRIVATE CONSTRACTED CLASSES\\\\\\
            //var constructor = typeof(IHoldPrivateOrProtectedConstractor).GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[0], null);
            //var instance = (IHoldPrivateOrProtectedConstractor)constructor.Invoke(null);

            //var instance = (IHoldPrivateOrProtectedConstractor)Activator.CreateInstance(typeof(IHoldPrivateOrProtectedConstractor), true);

            //instance.DoIt();

            //////PUBLIC CONSTRACTOR\\\\\\
            //var instanceOfPublicConstractor = new IHoldPrivateOrProtectedConstractor(4);
            //instanceOfPublicConstractor.DoIt();
        }
    }

    //YOU CAN NOT INSTANTIATE ME BRO.
    //YOU CAN MAKE ME A BASE CLASS ONLY
    public abstract class IAmAbstract
    {
        public abstract bool DoIt();
    }


    //YOU CAN NOT INSTANTIATE ME BRO.
    //YOU CAN USE ME WITH AN AUTO CREATED INSTANCE OF MINE EVERYWHERE.
    public static class IAmStatic
    {
        public static bool DoIt()
        {
            return true;
        }
    }


    //YOU CAN NOT(CONDITION APLICABLE) INSTANTIATE ME. (See Main Method)
    public class IHoldPrivateOrProtectedConstractor
    {
        private readonly int number = 0;

        private IHoldPrivateOrProtectedConstractor()
        {

        }
        public IHoldPrivateOrProtectedConstractor(int num)
        {
            number = num;
        }
        public void DoIt()
        {
            Console.Write(number);
        }
    }


}
