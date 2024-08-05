using System.Text;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;
            int[] nums = new int[n];
            //List<int> nums = new List<int>();

            for (int i = 0; i < n; i++)
            {
                if (int.TryParse(Console.ReadLine(), out num) == false)
                    return;
                nums[i] = num;
            }

            Array.Sort(nums);
            //SelectionSort(nums);

            StringBuilder sb = new StringBuilder(string.Join("\n", nums));

            Console.WriteLine(sb);

            //foreach (int i in nums)
            //    Console.WriteLine(i);
        }

        static void InsertSort(int[] nums)
        {
            // 배열의 두번째 값부터 비교 시작
            for (int i = 1; i < nums.Length; i++)
            {
                // 현재 위치 기준 다음 요소
                int key = nums[i];
                // 현재 위치 요소
                int j = i - 1;
                // 정렬된 부분의 요소들을 오른쪽으로 이동
                while (j >= 0 && nums[j] > key)
                {
                    nums[j + 1] = nums[j];
                    j--;
                }
                // 현재 요소를 삽입
                nums[j + 1] = key;
            }
        }

        static void BubbleSort(int[] nums)
        {
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; i++)
                {
                    if (nums[i] < nums[j])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
        }

        static void SelectionSort(int[] nums)
        {
            int n = nums.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (nums[j] < nums[min_idx])
                        min_idx = j;
                }
                int temp = nums[min_idx];
                nums[min_idx] = nums[i];
                nums[i] = temp;
            }
        }

    }
}