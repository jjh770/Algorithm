using System.Text;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int n = int.Parse(Console.ReadLine());
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int[] input_Sort = input.OrderBy(x => x).Distinct().ToArray();
            Dictionary<int, int> numDic = new Dictionary<int, int>();

            for (int i = 0; i < input_Sort.Length; i++)
                numDic.Add(input_Sort[i], i);

            for (int i = 0; i < input.Length; i++)
                sb.AppendLine($"{numDic[input[i]]}");

            Console.WriteLine(sb);
        }
    }
}