﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unitconsoletest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("hello world", "hello world");
        }
    }
}
