import java.lang.Math;

public class eratostenes
{
    static final int n = 100;
    
    // *******************************************************
    // nazwa funkcji:       fill
    // parametry wejściowe: nums - Tablica która ma zostać wypełniona
    // wartość zwracana:    null - Ta funkcja nie zwraca żadnej wartości
    // informacje:          Wypełnia tablicę wartościami z przedziału liczb całkowitych <2:n>
    // autor:               Viktor Chernikov
    // *******************************************************
    public static void fill(int[] nums)
    {
        for (int i = 0; i < n - 1; i++)
        {
            nums[i] = i + 2;
        }
    }
    public static void main(String[] args) 
    {
        int[] nums = new int[n - 1];
        int sqrtn = (int)Math.sqrt(n);

        fill(nums);

        System.out.println("Liczby pierwsze w przedziale 2.." + n + " (n = " + n + "):");
        for (int i = 2; i <= sqrtn; i++)
        {
            if (nums[i - 2] != 0)
            {
                System.out.print(nums[i - 2] + ", ");
                for (int j = 2; j * i <= n; j++)
                {
                    nums[i * j - 2] = 0;
                }
            }
        }
        if (nums[sqrtn - 1] != 0)
        {
            System.out.print(nums[sqrtn - 1]);
        }
        for (int k = sqrtn; k < n - 1; k++)
        {
            if (nums[k] != 0)
            {
                System.out.print(", " + nums[k]);
            }
        }
    }
}