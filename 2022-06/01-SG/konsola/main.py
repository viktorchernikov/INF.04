import random

def pobierz_wartosc():
    return int(input("Podaj wartosc do wyszukania: "))
def wypelnij(lista = [], ilosc = 10):
    for i in range(ilosc):
        lista.append(random.randint(1, 100))
    return lista
# **********************************************
# nazwa funkcji:          szukaj
# argumenty:               lista - tablica do przeszukania
#                                     wartosc - jest to wartosc do wyszukania
# typ zwracany:           int, zwraca indeks znalezionego elementu, jesli nie znaleziono to zwroci rozmiar tablicy.
# informacje:               Jest to funkcja szukajaca element o podanej wartosci w tablicy
# autor:                         Viktor Chernikov
# **********************************************
def szukaj(lista = [], wartosc = 0):
    n = len(lista)
    lista.append(wartosc)
    indeks = 0
    for liczba in lista:
        if liczba == wartosc:
            break
        indeks += 1
    lista.pop()
    return indeks

lista = []
wypelnij(lista, 100)
wartosc = pobierz_wartosc()
indeks = szukaj(lista, wartosc)
print(f"Tablica: {lista}")
if indeks == len(lista):
    print("Nie znaleziono elementu o podanej wartosci!")
else:
    print(f"Indeks elementu o szukanej wartosci: {indeks}")