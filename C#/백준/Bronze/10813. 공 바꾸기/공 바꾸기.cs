using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int[] inputNum = input.Select(x => int.Parse(x)).ToArray();

        int[] basket = new int[inputNum[0]];

        for (int i = 0; i < basket.Length; i++)
        {
            basket[i] = i + 1;
        }

        for (int i = 0; i < inputNum[1]; i++)
        {
            string[] change = Console.ReadLine().Split(' ');
            int start = int.Parse(change[0]);
            int end = int.Parse(change[1]);

            (basket[start - 1], basket[end - 1]) = (basket[end - 1], basket[start - 1]);
        }

        Console.WriteLine(string.Join(" ", basket));
    }
}