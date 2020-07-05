using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_csharp_desktopapp_unittest
{
    public interface ILogic1
    {
        int Func1();
    }

    public class StaticCallAfter
    {
        private ILogic1 _logic1;

        public StaticCallAfter(ILogic1 logic1)
        {
            _logic1 = logic1;
        }

        public int func1()
        {
            int Result = 0;
            for (int i = 0; i < 5; i++)
            {
                Result += _logic1.Func1();
            }

            return Result;
        }
    }
}
