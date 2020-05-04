using Microsoft.VisualStudio.TestTools.UnitTesting;
using NPWFH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPWFH.Tests
{
    [TestClass()]
    public class MessageTests
    {
        [TestMethod()]
        public void HelloTest()
        {
            Message message = new Message();
            var result = (message.Hello() == "Hello World!")? true: false;

            Assert.IsTrue(result);

        }

        [TestMethod()]
        public void HiTest()
        {

        }
    }
}