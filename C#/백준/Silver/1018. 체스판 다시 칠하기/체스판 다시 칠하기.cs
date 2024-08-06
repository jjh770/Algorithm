namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = inputs[0], m = inputs[1];
            string[] board = new string[n];
            int res = 64;

            for (int i = 0; i < n; i++)
                board[i] = Console.ReadLine();

            for (int i = 0; i <= n - 8; i++)
            {
                for (int j = 0; j <= m - 8; j++)
                {
                    int case1 = 0, case2 = 0;
                    for (int k = i; k < i + 8; k++)
                    {
                        for (int l = j; l < j + 8; l++)
                        {
                            if ((k + l) % 2 == 0)
                            {
                                if (board[k][l] != 'W')
                                    case1++;
                                if (board[k][l] != 'B')
                                    case2++;
                            }
                            else
                            {
                                if (board[k][l] != 'W')
                                    case2++;
                                if (board[k][l] != 'B')
                                    case1++;
                            }
                        }
                    }
                    res = Math.Min(res, Math.Min(case1, case2));
                }
            }
            Console.WriteLine(res);
        }
    }
}