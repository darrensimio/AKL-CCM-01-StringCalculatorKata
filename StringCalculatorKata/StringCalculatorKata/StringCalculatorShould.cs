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

        [TestMethod]
        public void ThrowExceptionWithOffendingOperandInMessageWhenNegativeValueExistInOperands()
        {
            try
            {
                StringCalculator.Add("-1,2");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "negatives not allowed (-1)");
            }
        }

        [TestMethod]
        public void ThrowExceptionWithOffendingOperandsInMessageWhenNegativeValueExistInOperands()
        {
            try
            {
                StringCalculator.Add("-1,2,-3,4");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "negatives not allowed (-1,-3)");
            }
        }
    }

    public class StringCalculator
    {
        public static int Add(string s)
        {
            if(string.IsNullOrWhiteSpace(s))
                return 0;

            char[] delimiters = {',', '\n'};

            if (s.StartsWith("//"))
            {
                string[] commands = s.Split('\n');

                delimiters = new [] { commands[0][2] };
                s = commands[1];
            }

            HandleNegativeOperands(s, delimiters);

            return s.Split(delimiters).Sum(int.Parse);
        }

        private static void HandleNegativeOperands(string s, char[] delimiters)
        {
            if (s.Contains('-'))
            {
                string[] offendingOperands = s.Split(delimiters).Where(operands => operands.Contains("-")).ToArray();
                string exceptionMessage = "negatives not allowed ({0})";

                throw new Exception(string.Format(exceptionMessage, string.Join(",", offendingOperands)));
            }
        }
    }
}
