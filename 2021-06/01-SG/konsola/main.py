class SortMax:
    def __init__(self, nums):
        self.numbers = nums

    # ********************************************************
    # * nazwa funkcji: Sort
    # * parametry wejściowe: nums - tablica ktora powinna byc posortowana malejaco
    # * autor: Viktor Chernikov
    # *****************************************************
    @staticmethod
    def sort(nums):
        n = len(nums)
        i = 0
        while i < n - 1:
            j = 0
            while j < n - i - 1:
                if nums[j] < nums[j + 1]:
                    b = nums[j]
                    nums[j] = nums[j + 1]
                    nums[j + 1] = b
                j += 1
            i += 1
    # ********************************************************
    # * nazwa funkcji: GetMax
    # * wartość zwracana: int – zwraca wartosc najwiekszej liczby znajdujacej sie w tablicy liczb calkowitych tego obiektu SortMax
    # * autor: Viktor Chernikov
    # *****************************************************
    def get_max(self):
        max_num = self.numbers[0]
        for i in self.numbers:
            if i > max_num:
                max_num = i
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
        print(f"Liczby:\n{self.numbers}")
        
    
sm = SortMax.create(10)
SortMax.sort(sm.numbers)
sm.print()