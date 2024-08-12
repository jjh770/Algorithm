using System.Text;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = input[0], m = input[1];

            bool[] isPrime = new bool[m + 1];
            Array.Fill(isPrime, true);
            isPrime[0] = isPrime[1] = false;

            for (int i = 2; i * i <= m; i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j <= m; j += i)
                        isPrime[j] = false;
                }
            }

            StringBuilder sb = new StringBuilder();
            for (int i = n; i <= m; i++)
                if (isPrime[i])
                    sb.AppendLine(i + " ");

            Console.WriteLine(sb.ToString());
        }
    }
}