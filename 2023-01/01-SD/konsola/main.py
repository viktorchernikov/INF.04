#*****************************************************
#    klasa:  Notatka
#    opis:    Jest to klasa reprezentujaca soba notatke
#    pola:   licznik - prechowuje liczbe wszystkich istniejacych notatek
#                identyfikator - unikatowy identyfikator tej notatki
#                tytul - pole przechowujace tytul tej notatki
#                tresc - pole przechowjace tresc tej notatki
#    autor: Viktor Chernikov
#* ****************************************************
class Notatka:
    licznik = 0
    def __init__(self, tytul, tresc):
        self.__tytul = tytul
        self.__tresc = tresc
        Notatka.licznik += 1
        self.__identyfikator = Notatka.licznik
    def wyswietl(self):
        print(f"Tytul: {self.__tytul}, tresc: {self.__tresc}")
    def diagnostyka(self):
        print(f"id:{self.__identyfikator};tytul:{self.__tytul};tresc:{self.__tresc};licznik:{Notatka.licznik}")

n1 = Notatka("Tytul", "Tresc")
n2 = Notatka("Lorem", "Lorem ipsum dolor mi")

print("Notatka :")
n1.wyswietl()
n1.diagnostyka()
print("\nNotatka 2:")
n2.wyswietl()
n2.diagnostyka()