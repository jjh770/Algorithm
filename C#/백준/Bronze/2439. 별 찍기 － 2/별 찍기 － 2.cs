using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int input = int.Parse(Console.ReadLine());
        for (int i = 1; i <= input; i++)
        {
            for (int j = 1; j <= input - i; j++)
                Console.Write(" ");
            for (int j = 1; j <= i; j++)
                Console.Write("*");
            Console.WriteLine();
        }
    }
}