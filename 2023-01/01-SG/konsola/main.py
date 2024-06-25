# **********************************************
# nazwa funkcji:       findNwd
# opis funkcji:        Szuka największą wspólną wielokrotność na podstawie algorytmu Euklidesa.
# parametry:           a - pierwsza liczba całkowita dodatnia
#                      b - druga liczba całkowita dodatnia
# zwracany typ i opis: Największa wspólną wielokrotność dla dwóch liczb. Zwracana wartość jest liczbą dodatnią całkowitą.
# autor:               Viktor Chernikov
# **********************************************
def findNwd(a, b):
    while a != b:
        if a > b:
            a -= b
        else:
            b -= a
    return a

try:
    a = int(input("Wprowadź a: "))
    if a < 1:
        raise
    b = int(input("Wprowadź b: "))
    if b < 1:
        raise
    print("Największa wspólna wielokrotność: " + str(findNwd(a, b)))
except:
    print("Podana wartość nie jest liczbą dodatnią całkowitą!")
    exit(420)