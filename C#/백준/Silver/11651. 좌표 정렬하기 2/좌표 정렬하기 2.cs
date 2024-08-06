using System.Text;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<(int, int)> nums = new List<(int, int)> ();

            for (int i = 0; i < n; i++)
            {
                var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                nums.Add((input[0], input[1]));
            }

            var sortList = nums.OrderBy(x => x.Item2).ThenBy(x => x.Item1);

            StringBuilder sb = new StringBuilder();

            foreach (var item in sortList)
                sb.Append($"{item.Item1} {item.Item2}\n");
            Console.Write(sb);
        }
    }
}