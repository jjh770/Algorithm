using System;

class Program
{
    static void Main()
    {
        int number = 0;
        int order = 0;
        int maxNum = int.MinValue;

        for (int i = 0; i < 9; i++)
        {
            number = int.Parse(Console.ReadLine());
            if (number > maxNum)
            {
                maxNum = number;
                order = i + 1;
            }
        }
        Console.WriteLine($"{maxNum}\n{order}");
    }
}