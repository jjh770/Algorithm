namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = input[0], m = input[1];

            int[] stress = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int level = 0, count = 0;

            foreach(int day in stress)
            {
                level += day;
                if (level <= 0)
                    level = 0;
                if (level >= m)
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}