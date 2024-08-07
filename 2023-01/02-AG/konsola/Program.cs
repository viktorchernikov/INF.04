using System;

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
    private static int licznik = 0;
    
    public Notatka(string nowyTytul, string nowaTresc) {
        identyfikator = ++licznik;
        tytul = nowyTytul;
        tresc = nowaTresc;
    }
    
    public void Wyswietl() {
        Console.WriteLine($"Tytul: {tytul}, Tresc: {tresc}");
    }
    public void Diagnostyka() {
        Console.WriteLine($"id:{identyfikator};tytul:{tytul};tresc:{tresc};licznik:{licznik}");
    }
    
    private readonly int identyfikator; 
    protected string tytul;
    protected string tresc;
}
public class Program
{
    public static void Main(string[] args)
    {
        Notatka n1 = new Notatka("Tytul", "Tresc");
        Notatka n2 = new Notatka("Lorem", "Lorem ipsum dolor mi");
        
        Console.WriteLine("Notatka 1:");
        n1.Wyswietl();
        n1.Diagnostyka();
        Console.WriteLine("\nNotatka 2:");
        n2.Wyswietl();
        n2.Diagnostyka();
    }
}