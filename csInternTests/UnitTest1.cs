using Microsoft.VisualStudio.TestTools.UnitTesting;
using csInternTask;

namespace csInternTests
{
    [TestClass]
    public class CalculationTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // one number is not enougth to find two minimal numbers
            int[] numbers = new int[] { 1 };            
            try
            {
                int actual = Program.SumOfTwoMinimalNums(numbers);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, Program.InputArrayIsHugeOrShort);
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }        
        [TestMethod]
        public void TestMethod2()
        {
            int[] numbers = new int[] { 4, 0, 3, 19, 492, -10, 1 };
            int expected = -10;
            int actual = Program.SumOfTwoMinimalNums(numbers);
            Assert.AreEqual(expected, actual, "Wrong calculation");
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[] numbers = new int[] { 492, 5, -70, 10 };
            int expected = -65;
            int actual = Program.SumOfTwoMinimalNums(numbers);
            Assert.AreEqual(expected, actual, "Wrong calculation");
        }        
    }
}