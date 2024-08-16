namespace Exam
{
    class Program
    {
        static public int countOne = 0, countZero = 0;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] fibo = new int[41, 2];
            fibo[0, 0] = 1;
            fibo[1, 1] = 1;
            for (int i = 2; i < 41; i++)
            {
                fibo[i, 0] = fibo[i - 1, 0] + fibo[i - 2, 0];
                fibo[i, 1] = fibo[i - 1, 1] + fibo[i - 2, 1];
            }

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine($"{fibo[num, 0]} {fibo[num, 1]}");
            }
        }
    }
}