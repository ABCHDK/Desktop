using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Algoritm
    {
        private double _a;
        private double _b;
        private double e;
        public int IterCounter { get; private set; } = 0;
        public Func<double, double> formula = (x) => Math.Pow(x, 3) + 3 * Math.Pow(x, 2) + x;

        public Algoritm(int a, int b, double e)
        {
            _a = a;
            _b = b;
            this.e = e;            
        }
        public Algoritm() { }

        public double GetPowerNum(double x, double y)
        {
            var iter = 1;
            var result = x;
            if (y == 0)
                return 1;
            while (iter < y)
            {
                iter++;
                result *= x;
            }
            return result;
        }

        public double GetHalfDivine()
        {
            IterCounter = 0;
            var tempA = _a;
            var tempB = _b;
            

            while (true)
            {
                IterCounter++;
                var f = (double)(tempA + tempB) / 2;
                if (formula(f) * formula(tempB) < 0)
                    tempA = f;
                else
                    tempB = f;
                if (Math.Abs(tempA - tempB) < e)
                    return f;
            } 
        }
    }
}
