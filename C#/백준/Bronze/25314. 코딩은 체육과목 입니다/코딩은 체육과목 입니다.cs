using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int longCount = (input + 1) / 4;
        string dataResult = "";
        for (int i = 0; i < longCount; i++)
        {
            dataResult += "long ";
        }
        dataResult += "int";
        Console.WriteLine(dataResult);
    }
}