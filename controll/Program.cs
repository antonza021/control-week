using System;
using SumSeriesLib;

namespace controll
{
    class Program
    {
        static void Main(string[] args)
        {
            double epsilon = 0.0001;
            double x = 0.5;

            var results = Calculation.CalculateSumSeries(epsilon, x);

            for (int i = 0; i < results.Count; i += 2)
            {
                double term = results[i];
                double sum = results[i + 1];
                Console.WriteLine($"Term: {term}, Sum: {sum}");
            }

            Console.ReadKey();
        }
    }
}