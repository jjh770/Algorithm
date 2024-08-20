using System.Text;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = input[0], m = input[1], sum = 0;
            int[] nInput = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] sumArr = new int[n + 1];

            sumArr[0] = nInput[0];

            for (int i = 1; i < n; i++)
                sumArr[i] = sumArr[i - 1] + nInput[i];

            for (int i = 0; i < m; i++)
            {
                int[] mInput = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int mStart = mInput[0], mEnd = mInput[1];

                if (mStart == 1)
                    sum = sumArr[mEnd - 1];
                else
                    sum = sumArr[mEnd - 1] - sumArr[mStart - 2];
                sb.AppendLine(sum.ToString());
                sum = 0;
            }
            Console.WriteLine(sb.ToString());
        }
    }
}