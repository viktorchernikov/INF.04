import random

def fill(arr, max):
    i = 0
    while i < len(arr):
        arr[i] = random.randint(0, max)
        i += 1
def sort(arr):
    i = 0
    while i < len(arr):
        j = 0
        flag = False
        while j < len(arr)-i-1:
            if arr[j] > arr[j+1]:
                buf = arr[j+1]
                arr[j+1] = arr[j]
                arr[j] = buf
                flag = True
            j+=1
        if flag != True:
            break
        i+=1
def printresult(arr):
    print("Wynik sortowania bąbelkowego:")
    print(arr)

nums = [None] * 100
fill(nums, 100)
sort(nums)
printresult(nums)