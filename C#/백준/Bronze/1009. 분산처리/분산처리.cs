namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int a = input[0], b = input[1];
                int res = a;
                b = b % 4 + 4;
                for (int j = 1; j < b; j++)
                    res = (res * a) % 10;
                if (res == 0)
                    res = 10;
                Console.WriteLine(res);
            }
        }
    }
}