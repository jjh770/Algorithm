class Algorithm
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        var minInput = input.OrderBy(x => x);

        int sum = 0, res = 0;

        foreach (var x in minInput)
        {
            sum = sum + x;
            res += sum;
        }
        Console.WriteLine(res);
    }
}