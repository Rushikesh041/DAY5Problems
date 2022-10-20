using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Problem
{
    public class QuotientNdRemainder
    {
        public int dividend;
        public int divisor;

        public QuotientNdRemainder(int dividend, int divisor)
        {
            this.dividend = dividend;
            this.divisor = divisor;
        }
        public static QuotientNdRemainder UserInputForDivision()
        {
            Console.WriteLine("Enter Divident : ");
            int Di = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Divisor : ");
            int Dv = Convert.ToInt32(Console.ReadLine());

            return new QuotientNdRemainder(Di, Dv)
            {
                dividend = Di,
                divisor = Dv
            };
        }
        public void Calculation()
        {
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Quotient is : " + quotient);
            Console.WriteLine("Remainder is : " + remainder);
        }
    }
}