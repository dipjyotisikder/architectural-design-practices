using System;

namespace Sealed
{
    class Program
    {
        static void Main(string[] args)
        {
            //RESULT IS :
            //IAmSealed CLASS CAN NOT BE INHERITED BY ANY CLASS EVER
            //BUT IAmSealed CLASS CAN BE INSTANTIATED
        }
    }


    public sealed class IAmSealed
    {
        public IAmSealed()
        {
        }
    }

    public class ICanNotInheritSealed //: IAmSealed 
    {

    }

}
