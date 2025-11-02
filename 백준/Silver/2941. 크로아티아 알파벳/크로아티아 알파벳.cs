using System;

namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (97 <= input[i] && input[i] <= 122)
                {
                    if (input[i] == 'z' && i - 1 >= 0 && i + 1 < input.Length)
                    {
                        if (input[i - 1] == 'd' && input[i + 1] == '=')
                        {
                            continue;
                        }
                    }
                    else if (input[i] == 'j' && i - 1 >= 0)
                    {
                        if (input[i - 1] == 'l' || input[i - 1] == 'n')
                        {
                            continue;
                        }
                    }
                    result++;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(result);
        }
    }
}