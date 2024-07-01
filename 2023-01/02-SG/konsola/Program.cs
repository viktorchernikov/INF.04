// ************************************************
// klasa: Notatka 
// opis:  Jest to klasa reprezentująca notatkę zawierającą tytuł oraz tekst notatki.
// pola:  tytul - tytuł notatki
//        tresc - zawartość (treść) notatki
//        identyfikator - unikatowy identyfikator notatki
//        licznik - przechowuje liczbę wszystkich utworzonych notatek
// autor: Viktor Chernikov
// ************************************************
public class Notatka
{
    public Notatka(string tytulNotatki, string trescNotatki)
    {
        licznik++;
        identyfikator = licznik;
        tytul = tytulNotatki;
        tresc = trescNotatki;
    }

    public void Wyswietl()
    {
        Console.WriteLine("Tytuł notatki: {0}\nTreść notatki: {1}", tytul, tresc);
    }
    public void Diagnozuj()
    {
        Console.WriteLine("Dane diagnostyczne: {0};{1};{2};{3}", licznik, identyfikator, tytul, tresc);
    }

    protected string tytul;
    protected string tresc;
    private int identyfikator;
    private static int licznik = 0;
}

public static class Program
{
    public static void Main(string[] args)
    {
        Notatka notatka1 = new Notatka("Pan Tadeusz", "Jest to ciekawa książka o panu który ma na imię Tadeusz");
        notatka1.Wyswietl();
        notatka1.Diagnozuj();

        Console.WriteLine();

        Notatka notatka2 = new Notatka("Mały Książę", "Opowieść o księciu który kocha róze i znalazł przyjaciela w pustyni");
        notatka2.Wyswietl();
        notatka2.Diagnozuj();
    }
}