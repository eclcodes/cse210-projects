using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        float gradePercentage = float.Parse(percentage);
        string letter = "";


        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"You got a {letter}.");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congrats! You've passed! All that hard work paid off!");
        }
        else
        {
            Console.WriteLine("You didn't pass this time. Study more and try again!");
        }
    }
}