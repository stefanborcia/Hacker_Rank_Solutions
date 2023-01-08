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

class Result
{

    /*
     * Complete the 'beautifulDays' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER i
     *  2. INTEGER j
     *  3. INTEGER k
     */

    public static int beautifulDays(int i, int j, int k)
    {
        int count = 0;
        for (int m = i; m <= j; m++)
        {
            if (DifferenceByNumAndReverse(m) % k == 0)
                count++;
        }
        return count;
    }
    public static int DifferenceByNumAndReverse(int a)
    {

        //calculate reverse of number

        //first extract digit 
        List<int> digits = new List<int>();
        int initA = a;
        int mod;
        while (a > 0)
        {
            mod = a % 10;
            digits.Add(mod);
            a /= 10;
        }
        string reverse = "";
        foreach (var item in digits)
        {
            reverse = reverse + item;
        }
        //this is reversed num
        int reverseNum = Int32.Parse(reverse);
        return Math.Abs(reverseNum - initA);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int i = Convert.ToInt32(firstMultipleInput[0]);

        int j = Convert.ToInt32(firstMultipleInput[1]);

        int k = Convert.ToInt32(firstMultipleInput[2]);

        int result = Result.beautifulDays(i, j, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
