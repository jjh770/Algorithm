namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input.Length == 1 && input[0] == '.')
                    return;
                input = input.Replace(" ", string.Empty);
                bool res = true;
                
                Stack<char> stack = new Stack<char>();
                
                for (int i = 0; i < input.Length; i++)
                {
                    switch(input[i])
                    {
                        case '(':
                            stack.Push(input[i]);
                            break;
                        case ')':
                            if (stack.Count == 0)
                                res = false;
                            else if (stack.Pop() != '(')
                            {
                                res = false;
                                break;
                            }
                            break;
                        case '[':
                            stack.Push(input[i]);
                            break;
                        case ']':
                            if (stack.Count == 0)
                                res = false;
                            else if (stack.Pop() != '[')
                            {
                                res = false;
                                break;
                            }
                            break;
                    }
                }
                if (res && stack.Count == 0)
                    Console.WriteLine("yes");
                else
                    Console.WriteLine("no");
            }
        }
    }
}