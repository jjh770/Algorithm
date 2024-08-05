using System.Text;

namespace Exam
{
    class Program
    {
        static int n, m;
        static int[] array = new int[9]; //수열의 조합 저장
        static bool[] visited = new bool[9]; // 특정 숫자가 이미 사용되었는지 판별
        static StringBuilder sb = new StringBuilder();


        static void DFS(int arr_idx)
        {
            if (arr_idx == m)
            {
                for (int i = 0; i < m; i++)
                    sb.Append(array[i]).Append(' ');
                    //Console.Write(array[i] + " ");
                sb.AppendLine();
                //Console.WriteLine();
                return;
            }
            for (int i = 1; i <= n; i++)
            {
                if (!visited[i])
                {
                    visited[i] = true;
                    array[arr_idx] = i;
                    DFS(arr_idx + 1);
                    visited[i] = false;
                }
            }
        }

        static void Main(string[] args)
        {
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            //int n = nums[0], m = nums[1];

            n = nums[0];
            m = nums[1];

            DFS(0);

            Console.Write(sb.ToString());
            
        }
    }
}