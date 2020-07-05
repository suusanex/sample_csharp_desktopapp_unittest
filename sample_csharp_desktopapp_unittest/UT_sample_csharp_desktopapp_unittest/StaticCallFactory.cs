using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using sample_csharp_desktopapp_unittest;

namespace UT_sample_csharp_desktopapp_unittest
{
    class StaticCallFactory
    {
        public Mock<ILogic1> MockILogic1 = new Mock<ILogic1>();

        public StaticCallAfter CreateInstance()
        {
            var inst = new StaticCallAfter(MockILogic1.Object);

            return inst;

        }

    }
}
