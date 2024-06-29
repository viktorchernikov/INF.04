using System;
					
public class Program
{
	public static void WypiszLiczby(int[] lista) 
	{
		Console.Write("Tablica: {0}", lista[0]);
		for (int i = 1; i < lista.Length; i++) {
			Console.Write(", {0}", lista[i]);
		}
		Console.WriteLine();
	}
	public static int PobierzWartosc() 
	{
		return int.Parse(Console.ReadLine());
	}
	public static void Wypelnij(int[] lista, int ilosc) 
	{
		Random rnd = new Random();
		for (int i = 0; i < ilosc; i++) {
			lista[i] = rnd.Next(1, 100);
		}
	}
    // **********************************************
    // nazwa funkcji:          Szukaj
    // argumenty:               lista - tablica do przeszukania
    //                                     wartosc - jest to wartosc do wyszukania
    // typ zwracany:           int, zwraca indeks znalezionego elementu, jesli nie znaleziono to zwroci rozmiar tablicy.
    // informacje:               Jest to funkcja szukajaca element o podanej wartosci w tablicy
    // autor:                         Viktor Chernikov
    // **********************************************
	public static int Szukaj(int[] lista, int wartosc) 
	{
		int n = lista.Length;
		Array.Resize<int>(ref lista, n + 1);
		lista[n] = wartosc;
		int indeks = n;
		for (int i = 0; i < n; i++) {
			if (lista[i] == wartosc) {
				indeks = i;
				break;
			}
		}
		Array.Resize<int>(ref lista, n);
		return indeks;
	}	
	public static void Main()
	{
		int ilosc = 50;
		int[] lista = new int[ilosc];
		Wypelnij(lista, ilosc);
		Console.Write("Podaj wartosc do wyszukania: ");
		int wartosc = PobierzWartosc();
		int indeks = Szukaj(lista, wartosc);
		WypiszLiczby(lista);
		if (indeks == lista.Length) {
			Console.WriteLine("Nie znaleziono elementu o podanej wartosci!");
		}
		else {
			Console.WriteLine("Indeks elementu o szukanej wartosci: {0}", indeks);
		}
	}
}