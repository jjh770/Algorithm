using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        string result = "";

        int score = int.Parse(input);

        if (score < 60)
            result = "F";
        else if (score < 70)
            result = "D";
        else if (score < 80)
            result = "C";
        else if (score < 90)
            result = "B";
        else if (score <= 100)
            result = "A";

        Console.WriteLine(result);
    }
}