namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int m = input[0], seed = input[1], x1 = input[2], x2 = input[3];
            int a = 0, c = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if ((i * seed + j) % m == input[2] && (i * input[2] + j) % m == input[3])
                    {
                        a = i;
                        c = j;
                        break;
                    }
                }
                if (a != 0 && c != 0)
                    break;
            }
            Console.WriteLine(a + " " + c);
        }
    }
}