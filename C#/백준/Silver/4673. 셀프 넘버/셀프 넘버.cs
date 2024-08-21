namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10000];
            for (int i = 1; i < 10000; i++)
                nums[i] = i;
            foreach (int num in nums)
                if (nums.Contains(Generate(num)) && (Generate(num) < 10000))
                    nums = nums.Where(x => x != Generate(num)).ToArray();

            foreach(int num in nums)
                Console.WriteLine(num);
        }

        static int Generate(int num)
        {
            int rem = num;
            while (num != 0)
            {
                rem += num % 10;
                num = num / 10;
            }
            return rem;
        }
    }
}