class Algorithm
{
    static void Main()
    {
        int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int n = input[0], m = input[1];
        int count = 0;
        List<string> names = new List<string>();

        Dictionary<string, int> dictL = new Dictionary<string, int>();
        Dictionary<string, int> dictS = new Dictionary<string, int>();

        for (int i = 0; i < n; i++)
        {
            string name = Console.ReadLine();
            dictL[name] = 1;
        }

        for (int i = 0; i < m; i++)
        {
            string name = Console.ReadLine();
            dictS[name] = 1;
        }

        foreach (var name in dictL)
            if (dictS.ContainsKey(name.Key))
                names.Add(name.Key);

        names.Sort();
        Console.WriteLine(names.Count);
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}