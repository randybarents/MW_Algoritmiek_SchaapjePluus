using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Algoritmiek_SchaapjePluus;

namespace SchaapjePluusTests
{
    [TestClass]
    public class IOHandlerTests
    {
        [TestMethod]
        public void TestIOHandlerAddsNumbersFromFileToList()
        {
            IOHandler handler = new IOHandler();

            handler.ReadNumbers();

            Assert.AreEqual(100, handler.Numbers.Count);
        }
    }
}
