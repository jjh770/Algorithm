using System.Text;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = input[0], m = input[1];
            Dictionary<string, string> addrDic = new Dictionary<string, string>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string[] addrPswd = Console.ReadLine().Split();
                addrDic.Add(addrPswd[0], addrPswd[1]);
            }

            for (int i = 0; i < m; i++)
            {
                string addr = Console.ReadLine();
                sb.AppendLine(addrDic[addr]);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}