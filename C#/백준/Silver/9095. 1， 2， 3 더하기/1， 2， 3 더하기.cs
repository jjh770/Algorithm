namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] sum = new int[12];

            sum[1] = 1;
            sum[2] = 2;
            sum[3] = 4;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                for (int j = 4; j <= num + 1; j++)
                    sum[j] = sum[j - 3] + sum[j - 2] + sum[j - 1];
                Console.WriteLine(sum[num]);
            }
        }
    }
}