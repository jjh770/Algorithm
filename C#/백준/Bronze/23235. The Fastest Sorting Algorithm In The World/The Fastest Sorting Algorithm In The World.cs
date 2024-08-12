namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;

            while (true)
            {
                cnt++;
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if (input[0] == 0)
                    return;

                Console.WriteLine("Case " + cnt + ": Sorting... done!");

            }
        }
    }
}