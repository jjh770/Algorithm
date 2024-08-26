namespace Exam
{
    class Program
    {
        static List<int>[] graph;
        static bool[] visited;
        static int count;

        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = input[0], m = input[1];

            graph = new List<int>[n + 1];
            visited = new bool[n + 1];
            count = 0;

            for (int i = 1; i <= n; i++)
                graph[i] = new List<int>();

            for (int i = 0; i < m; i++)
            {
                int[] edge = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int u = edge[0];
                int v = edge[1];

                graph[u].Add(v);
                graph[v].Add(u);
            }

            for (int i = 1; i <= n; i++)
            {
                if (!visited[i])
                {
                    count++;
                    dfs(i);
                }
            }
            Console.WriteLine(count);
        }

        static void dfs(int now)
        {
            visited[now] = true;
            foreach(int next in graph[now])
            {
                if (visited[next])
                    continue;
                dfs(next);
            }
        }
    }
}