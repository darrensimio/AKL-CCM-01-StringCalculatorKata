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

        [TestMethod]
        public void ReturnTenWhenValuesOneAndTwoAndThreeAndFourAreAdded()
        {
            int result = StringCalculator.Add("1,2,3,4");

            Assert.AreEqual(result, 10);
        }

        [TestMethod]
        public void ReturnSixWhenValuesOneAndTwoAndThreeAreAddedWithBothNewLineAndCommarAsSeperators()
        {
            int result = StringCalculator.Add("1\n2,3");

            Assert.AreEqual(result, 6);
        }

        [TestMethod]
        public void ReturnThreeWhenCustomDelimitersAreUsedBetweenValuesOneAndTwo()
        {
            int result = StringCalculator.Add("//;\n1;2");

            Assert.AreEqual(result, 3);
        }
    }

    public class StringCalculator
    {
        public static int Add(string s)
        {
            if(string.IsNullOrWhiteSpace(s))
                return 0;

            return s.Split(',', '\n').Sum(int.Parse);
        }
    }
}
