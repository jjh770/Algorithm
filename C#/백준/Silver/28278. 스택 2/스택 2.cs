using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int input = int.Parse(Console.ReadLine());
        int command = 0;
        int stackCount = 0;
        List<int> stack = new List<int>();

        for (int i = 0; i < input; i++)
        {
            string[] inputCommand = Console.ReadLine().Split(" ");
            command = int.Parse(inputCommand[0]);
            stackCount = stack.Count;

            switch (command)
            {
                case 1:
                    stack.Add(int.Parse(inputCommand[1]));
                    break;
                case 2:
                    if (stackCount > 0)
                    {
                        //Console.WriteLine(stack[stackCount - 1]);
                        sb.Append($"{stack[stackCount - 1]}\n");
                        stack.RemoveAt(stackCount - 1);
                    }
                    else
                    {
                        //Console.WriteLine("-1");
                        sb.Append("-1\n");
                    }
                    break;
                case 3:
                    sb.Append($"{stackCount}\n");
                    //Console.WriteLine(stackCount);
                    break;
                case 4:
                    if (stackCount == 0)
                    {
                        sb.Append("1\n");
                        //Console.WriteLine("1");
                    }
                    else
                    {
                        sb.Append("0\n");
                        //Console.WriteLine("0");
                    }
                    break;
                case 5:
                    if (stackCount > 0)
                    {
                        sb.Append($"{stack[stackCount - 1]}\n");
                        //Console.WriteLine(stack[stackCount - 1]);
                    }
                    else
                    {
                        sb.Append("-1\n");
                        //Console.WriteLine("-1");
                    }
                    break;
            }

        }
        Console.WriteLine( sb.ToString() );
    }
}