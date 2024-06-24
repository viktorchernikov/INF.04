# ******************************************************
# nazwa klasy: film
# pola:        title - przechowuje tytuł filmu
#              rentCount - przechowuje liczbę wynajęć filmu
#              
# metody:      setTitle, None - przypisuje nowy tytuł filmowi
#              getTitle, string - zwraca tytuł filmu
#              rentsIncrease, None - inkrementuje liczbę wynajęć filmu
#              getRentCount, int - zwraca liczbę wynajęc filmu
# informacje:  Jest to klasa reprezentująca typowy film z wypożyczalni. Zawiera w sobie tytuł i licznik wynajęć filmu
# autor:       Viktor Chernikov
# ******************************************************
class film:
    def __init__(self):
        self.title = ""
        self.rentCount = 0

    def setTitle(self, newTitle):
        if len(newTitle) > 20:
            self.title = newTitle[:20]
        else:
            self.title = newTitle
    def getTitle(self):
        return self.title
    def rentsIncrease(self):
        self.rentCount += 1
    def getRentCount(self):
        return self.rentCount

newMovie = film()

print("Utworzono nowy film.\nTytuł filmu: {0}\nLiczba wypożyczeń: {1}\n".format(newMovie.getTitle(), newMovie.getRentCount()))

newMovie.setTitle("Morbius")
print("Ustawiono nowy tytuł filmu: " + newMovie.getTitle())

print("Przed inkrementacją liczbę wypożyczeń: " + str(newMovie.getRentCount()))
newMovie.rentsIncrease()
print("Po inkrementacji liczby wypożyczeń: " + str(newMovie.getRentCount()))