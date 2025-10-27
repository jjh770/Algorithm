using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        
        string[] part = input.Split(' ');
        
        int a = int.Parse(part[0]);
        int b = int.Parse(part[1]);
        
        Console.WriteLine(a * b);
    }
}