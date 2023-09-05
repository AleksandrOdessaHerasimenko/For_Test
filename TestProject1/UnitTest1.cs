using For_Test;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           Calculator calculator = new Calculator();
            Assert.IsNotNull(calculator, "Calculator is created");
            Assert.IsTrue( 2 == calculator.Devision(10, 5), "10/5=2");
            Assert.IsTrue(-1 == calculator.Devision(10, 0), "10/0=-1(Error)");
            Assert.IsTrue(3 == calculator.Devision(10, 3), "10/3=3");
            Assert.IsTrue(-3 == calculator.Devision(-9, 3), "-9/3=-3");
            Assert.IsTrue(3 == calculator.Devision(-9, -3), "-9/-3=-3");
            Assert.IsTrue(int.MaxValue == calculator.Devision(int.MaxValue, 1), "10/0=-1(Error)");
        }
    }
}