namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] stairs = new int[n + 1];
            int[] count = new int[n + 1];
            Array.Fill(stairs, 0);

            for (int i = 1; i <= n; i++)
                stairs[i] = int.Parse(Console.ReadLine());

            // 기본 값 세팅
            count[1] = stairs[1];
            if (n >= 2)
                count[2] = stairs[1] + stairs[2];

            // 1. 한 계단 또는 두 계단 오를 수 있음
            // 2. 연속된 3개의 계단을 밟을 순 없음
            // 경우의수
            // 2-1 현재-뛰어넘기-도착 (두칸)
            // count[i-2] -> 뛰어넘고(stairs[i-1]포함X) -> 도착 stairs[i]
            // 2-2 현재-도착 (한칸) (두칸은 위에서 포함시킴, 세칸 연속은 불가능)
            // 세칸 연속은 불가능하기 때문에 최소 조건 count[i-3] -> stairs[i-1] -> 도착 stairs[i]
            // 3. 마지막 도착 계단은 무조건 밟아야함
            for (int i = 3; i <= n; i++)
                count[i] = Math.Max(count[i - 2] + stairs[i], count[i - 3] + stairs[i - 1] + stairs[i]);

            Console.WriteLine(count[n]);
        }
    }
}