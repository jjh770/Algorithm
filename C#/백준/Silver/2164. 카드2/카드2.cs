namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> cards = new Queue<int>();

            for (int i = 1; i <= n; i++)
                cards.Enqueue(i);

            while (cards.Count > 1)
            {
                cards.Dequeue();
                cards.Enqueue(cards.Dequeue());
            }
            Console.WriteLine(cards.First());
        }
    }
}