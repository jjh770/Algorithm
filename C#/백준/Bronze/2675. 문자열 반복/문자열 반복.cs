using System;
using System.Text;
class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());


        StringBuilder sb = new StringBuilder();

        for(int i = 0; i < num; i++)
        {
            string[] input = Console.ReadLine().Split(' ');

            int count = int.Parse(input[0]);
            string word = input[1];

            for(int j = 0; j < word.Length; j++)
            {
                for (int k = 0; k < count; k++)
                {
                    sb.Append(word[j]);
                }
            }
            sb.Append("\n");
        }
        Console.WriteLine(sb.ToString());
    }
}