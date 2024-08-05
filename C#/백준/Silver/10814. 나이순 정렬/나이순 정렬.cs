namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<(int, string)> person = new List<(int, string)>();

            for (int i = 0; i < N; i++)
            {
                string[] data = Console.ReadLine().Split();
                person.Add((int.Parse(data[0]), data[1]));
            }

            var sortList = person.OrderBy(x => x.Item1).ToList();

            for (int i = 0; i < N; i++)
                Console.WriteLine(sortList[i].Item1 + " " + sortList[i].Item2);
        }
    }
}