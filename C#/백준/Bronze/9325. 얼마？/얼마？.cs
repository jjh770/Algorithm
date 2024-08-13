namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                int car = int.Parse(Console.ReadLine());
                int optionCnt = int.Parse(Console.ReadLine());
                for (int j = 0; j < optionCnt; j++)
                {
                    int[] option = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                    car += option[0] * option[1];
                }
                Console.WriteLine(car);
            }
        }
    }
}