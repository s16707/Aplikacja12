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

            double sredniaInna = (double)suma / tablica.Length;
            return sredniaInna;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] tablicaLiczb = { 1, 2, 3, 4, 5 };
            double sredniaInna = MathHelper.ObliczSrednia(tablicaLiczb);
            Console.WriteLine("Średnia: " + sredniaInna);
        }
    }



}