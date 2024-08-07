namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string res = "YES";
                string vps = Console.ReadLine();
                int count = 0;

                for (int j = 0; j < vps.Length; j++)
                {
                    if (vps[j] == '(')
                        count++;
                    else 
                        count--;
                    if (count < 0)
                    {
                        res = "NO";
                        break;
                    }
                }

                if (count != 0)
                    res = "NO";
                Console.WriteLine(res);
            }
        }
    }
}