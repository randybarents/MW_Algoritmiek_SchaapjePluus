using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Algoritmiek_SchaapjePluus;

namespace SchaapjePluusTests
{
    [TestClass]
    public class PluusTests
    {
        [TestMethod]
        public void TestAddNumbersAdds5NumbersWhenAllNumbersAreDifferent()
        {
            Pluus pluus = new Pluus();

            pluus.AddNumber("13480");

            Assert.AreEqual(5, pluus.countedNumbers.Count);
        }

        [TestMethod]
        public void TestAddNumbersAddsNumberOnceIfNumberIsAlreadyPresent()
        {
            Pluus pluus = new Pluus();

            pluus.AddNumber("1334");

            Assert.AreEqual(3, pluus.countedNumbers.Count);
        }

        [TestMethod]
        public void TestAddNumbersSetsCaseOutcomeToInsomniaIfNumberIsOnlyZero()
        {
            Pluus pluus = new Pluus();

            pluus.AddNumber("0");

            Assert.AreEqual("Insomnia", pluus.caseOutcome);
        }

        [TestMethod]
        public void TestAddNumersSetsLastNumberToCaseOutcome()
        {
            Pluus pluus = new Pluus();

            pluus.AddNumber("1");

            Assert.AreEqual("1", pluus.caseOutcome);
        }

        [TestMethod]
        public void TestCompareNumbersReturnsFalseWhenAllNumbersArentPresent()
        {
            Pluus pluus = new Pluus();

            pluus.countedNumbers.Add(3);
            pluus.countedNumbers.Add(7);
            pluus.countedNumbers.Add(9);

            Assert.AreEqual(false, pluus.CompareNumbers());
        }


        [TestMethod]
        public void TestCompareNumbersReturnsTrueWhenAllNumbersArePresent()
        {
            Pluus pluus = new Pluus();
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

            foreach (var item in numbers)
            {
                pluus.countedNumbers.Add(item);
            }

            Assert.AreEqual(true, pluus.CompareNumbers());
        }

        [TestMethod]
        public void TestMultiplyNumberMultipliesNumber()
        {
            Pluus pluus = new Pluus();

            
            Assert.AreEqual(75 , pluus.MultiplyNumber(25, 3));
        }
    }
}
