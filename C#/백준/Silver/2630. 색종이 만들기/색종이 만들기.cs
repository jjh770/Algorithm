namespace Exam
{
    class Program
    {
        static int[,] arr;
        static int whiteCnt = 0;
        static int blueCnt = 0;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            arr = new int[n + 1, n + 1];
            for (int i = 0; i < n; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                for (int j = 0; j < n; j++)
                    arr[i, j] = input[j];
            }
            DivConquer(0, 0, n);
            Console.WriteLine(whiteCnt);
            Console.WriteLine(blueCnt);
        }

        static void DivConquer(int row, int col, int size)
        {
            int firstColor = arr[row, col];
            bool isSame = true;
            for (int i = row; i < row + size; i++)
            {
                for (int j = col; j < col + size; j++)
                {
                    if (arr[i, j] != firstColor)
                    {
                        isSame = false;
                        break;
                    }
                }
            }
            if (isSame)
            {
                if (firstColor == 0)
                    whiteCnt++;
                else
                    blueCnt++;
                return;
            }

            int newSize = size / 2;
            DivConquer(row, col, newSize);
            DivConquer(row, col + newSize, newSize);
            DivConquer(row + newSize, col, newSize);
            DivConquer(row + newSize, col + newSize, newSize);
        }
    }
}