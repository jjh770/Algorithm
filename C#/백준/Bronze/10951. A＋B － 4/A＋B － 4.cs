using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();

        while (true)
        {
            string line = Console.ReadLine();

            if (line == null)
            {
                break;
            }
            string[] input = line.Split(' ');

            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            sb.Append(a + b + "\n");
        }
        Console.WriteLine(sb);
    }
}