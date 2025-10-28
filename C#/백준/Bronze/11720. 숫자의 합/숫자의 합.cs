using System;
class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int sum = 0;
        string inputNum = Console.ReadLine();
        for (int i = 0; i < input; i++)
        {
            sum += int.Parse(inputNum[i].ToString());
        }
        Console.WriteLine(sum);
    }
}