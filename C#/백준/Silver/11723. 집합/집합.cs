using System.Text;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> set = new List<int>();
            int m = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split();
                switch (input[0])
                {
                    case "add":
                        add(int.Parse(input[1]));
                        break;
                    case "remove":
                        remove(int.Parse(input[1]));
                        break;
                    case "check":
                        sb.AppendLine(check(int.Parse(input[1])).ToString());
                        break;
                    case "toggle":
                        toggle(int.Parse(input[1]));
                        break;
                    case "all":
                        all();
                        break;
                    case "empty":
                        empty();
                        break;
                }
            }

            Console.WriteLine(sb);

            void add(int i)
            {
                set.Add(i);
            }

            void remove(int i)
            {
                set.Remove(i);
            }

            int check(int i)
            {
                if (set.Contains(i))
                    return 1;
                else
                    return 0;
            }

            void toggle(int i)
            {
                if (set.Contains(i))
                    set.Remove(i);
                else
                    set.Add(i);
            }

            void all()
            {
                set.Clear();
                for (int i = 1; i <= 20; i++)
                    set.Add(i);
            }

            void empty()
            {
                set.Clear();
            }
        }

    }
}