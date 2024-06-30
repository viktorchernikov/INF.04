using System;

public class Osoba 
{
	public static int liczba = 0;
	private int id;
	private string imie;
	
	public Osoba() {
		id = 0;
		imie = string.Empty;
		liczba++;
	}
	public Osoba(int noweId, string noweImie) {
		id = noweId;
		imie = noweImie;
		liczba++;
	}
	public Osoba(Osoba osoba) {
		id = osoba.id;
		imie = osoba.imie;
		liczba++;
	}
	
	public void WypiszImie(string inneImie) {
		if (string.IsNullOrEmpty(imie)) {
			Console.WriteLine("Brak danych");
		}
		else {
			Console.WriteLine("Czesc {0}, mam na imie {1}", inneImie, imie);
		}
	}
}
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Liczba zarejestrowanych osob to {0}", Osoba.liczba);
		
		Osoba o1 = new Osoba();
		
		Console.Write("Wpisz imie: ");
		string imie = Console.ReadLine();
		Console.Write("Wpisz id: ");
		int id = int.Parse(Console.ReadLine());
		Osoba o2 = new Osoba(id, imie);
		
		Osoba o3 = new Osoba(o2);
		
		o1.WypiszImie("Jan");
		o2.WypiszImie("Jan");
		o3.WypiszImie("Jan");
		
		Console.WriteLine("Liczba zarejestrowanych osob to {0}", Osoba.liczba);
	}
}