using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Problem
{
    public class VowelOrConsonent
    {
        public char Alphabet;

        public VowelOrConsonent(char alphabet)
        {
            Alphabet = alphabet;
        }
        public static VowelOrConsonent UserInputAlphabet()
        {
            Console.WriteLine("Enter Alphabet to Check Vowel or Consonant : ");
            char alpha = Convert.ToChar(Console.ReadLine().ToLower());

            return new VowelOrConsonent(alpha)
            {
                Alphabet = alpha
            };
        }
        public void CheckVowelOrConsonent()
        {
            if (Alphabet == 'a' || Alphabet == 'e' || Alphabet == 'i' || Alphabet == 'o' || Alphabet == 'u')
            {
                Console.WriteLine(Alphabet + " is Vowel.");
            }
            else
            {
                Console.WriteLine(Alphabet + " is Consonent.");
            }
        }
    }
}