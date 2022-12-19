using System;
using System.Linq;

class Difference
{
    private int[] elements;
    public int maximumDifference;

    // Add your code here
    public Difference(int[] arrDif)
    {
        this.elements = arrDif;
    }
    public int computeDifference()
    {
        Array.Sort(elements);
        int minValue = elements[0];
        int maxValue = elements[elements.Length - 1];
        maximumDifference = maxValue - minValue;
        return maximumDifference;
    }
} // End of Difference Class

class Solution
{
    static void Main(string[] args)
    {
        Convert.ToInt32(Console.ReadLine());

        int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

        Difference d = new Difference(a);

        d.computeDifference();

        Console.Write(d.maximumDifference);
    }
}