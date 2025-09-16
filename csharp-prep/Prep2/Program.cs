using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int gradePercentage = int.Parse(Console.ReadLine());
        float plusMinus = gradePercentage % 10;
        string sign = "";
        string grade = "";

        if (plusMinus >= 7)
        {
            sign = "+";
        }
        if(plusMinus <= 3)
            {
                sign = "-";
            }
        if(gradePercentage >= 97)
            {
                sign = "";
            }
        if(gradePercentage <= 60)
            {
                sign = "";
            }
        if(gradePercentage >= 90)
            {
                grade = "A";
            }
        else if(gradePercentage >= 80)
            {
                grade = "B";
            }
        else if(gradePercentage >= 70)
            {
                grade = "C";
            }
        else if(gradePercentage >= 60)
            {
                grade = "D";
            }
        else
            {
                grade = "F";
            }

        grade = grade + sign;
        if(gradePercentage >= 70)
            {
                Console.WriteLine("You passed!");
            }
        else
            {
                Console.WriteLine("You did not pass..");
            }
        Console.WriteLine($"Your grade is: {grade}");
    }     
}