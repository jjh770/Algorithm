using System;

class Program
{
    static void Main()
    {
        string line;
        while (true)
        {
            line = Console.ReadLine();
            if (string.IsNullOrEmpty(line))
            {
                break;
            }
            Console.WriteLine(line);
        }
    }
}