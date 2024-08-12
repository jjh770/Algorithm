namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0, sqrSum = 0, cubeSum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
                cubeSum += int.Parse(Math.Pow(i, 3).ToString());
            }

            sqrSum += int.Parse(Math.Pow(sum, 2).ToString());

            Console.WriteLine(sum);
            Console.WriteLine(sqrSum);
            Console.WriteLine(cubeSum);
        }
    }
}