namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = input[0], k = input[1], count = 0;
            int[] money = new int[n];

            for (int i = 0; i < n; i++)
                money[i] = int.Parse(Console.ReadLine());

            Array.Sort(money, (item1, item2) => item2.CompareTo(item1));

            for (int i = 0; i < money.Length; i++)
            {
                count += k / money[i];
                k %= money[i];
            }
            if (k == 0)
                Console.WriteLine(count);
        }
    }
}