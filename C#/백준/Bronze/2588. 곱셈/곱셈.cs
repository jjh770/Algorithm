using System;

class Program
{
    static void Main()
    {
        int input_1 = int.Parse(Console.ReadLine());
        string input_2 = Console.ReadLine();

        int[] parts_2 = input_2.Select(x => int.Parse(x.ToString())).ToArray();

        Console.WriteLine(input_1 * parts_2[2]);
        Console.WriteLine(input_1 * parts_2[1]);
        Console.WriteLine(input_1 * parts_2[0]);
        Console.WriteLine(input_1 * int.Parse(input_2));
    }
}