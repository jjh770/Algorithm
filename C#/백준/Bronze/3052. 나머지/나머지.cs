using System;

class Program
{
    static void Main()
    {
        List<int> result = new List<int>();
        int num = 0;
        for (int i = 0; i < 10; i++)
        {
            num = int.Parse(Console.ReadLine().Trim());
            if (result.Contains(num % 42))
                continue;
            result.Add(num % 42);
        }
        Console.WriteLine(result.Count);
    }
}