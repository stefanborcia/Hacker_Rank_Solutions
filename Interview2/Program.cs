using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview2
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public string PrintFizzBuzz(int input)
        {
            // Your code goes here
            return input % 15 == 0 ? "FizzBuzz"
                : input % 3 == 0 ? "Fizz"
                : input % 5 == 0 ? "Buzz"
                : input.ToString();
        }
    }
}
