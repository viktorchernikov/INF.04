public static class Program
{
    const int n = 100;
    
    // *******************************************************
    // nazwa funkcji:       Fill
    // parametry wejściowe: nums - Tablica która ma zostać wypełniona
    // wartość zwracana:    null - Ta funkcja nie zwraca żadnej wartości
    // informacje:          Wypełnia tablicę wartościami z przedziału liczb całkowitych <2:n>
    // autor:               Viktor Chernikov
    // *******************************************************
    public static void Fill(int[] nums)
    {
        for (int i = 0; i < n - 1; i++)
        {
            nums[i] = i + 2;
        }
    }
    public static void Main(string[] args)
    {
        int[] nums = new int[n - 1];
        int sqrtn = (int)Math.Sqrt(n);

        Fill(nums);

        Console.WriteLine("Liczby pierwsze w przedziale 2..{0} (n = {0}):", n);
        for (int i = 2; i <= sqrtn; i++)
        {
            if (nums[i - 2] != 0)
            {
                Console.Write("{0}, ", nums[i - 2]);
                for (int j = 2; i * j <= n; j++)
                {
                    nums[i * j - 2] = 0;
                }
            }
        }
        if (nums[sqrtn - 1] != 0)
        {
            Console.Write(nums[sqrtn - 1]);
        }
        for (int k = sqrtn; k < n - 1; k++)
        {
            if (nums[k] != 0)
            {
                Console.Write(", {0}", nums[k]);
            }
        }
    }
}