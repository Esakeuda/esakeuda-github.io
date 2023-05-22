using System;

class Merkkijono
{
    static void Main(string[] args)
    {
        Console.WriteLine("Anna jokin sana tai lause, niin ohjelma tekee sille temppuja");
        string merkkijono = Console.ReadLine();

        Console.WriteLine("Alkuperäinen merkkijono:");
        Console.WriteLine(merkkijono);

        Console.WriteLine("Harvasti:");
        TulostaHarvasti(merkkijono);

        Console.WriteLine("Takaperin:");
        TulostaTakaperin(merkkijono);
    }

    static void TulostaHarvasti(string merkkijono)
    {
        if (merkkijono == null)
        {
            Console.WriteLine("Merkkijono on null");
            return;
        }

        int pituus = merkkijono.Length;

        for (int i = 0; i < pituus; i++)
        {
            Console.Write(merkkijono[i]);

            // Lisätään isompi väli tulostuksen välille
            Console.Write("  ");
        }

        Console.WriteLine();
    }

    static void TulostaTakaperin(string merkkijono)
    {
        if (merkkijono == null)
        {
            Console.WriteLine("Merkkijono on null");
            return;
        }

        int pituus = merkkijono.Length;

        for (int i = pituus - 1; i >= 0; i--)
        {
            Console.Write(merkkijono[i]);
        }

        Console.WriteLine();
    }
}
