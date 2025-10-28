using System;
using System.Text;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int[] inputNum = input.Select(x => int.Parse(x)).ToArray();

        int[] basket = new int[inputNum[0]];

        for (int i = 0; i < inputNum[1]; i++)
        {
            string[] ball = Console.ReadLine().Split(' ');
            int start = int.Parse(ball[0]);
            int end = int.Parse(ball[1]);
            int ballNum = int.Parse(ball[2]);

            for (int j = start; j <= end; j++)
            {
                basket[j - 1] = ballNum;
            }
        }

        Console.WriteLine(string.Join(" ", basket));
    }
}