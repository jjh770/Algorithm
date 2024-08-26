using System.Text;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int[] countNum = new int[20000001];

            int n = int.Parse(Console.ReadLine());
            int[] inputN = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            foreach(int i in inputN)
            {
                countNum[i + 10000000]++;
            }

            int m = int.Parse(Console.ReadLine());
            int[] inputM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            foreach (int i in inputM)
            {
                if (countNum[i + 10000000] == 1)
                    sb.Append(1 + " ");
                else
                    sb.Append(0 + " ");
            }
            Console.WriteLine(sb);
        }
    }
}