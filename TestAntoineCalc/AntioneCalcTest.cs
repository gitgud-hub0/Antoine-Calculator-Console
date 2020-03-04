using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AntoineCalcApp;


namespace TestAntoineCalc
{
    [TestClass]
    public class AntioneCalcTest
    {
        [TestMethod]
        public void TestLiquidState1()
        {
            double paraA = 8.20417;
            double paraB = 1642.89;
            double paraC = 230.300;
            double currTemp = 78.32;
            double currPressure = 770;
            string expectState = "Liquid";

            AntoineCalcApp.AntoineCalc Test1 = new AntoineCalc(paraA, paraB, paraC, currTemp, currPressure);

            Test1.CalcPv();
            string actualState = Test1.CalcState();

            Assert.AreEqual(expectState, actualState);
        }

        [TestMethod]
        public void TestGasState1()
        {
            double paraA = 8.20417;
            double paraB = 1642.89;
            double paraC = 230.300;
            double currTemp = 78.32;
            double currPressure = 760;
            string expectState = "Gas";

            AntoineCalcApp.AntoineCalc Test1 = new AntoineCalc(paraA, paraB, paraC, currTemp, currPressure);

            Test1.CalcPv();
            string actualState = Test1.CalcState();

            Assert.AreEqual(expectState, actualState);
        }
    }
}
