using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MethodNOD;

namespace TestMethodsNOD
{
    [TestClass]
    public class TestNOD
    {
        [TestMethod]
        public void TestMethodEvklidaTwoArgum()
        {
            TimeSpan timer;
            Assert.AreEqual(AlgorithmNOD.MethodEvklida(30,18,out timer),6);
        }

        [TestMethod]
        public void TestMethodEvklidaThreeArgum()
        {
            TimeSpan time;
            Assert.AreEqual(AlgorithmNOD.MethodEvklidaThreeArgum(30, 18, 3, out time), 3);
        }

        [TestMethod]
        public void TestMethodEvklidaParamsArgum()
        {
            TimeSpan time;
            Assert.AreEqual(AlgorithmNOD.MethodEvklidaParamsArgum(out time,30, 18, 6, 3), 3);
        }

        [TestMethod]
        public void TestMethodSteinaTwoArgum()
        {
            TimeSpan time;
            Assert.AreEqual(AlgorithmNOD.MethodSchteina(30, 18, out time), 6);
        }

        [TestMethod]
        public void TestMethodSteinaThreeArgum()
        {
            TimeSpan time;
            Assert.AreEqual(AlgorithmNOD.MethodSchteinaThreeArgum(30, 15,5, out time), 5);
        }

        [TestMethod]
        public void TestMethodSteinaParamsArgum()
        {
            TimeSpan time;
            Assert.AreEqual(AlgorithmNOD.MethodSchteinaParamsArgum(out time,30,18,9,6,3), 3);
        }
    }
}
