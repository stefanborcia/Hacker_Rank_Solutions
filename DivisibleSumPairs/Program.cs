using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleSumPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ar = new List<int>(){ 1, 2, 3, 4, 5, 6 };

            int k = 5;
            int count = 0;
            for (int i = 0; i < ar.Count - 1; i++)
            {
                for (int j = i +1 ; j < ar.Count; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        count++;
                    }
                }
            }
        }
    }
}
