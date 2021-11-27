using System;

namespace Lab05
{
    class Operation
    {
        public static double STriangle(double a, double b, double c, out double s)
        {
            if (Operation.CheckTriangle(a, b, c))
            {
                double p2 = a + b + c;
                double p = p2 / 2;
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return s;
            }
            else
            {
                s = 0;
                return s;
            }
        }
        private static bool CheckTriangle(double a, double b, double c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                if (a + b <= c || a + c <= b || b + c <= a)
                    return false;
                else
                    return true;
            }
            else
                return false;
        }
        public static double STriangle(double a, out double s)
        {
            double p2 = a * 3;
            double p = p2 / 2;
            s = Math.Sqrt(p * (p - a) * (p - a) * (p - a));
            return s;
        }
    }
}
