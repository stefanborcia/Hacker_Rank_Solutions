using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckPalindrome("madam"));
            Console.WriteLine(CheckPalindrome("hello"));
            Console.WriteLine(CheckPalindrome(73537));

            Console.ReadKey();
        }

        public static bool CheckPalindrome(string word)
        {
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != (word[word.Length - i - 1]))
                    return false;
            }
            return true;
        }

        public static bool CheckPalindrome(int c)
        {
            int temp = c;
            int sum = 0;
            while (temp > 0)
            {
                int result = temp % 10;
                sum = sum * 10 + result;
                temp /= 10;
            }
            return c == sum;
        }
    }
}