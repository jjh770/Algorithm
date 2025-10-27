using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        string[] parts = input.Split(' ');

        long a = long.Parse(parts[0]);
        long b = long.Parse(parts[1]);
        long c = long.Parse(parts[2]);

        Console.WriteLine(a + b + c);
    }
}