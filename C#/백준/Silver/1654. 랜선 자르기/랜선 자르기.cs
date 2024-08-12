namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int k = input[0], n = input[1];
            int[] line = new int[k];

            long maxLen = 0, start = 1;

            for (int i = 0; i < k; i++)
            {
                line[i] = int.Parse(Console.ReadLine());
                if (line[i] > maxLen)
                    maxLen = line[i];
            }

            while (start <= maxLen)
            {
                long mid = (maxLen + start) / 2;
                long cnt = 0;

                foreach (int l in line)
                    cnt += l / mid;
                if (cnt >= n)
                    start = mid + 1;
                else
                    maxLen = mid - 1;
            }
            Console.WriteLine(maxLen);
        }
    }
}