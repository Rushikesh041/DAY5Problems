using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Problem
{
   
      public class UserInput
      {
        //Check Whether a Number is Even or Odd Problem
        public void evenOrOddProblem()
        {
            var Eo = EvenOrOdd.UserInputNum();
            EvenOrOdd evenOrOdd = new EvenOrOdd(Eo.Number);
            evenOrOdd.checkEvenOdd();
        }
        //Flip Coin Percentage Problem
        public void flipCoinPercentageProblem()
        {
            var fl = FCPercentage.UserInputForFlip();
            FCPercentage coin = new FCPercentage(fl.Times);
            coin.getPercentageOfFlipCion();
        }
        //Harmonic Number Problem
        public void harmonicNumberProblem()
        {
            var hr = HarmonicNumber.UserInputForHarmonicSeries();
            HarmonicNumber Harmonic = new HarmonicNumber(hr.n);
            Harmonic.harmonicSeries();
        }
        //Find the Largest Among Three Numbers Problem
        public void LargestNumberProblem()
        {
            var lr = LargestNumber.UserInputForLargestNum();
            LargestNumber largest = new LargestNumber(lr.Num1, lr.Num2, lr.Num3);
            largest.CalculateLargestNumber();
        }
        //Leap Year Problem
        public void leapYearProblem()
        {
            var l1 = LeapYear.YearInput();
            LeapYear Year = new LeapYear(l1.year);
            Year.toCheckLeapYear();
        }
        // Power of 2 Problem
        public void powerOf2Problem()
        {
            var p = PowerOf2.UserInputPowerOf2();
            PowerOf2 power = new PowerOf2(p.N);
            power.getPowerOf2();
        }
       
        // Prime Factors Problem
        public void primeFactorOfNumberProblem()
        {
            var ft = PrimeFactorsOfNumber.UserInputPrimeFactorNumber();
            PrimeFactorsOfNumber factor = new PrimeFactorsOfNumber(ft.Number);
            factor.PrimeFactors();
        }
        // Compute Quotient and Remainder Problem
        public void quotientNdRemainderProblem()
        {
            var cal = QuotientNdRemainder.UserInputForDivision();
            QuotientNdRemainder Qr = new QuotientNdRemainder(cal.dividend, cal.divisor);
            Qr.Calculation();
        }
        //Swaping Two Numbers Problem
        public void swapTwoNumbersProblem()
        {
            var sp = SwapTwoNumbers.UserInputNumbers();
            SwapTwoNumbers swap = new SwapTwoNumbers(sp.Number1, sp.Number2);
            swap.SwappingOfTwoNumbers();
        }
       
        //Check Whether an Alphabet is Vowel or Consonant Problem
        public void vowelOrConsonentProblem()
        {
            var vc = VowelOrConsonent.UserInputAlphabet();
            VowelOrConsonent vowelOrConsonent = new VowelOrConsonent(vc.Alphabet);
            vowelOrConsonent.CheckVowelOrConsonent();
        }
      
      }
}
