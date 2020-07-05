using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_csharp_desktopapp_unittest
{
    class Logic1 : ILogic1
    {
        public static int StaticFunc1()
        {
            return 1;
        }

        public int Func1()
        {
            return StaticFunc1();
        }
    }
}
