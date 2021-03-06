﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MethodNOD;
using System.Diagnostics;

namespace TestMethodsNOD
{
    [TestClass]
    public class TestNOD
    {
        [TestMethod]
        public void TestMethodEvklidaTwoArgum()
        {
            long time;
            Assert.AreEqual(AlgorithmNOD.MethodEvklida(out time,30,18),6);
            Debug.WriteLine(time);
        }

        [TestMethod]
        public void TestMethodEvklidaThreeArgum()
        {
            long time;
            Assert.AreEqual(AlgorithmNOD.MethodEvklida(out time,30, 18, 3), 3);
            Debug.WriteLine(time);
        }

        [TestMethod]
        public void TestMethodEvklidaParamsArgum()
        {
            long time;
            Assert.AreEqual(AlgorithmNOD.MethodEvklida(out time,30, 18, 6, 3), 3);
            Debug.WriteLine(time);
        }

        [TestMethod]
        public void TestMethodSteinaTwoArgum()
        {
            long time;
            Assert.AreEqual(AlgorithmNOD.MethodSchteina(out time,30, 18), 6);
            Debug.WriteLine(time);
        }

        [TestMethod]
        public void TestMethodSteinaThreeArgum()
        {
            long time;
            Assert.AreEqual(AlgorithmNOD.MethodSchteina(out time,30, 15, 5), 5);
            Debug.WriteLine(time);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestMethodSteinaParamsArgum()
        {
            long time;
            int res=AlgorithmNOD.MethodSchteina(out time);
        }
    }
}
