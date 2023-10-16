using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeriesLib
{
    public class Calculation
    {
        public static List<double> CalculateSumSeries(double epsilon, double x)
        {
            List<double> results = new List<double>();
            double term = x;
            double sum = term;
            int n = 1;

            results.Add(term);
            results.Add(sum);

            while (Math.Abs(term) >= epsilon)
            {
                term *= -x * x * (2 * n - 1) / (2 * n);
                sum += term;
                n++;
                results.Add(term);
                results.Add(sum);
            }

            return results;
        }
    }
}
