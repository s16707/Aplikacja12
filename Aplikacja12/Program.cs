public class MathHelper
{
    public static int ZnajdzMaksimum(int[] tablica)
    {
        if (tablica == null || tablica.Length == 0)
        {
            throw new ArgumentException("Tablica jest pusta lub niepoprawna.");
        }

        int maksimum = tablica[0]; // Zakładamy, że pierwszy element jest maksimum

        // Iterujemy przez pozostałe elementy i aktualizujemy maksimum, jeśli jest większe
        for (int i = 1; i < tablica.Length; i++)
        {
            if (tablica[i] > maksimum)
            {
                maksimum = tablica[i];
            }
        }

        return maksimum;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] tablicaLiczb = { 1, 5, 3, 8, 2 };
        int maksimum = MathHelper.ZnajdzMaksimum(tablicaLiczb);
        Console.WriteLine("Maksimum: " + maksimum);
    }
}