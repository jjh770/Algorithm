using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine().Trim();
        Console.WriteLine(input == "" ? 0 : input.Split().Length);
    }
}