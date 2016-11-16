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
}
