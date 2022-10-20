using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Problem
// Program to Find the Largest Number in three
{
    public class LargestNumber
    {
        public int Num1, Num2, Num3;

        public LargestNumber(int num1, int num2, int num3)
        {
            Num1 = num1;
            Num2 = num2;
            Num3 = num3;
        }
        public static LargestNumber UserInputForLargestNum()
        {
            Console.WriteLine("To Find Largest Number Enter Three Numbers Below");
            Console.WriteLine("Enter Number 1 : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2 : ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 3 : ");
            int n3 = Convert.ToInt32(Console.ReadLine());

            return new LargestNumber(n1, n2, n3)
            {
                Num1 = n1,
                Num2 = n2,
                Num3 = n3
            };
        }
        public void CalculateLargestNumber()
        {
            if (Num1 > Num2 && Num1 > Num3)
            {
                Console.WriteLine(Num1 + " is Largest Amoung All");
            }
            else if (Num2 > Num1 && Num2 > Num3)
            {
                Console.WriteLine(Num2 + " is Largest Amoung All");
            }
            else
            {
                Console.WriteLine(Num3 + " is Largest Amoung All");
            }
        }
    }
}
