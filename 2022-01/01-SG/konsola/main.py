class SortMax:
    def __init__(self, nums):
        self.nums = nums
    # ********************************************************
    # * nazwa funkcji: sort
    # * autor: Viktor Chernikov
    # *****************************************************
    def sort(self):
        r = len(self.nums)
        i = 0
        while i < r:
            j = i + 1
            while j < r:
                if self.nums[j] > self.nums[i]:
                    buff = self.nums[j]
                    self.nums[j] = self.nums[i]
                    self.nums[i] = buff
                j += 1
            i += 1
    # ********************************************************
    # * nazwa funkcji: __get_max
    # * wartość zwracana: int – zwraca wartosc najwiekszej liczby znajdujacej sie w tablicy liczb calkowitych tego obiektu SortMax
    # * autor: Viktor Chernikov
    # *****************************************************
    def __get_max(self):
        max_num = self.nums[0]
        for el in self.nums:
            if el > max_num:
                max_num = el
        return max_num
    @staticmethod
    def create(count):
        print(f"Podaj {count} liczb.")
        nums = []
        for i in range(count):
            num = int(input(f"{i + 1}: "))
            nums.append(num)
        return SortMax(nums)
    def print(self):
        print(f"Liczby:\n{self.nums}")

sm = SortMax.create(10)
sm.sort()
sm.print()