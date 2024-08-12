using System.Numerics;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] input = Array.ConvertAll(Console.ReadLine().Split(), BigInteger.Parse);
            Console.WriteLine(input[0] + input[1]);
        }
    }
}