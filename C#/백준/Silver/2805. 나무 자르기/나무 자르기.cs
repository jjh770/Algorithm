namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = input[0], m = input[1];
            int[] height = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int start = 0, end = height.Max();

            while (start <= end)
            {
                int mid = (start + end) / 2;
                long wood = 0;
                foreach (int h in height)
                    if (h > mid)
                        wood += h - mid;

                if (wood >= m)
                    start = mid + 1;
                else
                    end = mid - 1;
            }
            Console.WriteLine(end);
        }
    }
}