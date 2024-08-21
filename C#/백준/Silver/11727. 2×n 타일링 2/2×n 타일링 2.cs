namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = new int[1001];

            input[0] = 1;
            input[1] = 3;
            input[2] = 5;

            for (int i = 3; i < input.Length; i++)
                input[i] = (input[i - 1] + input[i - 2] * 2) % 10007;

            Console.WriteLine(input[n - 1]);
        }
    }
}