#include <iostream>

const int n = 100;

// *******************************************************
// nazwa funkcji:       fill
// parametry wejściowe: nums - Tablica która ma zostać wypełniona
// wartość zwracana:    null - Ta funkcja nie zwraca żadnej wartości
// informacje:          Wypełnia tablicę wartościami z przedziału liczb całkowitych <2:n>
// autor:               Viktor Chernikov
// *******************************************************
void fill(int* nums)
{
    for (int i = 0; i < n - 1; ++i)
    {
        nums[i] = i + 2;
    }
}
int main()
{
    int nums[n - 1];
    int sqrtn = sqrt(n);

    fill(nums);

    std::cout << "Liczby pierwsze w przedziale 2.." << n << " (n = " << n << "):\n";
    for (int i = 2; i <= sqrtn; ++i)
    {
        if (nums[i - 2] != 0)
        {
            std::cout << nums[i - 2] << ", ";
            for (int j = 2; i * j <= n; ++j)
            {
                nums[i * j - 2] = 0;
            }
        }
    }
    if (nums[sqrtn - 1] != 0)
    {
        std::cout << nums[sqrtn - 1];
    }
    for (int k = sqrtn; k < n - 1; ++k)
    {
        if (nums[k] != 0)
        {
            std::cout << ", " << nums[k];
        }
    }

    return 0;
}