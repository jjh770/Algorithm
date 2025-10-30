using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int input = int.Parse(Console.ReadLine());

        int[] queue = new int[input];
        int front = 0;
        int currentEach = 0;

        for (int i = 0; i < input; i++)
        {
            string[] inputCommand = Console.ReadLine().Split(" ");
            string command = inputCommand[0];

            switch (command)
            {
                case "push":
                    queue[currentEach++] = int.Parse(inputCommand[1]);
                    break;
                case "pop":
                    if (front < currentEach)
                    {
                        sb.Append($"{queue[front++]}\n");
                    }
                    else
                    {
                        sb.Append("-1\n");
                    }
                    break;
                case "size":
                    sb.Append($"{currentEach - front}\n");
                    break;
                case "empty":
                    sb.Append(front == currentEach ? "1\n" : "0\n");
                    break;
                case "front":
                    if (front < currentEach)
                    {
                        sb.Append($"{queue[front]}\n");
                    }
                    else
                    {
                        sb.Append("-1\n");
                    }
                    break;
                case "back":
                    if (front < currentEach)
                    {
                        sb.Append($"{queue[currentEach - 1]}\n");
                    }
                    else
                    {
                        sb.Append("-1\n");
                    }
                    break;
            }
        }
        Console.Write(sb);
    }
}
