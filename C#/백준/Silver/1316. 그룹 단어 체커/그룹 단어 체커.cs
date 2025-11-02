using System;
using System.Text;

class Program
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        string input = "";
        int result = count;

        bool groupEnd = false;

        bool stop = false;

        for (int i = 0; i < count; i++)
        {
            input = Console.ReadLine();

            for (int k = 0; k < input.Length; k++)
            {
                for (int p = k+1; p < input.Length; p++)
                {
                    if (input[k] == input[p])
                    {
                        if (groupEnd == true)
                        {
                            groupEnd = false;
                            result--;
                            stop = true;
                            break;
                        }
                    }
                    else
                    {
                        groupEnd = true;
                    }
                }
                groupEnd = false;
                if (stop == true)
                {
                    stop = false;
                    break;
                }
            }
        }
        Console.WriteLine(result);
    }
}