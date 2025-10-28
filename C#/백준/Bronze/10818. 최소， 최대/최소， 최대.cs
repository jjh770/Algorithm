using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int input = int.Parse(Console.ReadLine());
        string[] number = Console.ReadLine().Split(' ');
        int[] numberInt = number.Select(x => int.Parse(x)).ToArray();

        int minNum = int.MaxValue;
        int maxNum = int.MinValue;

        for (int i = 0; i < numberInt.Length; i++)
        {
            if (numberInt[i] < minNum)
            {
                minNum = numberInt[i];
            }
            if (numberInt[i] > maxNum)
            {
                maxNum = numberInt[i];
            }
        }
        Console.WriteLine($"{minNum} {maxNum}");
    }
}