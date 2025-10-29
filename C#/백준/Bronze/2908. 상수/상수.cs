using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        string input_1 = input[0];
        string input_2 = input[1];

        char[] arr_1 = input_1.ToCharArray();
        char[] arr_2 = input_2.ToCharArray();

        Array.Reverse(arr_1);
        Array.Reverse(arr_2);

        int num_1 = int.Parse(new string(arr_1));
        int num_2 = int.Parse(new string(arr_2));

        if (num_1 > num_2)
        {
            Console.WriteLine(num_1);
        }
        else
        {
            Console.WriteLine(num_2);
        }
    }
}