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
    }

    public class StringCalculator
    {
        public static int Add(string s)
        {
            return 1;
        }
    }
}
