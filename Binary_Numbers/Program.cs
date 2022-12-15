using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            string b = Convert.ToString(n, 2);

            int c = 0;
            int max = 0;

            foreach (char x in b)
            {
                if (x == '1')
                {
                    c++;
                }
                else
                {
                    c = 0;
                }
                max = (int)Math.Max(c, max);
            }
            Console.WriteLine(max);
        }
    }
}
