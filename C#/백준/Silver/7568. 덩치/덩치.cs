namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] height = new int[n], weight = new int[n];
            int rank = 0;

            for (int i = 0; i < n; i++)
            {
                string person = Console.ReadLine();
                height[i] = int.Parse(person.Split()[0]);
                weight[i] = int.Parse(person.Split()[1]);
            }

            for (int i = 0; i < n; i++)
            {
                rank = 0;
                for (int j = 0; j < n; j++)
                {
                    if (height[i] < height[j] && weight[i] < weight[j])
                        rank++;
                }
                Console.Write(rank + 1 + " ");
            }
        }
    }
}