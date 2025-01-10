using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    public class AdvMath
    {
        public double CalcArea(double Height, double Width)
        {
            return Height * Width;
        }
        public double CalcAverage(List<double> values)
        {
            if (values == null || values.Count == 0)
                throw new ArgumentException("The list of values cannot be null or empty.");

            double sum = 0;
            foreach (var value in values)
            {
                sum += value;
            }
            return sum / values.Count;
        }

        public double Squared(double value)
        {
            return value * value;
        }
        public double CalcHypotenuse(double a, double b)
        {
            double c = Math.Sqrt(Squared(a) + Squared(b));
            return c;
        }
    }
}
