using System;

namespace Aplikacja12
{
    public class MathHelper
    {
        public static double ObliczSrednia(int[] tablica)
        {
            if (tablica == null || tablica.Length == 0)
            {
                throw new ArgumentException("Tablica jest pusta lub niepoprawna.");
            }

            int suma = 0;
            foreach (int liczba in tablica)
            {
                suma += liczba;
            }

            double sredniaNowa = (double)suma / tablica.Length;
            return sredniaNowa;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] tablicaLiczb = { 1, 2, 3, 4, 5 };
            double sredniaNowa = MathHelper.ObliczSrednia(tablicaLiczb);
            Console.WriteLine("Średnia: " + sredniaNowa);
        }
    }



}