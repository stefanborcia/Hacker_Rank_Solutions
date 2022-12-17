using System;
using System.Linq;

class Person
{
    protected string firstName;
    protected string lastName;
    protected int id;

    public Person(string firstName, string lastName, int identification)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
    }
    public void printPerson()
    {
        Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
    }
}

class Student : Person
{
    private int[] testScores;

    /*	
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
    // Write your constructor here

    /*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    // Write your method here

    public Student(string firstName, string lastName, int idNumber, int[] scores)
    : base(firstName, lastName, idNumber)
    {
        testScores = scores;
    }

    public char Calculate()
    {
        int sum = 0;

        for (int i = 0; i < testScores.Length; i++)
        {
            sum = sum + testScores[i];
        }

        int grade = sum / testScores.Length;

        if (90 <= grade && grade <= 100)
        {
            return 'O';
        }

        if (80 <= grade && grade < 90)
        {
            return 'E';
        }

        if (70 <= grade && grade < 80)
        {
            return 'A';
        }

        if (55 <= grade && grade < 70)
        {
            return 'P';
        }

        if (40 <= grade && grade < 55)
        {
            return 'D';
        }

        return 'T';

    }
}

class Solution
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        string firstName = inputs[0];
        string lastName = inputs[1];
        int id = Convert.ToInt32(inputs[2]);
        int numScores = Convert.ToInt32(Console.ReadLine());
        inputs = Console.ReadLine().Split();
        int[] scores = new int[numScores];
        for (int i = 0; i < numScores; i++)
        {
            scores[i] = Convert.ToInt32(inputs[i]);
        }

        Student s = new Student(firstName, lastName, id, scores);
        s.printPerson();
        Console.WriteLine("Grade: " + s.Calculate() + "\n");
    }
}