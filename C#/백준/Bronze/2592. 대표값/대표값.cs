namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] d = new int[1000];
            Array.Fill(d, 0);
            int sum = 0;

            int[] input = new int[10];
            for (int i = 0; i < 10; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
                sum += input[i];
                d[input[i]]++;
            }
            Array.IndexOf(d, d.Max());
            Console.WriteLine(sum / 10);
            Console.WriteLine(Array.IndexOf(d, d.Max()));
        }
    }
}