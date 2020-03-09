using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AntoineCalcApp;


namespace TestAntoineCalc
{
    [TestClass]
    public class AntioneCalcTest_v2
    {
        [TestMethod]
        [DataRow(8.20417, 1642.89, 230.300, 78.32, 770, "Liquid")]
        public void TestLiquidState1(double paraA, double paraB, double paraC, double currTemp, double currPressure, string expectState)
        {
            AntoineCalc Test1 = new AntoineCalc(paraA, paraB, paraC, currTemp, currPressure);

            Test1.CalcPv();
            string actualState = Test1.CalcState();

            Assert.AreEqual(expectState, actualState);
        }

        [TestMethod]
        [DataRow(8.20417, 1642.89, 230.300, 78.32, 760, "Gas")]
        public void TestGasState1(double paraA, double paraB, double paraC, double currTemp, double currPressure, string expectState)
        {
            AntoineCalc Test1 = new AntoineCalc(paraA, paraB, paraC, currTemp, currPressure);

            Test1.CalcPv();
            string actualState = Test1.CalcState();

            Assert.AreEqual(expectState, actualState);
        }
    }
}
