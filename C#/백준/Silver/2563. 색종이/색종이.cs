using System;
class Program
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        string[] input;

        bool[,] whitePaper = new bool[100, 100];

        int result = 0;

        for (int i = 0; i < count; i++)
        {
            input = Console.ReadLine().Split();

            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);
            for (int k = x; k < x + 10; k++)
            {
                for (int p = y; p < y + 10; p++)
                {
                    whitePaper[k, p] = true;
                }
            }
        }
        for (int i = 0; i < 100; i++)
        {
            for (int k = 0; k < 100; k++)
            {
                if (whitePaper[i, k] == true)
                {
                    result++;
                }
            }
        }
        Console.WriteLine(result);

    }
}