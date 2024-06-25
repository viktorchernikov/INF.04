public class Euklides
{
    // **********************************************
    // nazwa funkcji:       FindNwd
    // opis funkcji:        Szuka największą wspólną wielokrotność na podstawie algorytmu Euklidesa.
    // parametry:           a - pierwsza liczba całkowita dodatnia
    //                      b - druga liczba całkowita dodatnia
    // zwracany typ i opis: Największa wspólną wielokrotność dla dwóch liczb. Zwracana wartość jest liczbą dodatnią całkowitą.
    // autor:               Viktor Chernikov
    // **********************************************
    public static uint FindNwd(uint a, uint b)
    {
        while (a != b)
        {
            if (a > b)
            {
                a -= b;
            }
            else
            {
                b -= a;
            }
        }
        return a;
    }
    public static void Main(string[] args)
    {
        try
        {
            uint a, b;
            Console.Write("Wprowadź a: ");
            a = uint.Parse(Console.ReadLine());
            Console.Write("Wprowadź b: f");
            b = uint.Parse(Console.ReadLine());
            Console.WriteLine("Największa wspólna wielokrotność: {0}", FindNwd(a, b));
        }
        catch
        {
            Console.WriteLine("Podana wartość nie jest liczbą dodatnią całkowitą!");
        }
    }
}