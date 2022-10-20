using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Program to check Number is even or odd
namespace Day5Problem
{
    public class EvenOrOdd
    {
        public int Number;

        public EvenOrOdd(int number)
        {
            Number = number;
        }
        public static EvenOrOdd UserInputNum()
        {
            Console.WriteLine("Enter Number to Check Even or Odd : ");
            int num = Convert.ToInt32(Console.ReadLine());

            return new EvenOrOdd(num)
            {
                Number = num
            };
        }
        public void checkEvenOdd()
        {
            if (Number % 2 == 0)
            {
                Console.WriteLine(Number + " is an Even Number ");
            }
            else
            {
                Console.WriteLine(Number + " is an odd Number ");
            }
        }
    }
}

