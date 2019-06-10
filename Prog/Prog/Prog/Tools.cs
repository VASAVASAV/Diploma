using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog
{
    static class Tools
    {
        static public double CountIntegral(Func<double,double> Target, double BottomLimit, double UpperLimit, double step)
        {
            double result = 0;
            double Multiplier = 1;
            if (BottomLimit > UpperLimit)
            {
                Multiplier = -1;
                double temp = BottomLimit;
                BottomLimit = UpperLimit;
                UpperLimit = temp;
            }
            double CurrentPos = BottomLimit;
            while (CurrentPos < UpperLimit)
            {
                if (CurrentPos + step > UpperLimit)
                {
                    step = UpperLimit - CurrentPos;
                }
                result += (step / 6) * (Target(CurrentPos) + 4 * Target(CurrentPos + step / 2) + Target(CurrentPos));
                CurrentPos += step;
            }
            return result;
        }
    }
}
