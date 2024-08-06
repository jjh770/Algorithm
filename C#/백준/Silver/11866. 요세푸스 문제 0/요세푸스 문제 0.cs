using System.Text;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = inputs[0], k = inputs[1];
            bool[] killed = new bool[n];
            List<int> res = new List<int>();
            int count = 0;

            while (true)
            {
                if (res.Count == n)
                    break;
                for (int i = 0; i < n; i++)
                {
                    if (killed[i] == true)
                        continue;
                    count++;

                    if (count == k && killed[i] == false)
                    {
                        killed[i] = true;
                        count = 0;
                        res.Add(i + 1);
                    }
                }

            }
            StringBuilder sb = new StringBuilder();
            sb.Append("<");
            for (int i = 0; i < res.Count; i++)
            {
                sb.Append($"{res[i]}");
                if (i != res.Count - 1)
                    sb.Append(", ");
            }
            sb.Append(">");
            Console.WriteLine(sb);
        }
    }
}