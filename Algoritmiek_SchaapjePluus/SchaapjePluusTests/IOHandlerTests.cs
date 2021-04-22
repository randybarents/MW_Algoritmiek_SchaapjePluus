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

            Assert.AreEqual(99, handler.Numbers.Count);
        }
    }
}
