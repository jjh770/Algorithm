using System;
class Program
{
    static void Main()
    {
        // Console.WriteLine((int)'a'); // 97
        string input = Console.ReadLine();
        int[] initArr = new int[26];
        for (int i = 0; i < 26; i++)
        {
            initArr[i] = -1;
        }

        for(int i = 0; i < input.Length; i++)
        {
            if (initArr[(int)input[i] - 97] != -1)
                continue;
            initArr[(int)input[i] - 97] = i;
        }
        Console.WriteLine(string.Join(" ", initArr));
    }
}