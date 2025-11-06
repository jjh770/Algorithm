using System;
class Program
{
    static void Main()
    {
        List<char[]> list = new List<char[]>();
        for (int i = 0; i < 5; i++)
        {
            string input = Console.ReadLine();
            list.Add(input.ToCharArray());
        }

        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (list[j].Length > i)
                {
                    Console.Write(list[j][i]);
                }
            }
        }
    }
}