using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripletsConsecutive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 2, 2, 2, 4, 5, 3, 3, 3 };

            List<int> inputList = new List<int>();

            foreach (var number in input)
            {
                inputList.Add(number);
            }

            int counter = 0;

            for (int i = 0; i < inputList.Count; i++)
            {
                for (int j = i+1; j < inputList.Count - 1; j++)
                {
                    if (input[i] == input[j] && input[i] == input[j + 1])
                    {
                        counter++;
                        inputList.RemoveAt(j+1);
                        inputList.RemoveAt(j);
                        inputList.RemoveAt(i);
                        i--;
                    }
                }
            }
            Console.WriteLine(counter);

            Console.ReadKey();
        }
    }
}
