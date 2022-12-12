using System;
using System.Collections.Generic;
using System.IO;

class DataTypes
{
    static void Main(String[] args)
    {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        // Declare second integer, double, and String variables.
        // Read and save an integer, double, and String to your variables.
        int i2 = Convert.ToInt32(Console.ReadLine());
        double d2 = Convert.ToDouble(Console.ReadLine());
        string s2 = Console.ReadLine();

        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + i2);

        // Print the sum of the double variables on a new line.
        Console.WriteLine("{0:.0}", d + d2);

        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        Console.WriteLine(s + s2);
    }
}