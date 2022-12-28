using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        // Write your code here

        int numberOfSwaps = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                if (a.ElementAt(j) > a.ElementAt(j + 1))
                {
                    //Swapping elements
                    int tempVal = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = tempVal;

                    //Increasing swap count
                    numberOfSwaps++;
                }
            }
        }
        Console.WriteLine("Array is sorted in {0} swaps.", numberOfSwaps);
        Console.WriteLine("First Element: {0}", a.ElementAt(0));
        Console.WriteLine("Last Element: {0}", a.ElementAt(n - 1));
    }
}