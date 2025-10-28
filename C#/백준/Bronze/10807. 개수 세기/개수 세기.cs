using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        string[] number = Console.ReadLine().Split(' ');
        int[] numberInt = number.Select(x => int.Parse(x)).ToArray();
        int verif = int.Parse(Console.ReadLine());
        int answer = 0;

        for (int i = 0; i < numberInt.Length; i++)
        {
            if (numberInt[i] == verif)
                answer++;
        }
        Console.WriteLine(answer);
    }
}