/// <summary>
/// HERE WE ARE CHECKING HOW IT BEHAVES WITH INHERITANCE
/// </summary>

namespace WhatAndWhyPartialClass
{
    public partial class Main2Class : SomeBaseClass
    {
    }

    public partial class Main2Class : SomeBaseClass
    {
    }

    /// <summary>
    /// CAN NOT INHERIT WITH DIFFERENT TYPE OF PARENT, ONCE INHERITED
    /// </summary>
    public partial class Main2Class //: SomeAnotherBaseClass
    {
    }

    /*    
        EVEN OBJECT ALSO NOT ALLOWED ALL THOUGH IT IS THE ULTIMATE BASE CLASS OF ALL THE CLASSES IN C#
        */
    public partial class Main2Class //: object
    {
    }


    public class SomeBaseClass
    {
        public string BaseProperty { get; set; }
    }

    public class SomeAnotherBaseClass
    {
        public string BaseProperty { get; set; }
    }
}
