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
    }

    public class StringCalculator
    {
        public static int Add(string s)
        {
            throw new System.NotImplementedException();
        }
    }
}
