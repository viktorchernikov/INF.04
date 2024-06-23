public static class Program
{
    public static void Fill(int[] nums, int max = 100)
    {
        for (int i = 0; i < nums.Length; i++) 
        {
            nums[i] = new Random().Next(0, max);
        }
    }
    public static void Sort(int[] nums)
    {
        bool flag;

        for(int i = 0; i < nums.Length; i++)
        {
            flag = false;
            for (int j = 0; j < nums.Length - i - 1; j++)
            {
                if (nums[j] > nums[j + 1])
                {
                    int buff = nums[j];
                    nums[j] = nums[j + 1];
                    nums[j + 1] = buff;
                    flag = true;
                }
            }
            if (!flag)
            {
                break;
            }
        }
    }
    public static void Print(int[] nums)
    {
        Console.Write("Wynik sortowania bąbelkowego: \n{0}", nums[0]);
        for (int i = 1; i < nums.Length; i++) 
        {
            Console.Write(", {0}", nums[i]);
        }
    }
    public static void Main(string[] args)
    {
        int[] nums = new int[100];

        Fill(nums, 100);
        Sort(nums);
        Print(nums);
    }
}