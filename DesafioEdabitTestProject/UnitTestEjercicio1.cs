using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesafioEdabit;

namespace DesafioEdabitTestProject
{
    [TestClass]
    public class UnitTestEjercicio1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(DesafiosEdabit.ReturnTrue());
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(DesafiosEdabit.LessThanOrEqualToZero(0));
            Assert.IsFalse(DesafiosEdabit.LessThanOrEqualToZero(5));
            Assert.IsTrue(DesafiosEdabit.LessThanOrEqualToZero(-5));
        }
    }
}
