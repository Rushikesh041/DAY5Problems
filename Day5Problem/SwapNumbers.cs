using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Problem
{
    public class SwapTwoNumbers
    {
        public int Number1;
        public int Number2;

        public SwapTwoNumbers(int number1, int number2)
        {
            Number1 = number1;
            Number2 = number2;
        }
        public static SwapTwoNumbers UserInputNumbers()
        {
            Console.WriteLine("Enter Number 1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            return new SwapTwoNumbers(num1, num2)
            {
                Number1 = num1,
                Number2 = num2
            };
        }
        public void SwappingOfTwoNumbers()
        {
            int Number3 = Number1;
            Number1 = Number2;
            Number2 = Number3;

            Console.WriteLine("Number 1 is : " + Number1);
            Console.WriteLine("Number 2 is : " + Number2);
        }
    }
}