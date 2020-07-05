using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UT_sample_csharp_desktopapp_unittest
{
    [TestFixture]
    public class StaticCallTest
    {
        /// <summary>
        /// Logicが呼び出すごとに1からスタートして1ずつ増える値を返してきた場合、結果が15であること
        /// </summary>
        [Test]
        public void StaticCall()
        {
            var factory = new StaticCallFactory();
            var target = factory.CreateInstance();

            var returnValue = 0;
            factory.MockILogic1.Setup(d => d.Func1())
                .Returns(() =>
                {
                    returnValue++;
                    return returnValue;
                });

            var result = target.func1();

            Assert.That(result, Is.EqualTo(1+2+3+4+5));


        }


    }
}
