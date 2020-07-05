using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_csharp_desktopapp_unittest
{

    public class StaticCallBefore
    {
        public int func1()
        {
            int Result = 0;
            for (int i = 0; i < 5; i++)
            {
                Result += Logic1.StaticFunc1();
            }

            return Result;
        }

    }
}
