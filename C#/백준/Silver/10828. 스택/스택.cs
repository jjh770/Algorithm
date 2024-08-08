using System.Text;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                switch (input[0])
                {
                    case "push":
                        stack.Push(int.Parse(input[1]));
                        break;

                    case "pop":
                        if (stack.Count > 0)
                            sb.AppendLine(stack.Pop().ToString());
                        else if (stack.Count == 0)
                            sb.AppendLine("-1");
                        break;

                    case "size":
                        sb.AppendLine(stack.Count.ToString());
                        break;

                    case "empty":
                        if (stack.Count > 0)
                            sb.AppendLine("0");
                        else if (stack.Count == 0)
                            sb.AppendLine("1");
                        break;

                    case "top":
                        if (stack.Count > 0)
                            sb.AppendLine(stack.First().ToString());
                        else if (stack.Count == 0)
                            sb.AppendLine("-1");
                        break;

                }
            }
            Console.WriteLine(sb);
            
        }
    }
}