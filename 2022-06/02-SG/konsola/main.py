class Osoba:
    liczba = 0
    def __init__(self, id = 0, imie = ""):
        self.id = id
        self.imie = imie
        Osoba.liczba += 1
    @staticmethod
    def kopiuj(osoba):
        return Osoba(osoba.id, osoba.imie)
    
    def wypisz_imie(self, inneImie = ""):
        if self.imie == "" or self.imie == None:
            print("Brak danych")
        else:
            print(f"Czesc {inneImie}, mam na imie {self.imie}")


#test
print(f"Liczba zarejestrowanych osob to {Osoba.liczba}")

o1 = Osoba()

imie_osoby = input("Wpisz imie: ")
id_osoby = int(input("Wpisz id: "))
o2 = Osoba(id_osoby, imie_osoby)

o3 = Osoba.kopiuj(o2)

o1.wypisz_imie("Jan")
o2.wypisz_imie("Jan")
o3.wypisz_imie("Jan")

print(f"Liczba zarejestrowanych osob to {Osoba.liczba}")