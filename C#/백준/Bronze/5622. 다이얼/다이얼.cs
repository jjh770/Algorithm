using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int result = 0;

        for (int i = 0; i < input.Length; i++)
        {
            char inputChar = input[i];
            int num = CalculateNum(inputChar);
            if (num <= 14)
                result += (num / 3) + 3;
            else if (num > 14 && num <= 18)
                result += 8;
            else if (num > 18 && num <= 21)
                result += 9;
            else
                result += 10;
        }
        Console.WriteLine(result);
    }
    static private int CalculateNum(char character)
    {
        int num = (int)character - (int)'A';
        return num;
    }
}