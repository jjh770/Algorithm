using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int clock = int.Parse(Console.ReadLine());
        int hour = int.Parse(input[0]);
        int min = int.Parse(input[1]);

        min += clock;
        while (min >= 60)
        {
            min = min - 60;
            hour ++;
        }

        if (hour >= 24)
            hour -= 24;

        Console.WriteLine(hour + " " + min);
    }
}