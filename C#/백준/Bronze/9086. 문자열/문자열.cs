using System;
using System.Text;
class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int input = int.Parse(Console.ReadLine());

        for (int i = 0; i < input; i++)
        {
            string word = Console.ReadLine();
            sb.Append($"{word[0]}{word[word.Length - 1]}\n");
        }
        Console.WriteLine(sb);
    }
}
