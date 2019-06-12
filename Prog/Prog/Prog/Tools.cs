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

        public static void RemoveComments(ref string s)
        {
            char[] b = new char[s.Length];
            char[] z = s.ToCharArray();
            int Len = 0;
            for (int i = 0; i < z.Length; i++)
            {
                if (z[i] != '#')
                {
                    Len++;
                    b[i] = z[i];
                }
                else break;
            }

            if (b.Length == 0)
                s = null;
            s = "";
            for (int i = 0; i < Len; i++)
            {
                s += b[i];
            }
        }

        public static int FindMinLength(string[] InputStrings)
        {
            string[] valuesInLine;
            char[] separators = new char[] { ' ', '\t', '\n' };
            int MinVal = 10000;
            for (int i = 0; i < InputStrings.Length; i++)
            {
                Tools.RemoveComments(ref InputStrings[i]);
                valuesInLine = InputStrings[i].Split(separators, StringSplitOptions.RemoveEmptyEntries);
                if (MinVal >= valuesInLine.Length && valuesInLine.Length != 0)
                {
                    MinVal = valuesInLine.Length;
                }
            }
            return MinVal;
        }
    }
}
