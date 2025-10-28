using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        string[] input = Console.ReadLine().Split(' ');
        string[] number = Console.ReadLine().Split(' ');
        int[] numberInt = number.Select(x => int.Parse(x)).ToArray();

        for (int i = 0; i < int.Parse(input[0]); i++)
        {
            if (numberInt[i] < int.Parse(input[1]))
            {
                if (sb.Length == 0)
                {
                    sb.Append(numberInt[i]);
                    continue;
                }
                sb.Append(" " + numberInt[i]);
            }
        }
        Console.WriteLine(sb);
    }
}