using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void AddTest()
        {
            int num1 = 1;
            int num2 = 2;
            int except = 3;
            int real = Program.Add(num1, num2);
            Assert.AreEqual(except, real);
        }
    }
}