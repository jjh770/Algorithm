using System.Text;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                switch (input[0])
                {
                    case "push":
                        queue.Enqueue(int.Parse(input[1]));
                        break;

                    case "pop":
                        if (queue.Count > 0)
                            sb.AppendLine(queue.Dequeue().ToString());
                        else if (queue.Count == 0)
                            sb.AppendLine("-1");
                        break;

                    case "size":
                        sb.AppendLine(queue.Count.ToString());
                        break;

                    case "empty":
                        if (queue.Count > 0)
                            sb.AppendLine("0");
                        else if (queue.Count == 0)
                            sb.AppendLine("1");
                        break;

                    case "front":
                        if (queue.Count > 0)
                            sb.AppendLine(queue.First().ToString());
                        else if (queue.Count == 0)
                            sb.AppendLine("-1");
                        break;

                    case "back":
                        if (queue.Count > 0)
                            sb.AppendLine(queue.Last().ToString());
                        else if (queue.Count == 0)
                            sb.AppendLine("-1");
                        break;

                }
            }
            Console.WriteLine(sb);
            
        }
    }
}
