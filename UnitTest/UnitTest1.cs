using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Addtest()
        {
            Assert.AreEqual(2, Calculatorlibrary.Class1.add(1, 1));
            Assert.ThrowsException<System.OverflowException>(()=> Calculatorlibrary.Class1.add(1, int.MaxValue));

        }
        [TestMethod]
        public void Subtest()
        {
            Assert.AreEqual(0, Calculatorlibrary.Class1.sub(1, 1));
            Assert.ThrowsException<System.OverflowException>(() => Calculatorlibrary.Class1.sub(int.MinValue,8));

        }
        [TestMethod]
        public void Multest()
        {
            Assert.AreEqual(1, Calculatorlibrary.Class1.mul(1, 1));
            //Assert.ThrowsException<System.OverflowException>(() => Calculatorlibrary.Class1.sub(int.MinValue, 8));

        }
    }
}
