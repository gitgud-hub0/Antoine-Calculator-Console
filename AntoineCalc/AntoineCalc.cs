using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AntoineCalc
{
    class AntoineCalc
    {
        double paraA = 8.20417;
        double paraB = 1642.89;
        double paraC = 230.300;
        double currTemp = 78.32;
        double currPressure = 770;
        double vapPressure;

        public AntoineCalc(double paraA, double paraB, double paraC, double currTemp, double currPressure)
        {
            this.paraA = paraA;
            this.paraB = paraB;
            this.paraC = paraC;
            this.currTemp = currTemp;
            this.currPressure = currPressure;
        }

        public string CalcState()
        {
            vapPressure = Math.Pow(10, (paraA - (paraB / (paraC + currTemp))));
            if (currPressure >= vapPressure)
            {
                return "Lquid";
            } 
            else if (currPressure < vapPressure)
            {
                return "Gas";
            }
            else
            {
                return "Error";
            }
        }

        static void Main(string[] args)
        {
            AntoineCalc test1 = new AntoineCalc(8.20417, 1642.89, 230.3, 78.32, 770);
            test1.CalcState();
            Console.WriteLine("State is" + test1.CalcState());
        }
    }

}
