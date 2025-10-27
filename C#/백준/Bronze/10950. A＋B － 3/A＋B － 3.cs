using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        for (int i = 0; i < input; i++)
        {
            string[] tc = Console.ReadLine().Split(' ');
            int num_1 = int.Parse(tc[0]);
            int num_2 = int.Parse(tc[1]);
            Console.WriteLine(num_1 + num_2);
        }
    }
}