using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');

        int[] dice = input.Select(x => int.Parse(x)).ToArray();

        if (dice.All(x => x == dice[0]))
        {
            Console.WriteLine(1000 * dice[0] + 10000);
            return;
        }
        if (dice[0] == dice[1])
            Console.WriteLine(1000 + 100 * dice[0]);
        else if (dice[0] == dice[2])
            Console.WriteLine(1000 + 100 * dice[0]);
        else if (dice[1] == dice[2])
            Console.WriteLine(1000 + 100 * dice[1]);
        else
            Console.WriteLine(dice.Max() * 100);
    }
}