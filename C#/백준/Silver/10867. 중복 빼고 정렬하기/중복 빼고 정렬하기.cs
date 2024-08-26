namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            input = input.Distinct().OrderBy(x => x).ToArray();

            foreach (int x in input)
                Console.Write(x + " ");
        }
    }
}