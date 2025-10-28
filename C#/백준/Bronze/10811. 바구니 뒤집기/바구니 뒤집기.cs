using System;
class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int[] inputNum = input.Select(int.Parse).ToArray();

        int[] basket = new int[inputNum[0]];
        for (int i = 0; i < inputNum[0]; i++)
        {
            basket[i] = i + 1;
        }

        for (int i = 0; i < inputNum[1]; i++)
        {
            string[] change = Console.ReadLine().Split(' ');
            int[] changeNum = change.Select(int.Parse).ToArray(); 

            int start = changeNum[0] - 1;  
            int end = changeNum[1] - 1;    

            while (start < end)
            {
                (basket[start], basket[end]) = (basket[end], basket[start]);
                start++;
                end--;
            }
        }

        Console.WriteLine(string.Join(" ", basket));
    }
}
