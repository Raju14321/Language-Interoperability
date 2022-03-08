using System;
using System.Collections.Generic;
using System.Text;

namespace Roufgh
{
    // consuming non-chaild class in same project
    class case3
    {
        static void Main()
        {
            Program p = new Program();
            p.Test2_Internal();
            p.Test4_ProtecedInternal();
            p.Test5_Public();
            Console.ReadLine();
        }
    }
}
