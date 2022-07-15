/// <summary>
/// HERE WE ARE CHECKING IF ANY CONSTRACTOR CAN BE CREATED.
/// </summary>

namespace WhatAndWhyPartialClass
{
    public partial class MainClass : BaseClass
    {
        public MainClass()
        {
            BaseProperty = string.Empty;
        }
    }

    public partial class MainClass
    {
        /*YOU CAN NOT CREATE ANOTHER CONSTRACTOR IN ANY SECOND/ANOHER PARTIAL CLASS
        public MainClass()
        {
        }
        */
    }

    public class BaseClass
    {
        public string BaseProperty { get; set; }
    }
}
