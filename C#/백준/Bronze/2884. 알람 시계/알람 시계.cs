using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int hour = int.Parse(input[0]);
        int min = int.Parse(input[1]);

        if (min - 45 < 0)
        {
            min += 15;
            hour -= 1;
        }
        else
            min -= 45;

        if (hour < 0)
            hour += 24;

        Console.WriteLine(hour + " " + min);
    }
}