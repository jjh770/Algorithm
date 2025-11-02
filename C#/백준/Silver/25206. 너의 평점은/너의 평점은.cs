using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.BackgroundColor = ConsoleColor.DarkCyan;

        string[] input;
        float gradeScore = 0f;
        float currentCredit = 0f;
        float totalCredit = 0f;

        float totalSumResult = 0f;

        for (int i = 0; i < 20; i++)
        {
            input = Console.ReadLine().Split();

            if (input[2] != "P")
            {
                gradeScore = ConvertGradesToScores(input[2]);
            }
            else
            {
                continue;
            }

            currentCredit = float.Parse(input[1]);
            totalCredit += currentCredit;
            totalSumResult += currentCredit * gradeScore;
        }
        Console.WriteLine(totalSumResult / totalCredit);

    }

    private static float ConvertGradesToScores(string grade)
    {
        float temp = 0;
        switch (grade[0])
        {
            case 'F':
                return 0.0f;
            case 'A':
                temp += 4.0f;
                break;
            case 'B':
                temp += 3.0f;
                break;
            case 'C':
                temp += 2.0f;
                break;
            case 'D':
                temp += 1.0f;
                break;
            default:
                break;
        }

        switch (grade[1])
        {
            case '+':
                temp += 0.5f;
                break;
            case '0':
                break;
        }
        return temp;
    }
}