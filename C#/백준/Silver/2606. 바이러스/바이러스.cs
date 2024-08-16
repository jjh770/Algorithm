namespace Exam
{
    class Program
    {
        static int n, m;
        static int count;
        static public int[,] map = new int[101, 101];
        static public bool[] visited = new bool[101];
        static public Queue<int> queue = new Queue<int>();

        static void BFS()
        {
            queue.Enqueue(1);
            visited[1] = true;

            int start;

            while (queue.Count != 0)
            {
                start = queue.Dequeue();
                count++;

                for (int i = 1; i <= n; i++)
                {
                    if (map[start, i] == 1 && visited[i] == false)
                    {
                        queue.Enqueue(i);
                        visited[i] = true;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                map[inputArr[0], inputArr[1]] = 1;
                map[inputArr[1], inputArr[0]] = 1;
            }

            Array.Fill(visited, false);
            BFS();
            Console.WriteLine(count - 1);
        }
    }
}