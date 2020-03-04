using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntoineCalcApp
{
    public class AntoineCalc
    {
        double paraA;
        double paraB;
        double paraC;
        double currTemp;
        double currPressure;
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
            if (currPressure >= vapPressure)
            {
                return "Liquid";
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

        public double CalcPv()
        {
            return vapPressure = Math.Pow(10, (paraA - (paraB / (paraC + currTemp))));
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Boiling Enthanol, A = 8.20417, B = 1642.89, C = 230.3, T = 78.32 C, P = 760 mmHg");

            double inputParaA;
            double inputParaB;
            double inputParaC;
            double inputCurrTemp;            
            double inputCurrPressure;
            bool boolAnswer;
            string answer;

            do
            {
                Console.WriteLine("Input parameter A: ");
                inputParaA = Double.Parse(Console.ReadLine());
                Console.WriteLine("Input parameter B: ");
                inputParaB = Double.Parse(Console.ReadLine());
                Console.WriteLine("Input parameter C: ");
                inputParaC = Double.Parse(Console.ReadLine());
                Console.WriteLine("Input parameter current Temperature: ");
                inputCurrTemp = Double.Parse(Console.ReadLine());
                Console.WriteLine("Input parameter current Pressure: ");
                inputCurrPressure = Double.Parse(Console.ReadLine());
                
                AntoineCalc test1 = new AntoineCalc(inputParaA, inputParaB, inputParaC, inputCurrTemp, inputCurrPressure);
                Console.WriteLine("Partial vapour pressure is {0} , State is {1}", test1.CalcPv(), test1.CalcState());

                Console.WriteLine("More calculations? (Y/N)");
                answer = Console.ReadLine();
                if (answer == "Y" | answer == "y")
                {
                    boolAnswer = true;
                }
                else { boolAnswer = false; }
            }
            while (boolAnswer);                     
        }
    }
}
