namespace Exam
{
    class Program
    {
        static int[] attack = new int[1000000]; 
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = input[0], h = input[1];
            attack = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int count = 0;
            long attack_Cnt = 0, attack_Sum = 0;

            foreach (int atk in attack)
                attack_Sum += atk;

            if (attack_Sum < h)
            {
                Console.WriteLine(-1);
                return;
            }

            foreach (int atk in attack)
            {
                attack_Cnt += atk;
                count++;
                if (attack_Cnt >= h)
                    break;
            }
            Console.WriteLine(count);
        }
    }
}