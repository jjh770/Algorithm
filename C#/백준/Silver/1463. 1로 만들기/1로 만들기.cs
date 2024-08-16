namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = new int[n + 1];
            Array.Fill(input, 0);

            for (int i = 2; i <= n; i++)
            {
                input[i] = input[i - 1] + 1;
                if (i % 3 == 0)
                    input[i] = Math.Min(input[i], input[i / 3] + 1);
                if (i % 2 == 0)
                    input[i] = Math.Min(input[i], input[i / 2] + 1);
            }
            Console.WriteLine(input[n]);
        }
    }
}