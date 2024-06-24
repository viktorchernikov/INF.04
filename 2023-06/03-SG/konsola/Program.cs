// ******************************************************
// nazwa klasy: Film
// pola:        title - przechowuje tytuł filmu
//              rentCount - przechowuje liczbę wynajęć filmu
//              
// metody:      SetTitle, null - przypisuje nowy tytuł filmowi
//              GetTitle, string - zwraca tytuł filmu
//              RentsIncrease, null - inkrementuje liczbę wynajęć filmu
//              GetRentCount, int - zwraca liczbę wynajęc filmu
// informacje:  Jest to klasa reprezentująca typowy film z wypożyczalni. Zawiera w sobie tytuł i licznik wynajęć filmu
// autor:       Viktor Chernikov
// ******************************************************
public class Film
{
    public Film()
    {
        title = "";
        rentCount = 0;
    }
    
    public string GetTitle()
    {
        return title;
    }
    public void SetTitle(string newTitle) 
    {
        if (newTitle.Length > 20)
        {
            title = newTitle.Remove(20, newTitle.Length - 20);
        }
        else
        {
            title = newTitle;
        }
    }
    public int GetRentCount()
    {
        return rentCount;
    }
    public void RentsIncrease()
    {
        rentCount++;
    }

    private string title;
    private int rentCount;
}
public static class Program
{
    public static void Main(string[] args)
    {
        Film newMovie = new Film();

        Console.WriteLine("Utworzono film.\nTytuł filmu: {0}\nLiczba wypożyczeń: {1}\n", newMovie.GetTitle(), newMovie.GetRentCount());

        newMovie.SetTitle("Morbius");
        Console.WriteLine("Ustawiono nowy tytuł filmu: " + newMovie.GetTitle());

        Console.WriteLine("Przed inkrementacją liczbę wypożyczeń: {0}", newMovie.GetRentCount());
        newMovie.RentsIncrease();
        Console.WriteLine("Po inkrementacji liczby wypożyczeń: {0}", newMovie.GetRentCount());
    }
}