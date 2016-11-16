using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringCalculatorKata
{
    [TestClass]
    public class StringCalculatorShould
    {
        [TestMethod]
        public void ReturnOriginalValueWhenSingleNumberIsAdded()
        {
            int result = StringCalculator.Add("1");

            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void ReturnZeroWhenEmptyStringIsAdded()
        {
            int result = StringCalculator.Add("");

            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void ReturnThreeWhenValuesOneAndTwoAreAdded()
        {
            int result = StringCalculator.Add("1,2");

            Assert.AreEqual(result, 3);
        }
    }

    public class StringCalculator
    {
        public static int Add(string s)
        {
            if(string.IsNullOrWhiteSpace(s))
                return 0;

            return s.Split(',').Sum(operand => Int32.Parse(operand));
        }
    }
}
