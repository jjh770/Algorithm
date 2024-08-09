namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 5 == 0)
            {
                Console.WriteLine(n / 5);
                return;
            }

            for (int i = 0; i < (n / 3) + 1; i++)
            {
                for (int j = 0; j < (n / 3) + 1; j++)
                {
                    if (i * 3 + j * 5 == n)
                    {
                        Console.WriteLine(i+j);
                        return;
                    }
                }
            }            
            Console.WriteLine("-1");
        
        }
    }
}