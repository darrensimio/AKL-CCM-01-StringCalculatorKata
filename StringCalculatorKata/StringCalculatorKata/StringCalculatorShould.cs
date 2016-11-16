using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringCalculatorKata
{
    [TestClass]
    public class StringCalculatorShould
    {
        [TestMethod]
        public void VerifyAddMethod()
        {
            int result = StringCalculator.Add("1");
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
