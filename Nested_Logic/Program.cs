using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        string[] actually = Console.ReadLine().Split(' ');
        int actuallyDay = int.Parse(actually[0]);
        int actuallyMonth = int.Parse(actually[1]);
        int actuallyYear = int.Parse(actually[2]);

        string[] expected = Console.ReadLine().Split(' ');
        int expectedDay = int.Parse(expected[0]);
        int expectedMonth = int.Parse(expected[1]);
        int expectedYear = int.Parse(expected[2]);

        int fine = 0;

        if (actuallyYear > expectedYear) fine = 10000;
        else if (actuallyYear == expectedYear)
        {
            if (actuallyMonth > expectedMonth) fine = (actuallyMonth - expectedMonth) * 500;
            else if (actuallyMonth == expectedMonth && actuallyDay > expectedDay) fine = (actuallyDay - expectedDay) * 15;
        }

        Console.WriteLine(fine);
    }
}
