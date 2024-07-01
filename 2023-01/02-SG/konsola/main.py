# ************************************************
# klasa: notatka 
# opis:  Jest to klasa reprezentująca notatkę zawierającą tytuł oraz tekst notatki.
# pola:  tytul - tytuł notatki
#        tresc - zawartość (treść) notatki
#        identyfikator - unikatowy identyfikator notatki
#        licznik - przechowuje liczbę wszystkich utworzonych notatek
# autor: Viktor Chernikov
# ************************************************
class notatka:
    licznik = 0
    def __init__(self, tytulNotatki, trescNotatki):
        notatka.licznik += 1
        self.identyfikator = notatka.licznik
        self.tytul = tytulNotatki
        self.tresc = trescNotatki
    def wyswietl(self):
        print("Tytuł notatki: " + self.tytul)
        print("Treść notatki: " + self.tresc)
    def diagnozuj(self):
        print("Dane diagnostyczne: " + str(notatka.licznik) + ";" + str(self.identyfikator) + ";" + self.tytul + ";" + self.tresc)

notatka1 = notatka("Pan Tadeusz", "Jest to ciekawa książka o panu który ma na imię Tadeusz")
notatka1.wyswietl()
notatka1.diagnozuj()
print()
notatka2 = notatka("Mały Książę", "Opowieść o księciu który kocha róze i znalazł przyjaciela w pustyni")
notatka2.wyswietl()
notatka2.diagnozuj()