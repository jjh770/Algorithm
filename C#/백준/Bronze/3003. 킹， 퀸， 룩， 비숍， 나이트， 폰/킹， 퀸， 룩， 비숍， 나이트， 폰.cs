using System;
using System.Text;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int[] chessRule = new int[6] { 1, 1, 2, 2, 2, 8 };
        int[] chessUnit = input.Select(int.Parse).ToArray();

        for (int i = 0; i < chessRule.Length; i++)
        {
            chessRule[i] -= chessUnit[i];
        }
        
        Console.WriteLine(String.Join(" ", chessRule));
    }
}