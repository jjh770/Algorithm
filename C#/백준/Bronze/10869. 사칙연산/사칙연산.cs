using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        string[] parts = input.Split(' ');

        int a = int.Parse(parts[0]);
        int b = int.Parse(parts[1]);

        Console.WriteLine(a + b);
        Console.WriteLine(a - b);
        Console.WriteLine(a * b);
        Console.WriteLine(a / b);
        Console.WriteLine(a % b);

    }
}