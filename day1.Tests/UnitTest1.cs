using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace day1.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FirstValue()
        {
            var mass = new Mass();
            Assert.AreEqual(2, mass.round(12));
        }
        [TestMethod]
        public void AnotherValueThatRounds()
        {
            var mass = new Mass();
            Assert.AreEqual(2, mass.round(14));
        }
        [TestMethod]
        public void AnotherAnswer()
        {
            var mass = new Mass();
            Assert.AreEqual(654, mass.round(1969));
        }
        [TestMethod]
        public void AnswerIsSum()
        {
            var mass = new Mass();
            mass.round(12);
            mass.round(14);
            Assert.AreEqual(658, mass.round(1969));
        }
        [TestMethod]
        public void CalculateMassWithFuel()
        {
            var mass = new Mass();
            Assert.AreEqual(2, mass.round_with_fuel(12));
        }
        [TestMethod]
        public void CalculateMassWithFuelWithFuelAdded()
        {
            var mass = new Mass();
            Assert.AreEqual(966, mass.round_with_fuel(1969));
            Assert.AreEqual(50346, mass.round_with_fuel(100756));
        }
        //[TestMethod]
        //public void TestingMain()
        //{
        //    Mass.Main();
        //}
    }
}
