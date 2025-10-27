using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        int year = int.Parse(input);

        Console.WriteLine(year - 2541 + 1998);
    }
}