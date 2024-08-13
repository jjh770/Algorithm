namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int w = input[0], h = input[1];
            int rectangle = w + h;
            double rhombus = Math.Sqrt(double.Parse((w * w + h * h).ToString()));
            double res = Math.Round(rectangle - rhombus, 9);
            Console.WriteLine(res);
        }
    }
}