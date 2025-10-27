using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int result = 0;
        for (int i = 1; i <= input; i++)
            result += i;
        Console.WriteLine(result);
    }
}