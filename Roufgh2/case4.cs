using System;

namespace Roufgh2
{
    class case4 : Roufgh.Program
    {
        // consuming child class in another project
       static void Main()
       {
            case4 obj = new case4();
            obj.Test3_Protected();
            obj.Test4_ProtecedInternal();
            obj.Test5_Public();
            Console.ReadLine();
       }
    }
}
