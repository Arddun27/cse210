using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string gradeInput = Console.ReadLine();
        int gradePercent = int.Parse(gradeInput);
        string letterGrade = "";
        bool passing = true;
        string passFail = "";
        
        if (gradePercent >= 90)
        {
            letterGrade = "A";
            passing = true;
        }
        else if (gradePercent >= 80)
        {
            letterGrade = "B";
            passing = true;
        }
        else if (gradePercent >= 70)
        {
            letterGrade = "C";
            passing = true;
        }
        else if (gradePercent >= 60)
        {
            letterGrade = "D";
            passing = false;
        }
        else if (gradePercent < 60)
        {
            letterGrade = "F";
            passing = false;
        }  

        if (passing == true)
        {
            passFail = "passed!";
        }
        else
        {
            passFail = "failed.";
        }

        Console.WriteLine($"Your grade is a {letterGrade} you {passFail}");
    }

        
}