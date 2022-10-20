using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day5Problem
// Flip Coin and Print percentage of Heads and Tails
{
    public class FCPercentage
    {
        public int Times;

        public FCPercentage(int times)
        {
            this.Times = times;
        }
        public static FCPercentage UserInputForFlip()
        {
            Console.WriteLine("Enter How Many Times You Have to Flip a Coin : ");
            int C = Convert.ToInt32(Console.ReadLine());

            return new FCPercentage(C)
            {
                Times = C
            };
        }
        public void getPercentageOfFlipCion()
        {
            float count1 = 0;
            float count2 = 0;
            for (int i = 1; i <= Times; i++)
            {
                Random random = new Random();
                int Flip = random.Next(0, 2);

                if (Flip == 0)
                {
                    Console.WriteLine("HEAD");
                    count1++;
                }
                else if (Flip == 1)
                {
                    Console.WriteLine("TAILS");
                    count2++;
                }

            }
            double Percentage = (count1 / count2) * 100;
            // Console.WriteLine("Percentage of Head vs Tail is : " + Percentage);
            Console.WriteLine("Percentage of Head vs Tail is : " + (Math.Round(Percentage, 2)));
        }
    }
}




