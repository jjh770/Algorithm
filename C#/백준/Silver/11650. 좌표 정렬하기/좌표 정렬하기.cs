using System.Text;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var points = new Tuple<int, int>[n];

            for (int i = 0; i < n; i++)
            {
                var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                points[i] = Tuple.Create(input[0], input[1]);
            }

            Array.Sort(points);

            StringBuilder sb = new StringBuilder();

            foreach (var item in points)
                sb.Append($"{item.Item1} {item.Item2}\n");
            Console.Write(sb);
        }
    }
}
