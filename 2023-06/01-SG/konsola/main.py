import math

def printc(msg):
    print(msg, end='')
    
# *******************************************************
# nazwa funkcji:       fill
# parametry wejściowe: nums - Tablica która ma zostać wypełniona
# wartość zwracana:    null - Ta funkcja nie zwraca żadnej wartości
# informacje:          Wypełnia tablicę wartościami z przedziału liczb całkowitych <2:n>
# autor:               Viktor Chernikov
# *******************************************************
def fill(nums):
    x = 0
    while x < n - 1:
        nums[x] = x + 2
        x += 1

n = 100
nums = [None] * (n - 1)
sqrtn = int(math.sqrt(n))

fill(nums)
print("Liczby pierwsze w przedziale 2..{0} (n = {0}):".format(n))

i = 2
while i <= sqrtn:
    if nums[i-2] != 0:
        printc("{0}, ".format(nums[i-2]))
        j = 2
        while i*j <= n:
            nums[i*j-2] = 0
            j += 1
    i += 1
    
if nums[sqrtn - 1] != 0:
    printc(nums[sqrtn - 1])

k = sqrtn
while k < n - 1:
    if nums[k] != 0:
        printc(", {0}".format(nums[k]))
    k += 1