using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int numarCuvinte = int.Parse(Console.ReadLine());
        string s1 = "";
        string s2 = "";
        List<string[]> arr = new List<string[]>();
        for (int j = 0; j < numarCuvinte; j++)
        {
            string s = Console.ReadLine();

            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                {
                    s1 += s[i];
                }
                else
                {
                    s2 += s[i];
                }
            }
            arr.Add(new string[] { s1, s2 });
            s1 = "";
            s2 = "";
        }

        foreach (var el in arr)
        {
            Console.WriteLine(string.Join(" ", el));
        }

    }
}