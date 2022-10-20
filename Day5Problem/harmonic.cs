using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Problem
{
    public class HarmonicNumber
    {
        public double n;
        private double value = 0.0;

        public HarmonicNumber(double N)
        {
            this.n = N;
        }
        public static HarmonicNumber UserInputForHarmonicSeries()
        {
            Console.WriteLine("Enter Number : ");
            int H = Convert.ToInt32(Console.ReadLine());

            return new HarmonicNumber(H)
            {
                n = H
            };
        }
        public void harmonicSeries()
        {
            for (int i = 1; i <= n; i++)
            {
                value += 1 / (float)i;
            }
            Console.WriteLine(value);
            Console.WriteLine("Sum of n Numbher of Hrmonic series is " + value);
        }
    }
}
