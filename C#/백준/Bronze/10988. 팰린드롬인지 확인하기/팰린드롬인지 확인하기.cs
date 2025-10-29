using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] inputChar = input.ToCharArray();
        Array.Reverse(inputChar);
        string changeInput = new string(inputChar);
        
        if (changeInput == input)
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}
