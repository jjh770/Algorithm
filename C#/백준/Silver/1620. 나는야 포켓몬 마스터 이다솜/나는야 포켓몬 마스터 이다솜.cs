using Microsoft.VisualBasic;
using System.Text;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = input[0], m = input[1];
            Dictionary<string, int> pokemon = new Dictionary<string, int>();
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= n; i++)
                pokemon.Add(Console.ReadLine().ToString(), i);

            var keys = new List<string>(pokemon.Keys);

            for (int i = 0; i < m; i++)
            {
                var div = Console.ReadLine();

                if (Information.IsNumeric(div))
                    sb.AppendLine(keys[int.Parse(div) - 1]);
                else
                    sb.AppendLine(pokemon[div].ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}