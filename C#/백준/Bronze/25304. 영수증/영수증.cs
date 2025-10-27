using System;
using System.Security.AccessControl;

class Program
{
    static void Main()
    {
        int cost = int.Parse(Console.ReadLine());
        int num = int.Parse(Console.ReadLine());
        int result = 0;

        for (int i = 1; i <= num; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] goods = input.Select(x => int.Parse(x.ToString())).ToArray();

            result += goods[0] * goods[1];
        }

        if (result == cost)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }
}