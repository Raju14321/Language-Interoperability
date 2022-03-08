using System;
using System.Collections.Generic;
using System.Text;

namespace Roufgh
{
    class case2:Program
    {
        // consuming child class in same project
        static void Main()
        {
            case2 obj = new case2();
            obj.Test2_Internal();
            obj.Test3_Protected();
            obj.Test4_ProtecedInternal();
            obj.Test5_Public();
            obj.Test6_PrivateProtected();
            Console.ReadLine();
        }
    }
}
