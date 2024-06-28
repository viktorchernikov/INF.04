using System;

public class SortMax {
    public int[] numbers;
    
    public SortMax(int[] nums) {
        numbers = nums;
    }
/********************************************************
* nazwa funkcji: Sort
* autor: Viktor Chernikov
* ****************************************************/
    public void Sort() {
        int n = numbers.Length;
        for(int i = 0; i < n - 1; i++) {
            for (int j = 0; j < n - i - 1; j++) {
                if (numbers[j] < numbers[j + 1]) {
                    int b = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = b;
                }
            }
        }
    }
/********************************************************
* nazwa funkcji: GetMax
* wartość zwracana: int – zwraca wartosc najwiekszej liczby znajdujacej sie w tablicy liczb calkowitych tego obiektu SortMax
* autor: Viktor Chernikov
* ****************************************************/
    private int GetMax() {
        int max = numbers[0];
        for (int i = 1; i < numbers.Length; i++) {
            int num = numbers[i];
            if (num > max) {
                max = num;
            }
        }
        return max;
    }
    public static SortMax Create(int count) {
        Console.WriteLine($"Podaj {count} liczb.");
        int[] nums = new int[count];
        for (int i = 0; i < count; i++) {
            Console.Write($"{i + 1}: ");
            int num = int.Parse(Console.ReadLine());
            nums[i] = num;
        }
        return new SortMax(nums);
    }
    public void Print() {
        Console.WriteLine("Liczby: ");
        foreach (int num in numbers) {
            Console.Write($"{num} ");
        }
        Console.WriteLine();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        SortMax sm = SortMax.Create(10);
        sm.Sort();
        sm.Print();
    }
}