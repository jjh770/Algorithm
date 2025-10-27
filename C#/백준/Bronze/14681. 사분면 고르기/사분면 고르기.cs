using System;

class Program
{
    static void Main()
    {
        int input_1 = int.Parse(Console.ReadLine());
        int input_2 = int.Parse(Console.ReadLine());

        if (input_1 > 0 && input_2 > 0)
            Console.WriteLine(1);
        else if (input_1 < 0 && input_2 > 0)
            Console.WriteLine(2);
        else if (input_1 < 0 && input_2 < 0)
            Console.WriteLine(3);
        else if (input_1 > 0 && input_2 < 0)
            Console.WriteLine(4);
    }
}