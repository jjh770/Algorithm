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
                string[] addrPswd = Console.ReadLine().Split(' ');
                string addr = addrPswd[0];
                string pswd = addrPswd[1];
                addrDic.Add(addr, pswd);
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