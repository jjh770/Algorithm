namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[] triangle = new long[101];
            triangle[0] = 1; // 1
            triangle[1] = 1; // 2
            triangle[2] = 1; // 3
            triangle[3] = 2; // 4
            triangle[4] = 2; // 5

            for (int i = 5; i <  triangle.Length; i++)
                triangle[i] = triangle[i - 1] + triangle[i - 5];

            for (int i = 0; i < n; i++)
            {
                int k = int.Parse(Console.ReadLine());
                Console.WriteLine(triangle[k - 1]);
            }
        }
    }
}