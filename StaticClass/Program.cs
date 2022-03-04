namespace StaticClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }


    //YOU DO NOT HAVE TO INSTANTIATE 'STATIC CLASS'. AUTO INSTANCE WILL BE CREATED
    public static class StaticClass
    {

        //!!!!!!!!!!!public int NonStatic { get; set; } You can not create like this.
        public static int NonStatic { get; set; } //You create like this.

        public static bool DoIt()
        {
            return true;
        }

        public static void DoIt2()
        {
        }
    }


    // Non static class can hold static and non static members
    public class NonStaticClass
    {
        public int Property1 { get; set; }
        public static int Property2 { get; set; }

        public static void NotMain(string[] args)
        {
        }

        public static void NotMainAgain(string[] args)
        {
        }

    }


}
