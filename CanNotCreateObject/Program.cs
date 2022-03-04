using System;
using System.Reflection;

namespace CanNotCreateObject
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    //YOU CAN NOT INSTANTIATE 'ABSTRACT CLASS' BRO.
    //YOU CAN MAKE ABSTRACT CLASS AS A BASE CLASS ONLY
    public abstract class IAmAbstract
    {
        public abstract bool DoIt();
    }




}
