using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Problem
// To check year is Leap Year or not
{
    public class LeapYear
    {
        public int year;

        public LeapYear(int YEAR)
        {
            this.year = YEAR;
        }
        public static LeapYear YearInput()
        {
            Console.WriteLine("Enter the Year to Check Whether Leap Year or Not : ");
            int yeartoread = Convert.ToInt32(Console.ReadLine());

            return new LeapYear(yeartoread)
            {
                year = yeartoread
            };
        }
        
        public void toCheckLeapYear()
        {

            if (this.year % 4 == 0)
            {
                if (this.year % 100 == 0)
                {
                    if (this.year % 400 == 0)
                    {
                        Console.WriteLine("Its a Leap Year");
                    }
                    else
                    {
                        Console.WriteLine("Its not a Leap Year");

                    }
                }
                else
                {
                    Console.WriteLine("Its a Leap Year");
                }
            }
            else
            {
                Console.WriteLine("Its not a Leap Year");
            }
        }
    }
}

