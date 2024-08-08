using System.Text;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] empty = new int[20000001];
            int idx = 10000000;

            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int m = int.Parse(Console.ReadLine());
            int[] res = new int[m];
            res = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            for (int i = 0; i < n; i++)
                empty[idx + nums[i]]++;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < m; i++)
                sb.Append(empty[idx + res[i]] + " ");
            Console.WriteLine(sb.ToString());
        }
    }
}