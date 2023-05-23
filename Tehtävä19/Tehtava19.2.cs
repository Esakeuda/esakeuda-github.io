using System;
using System.Collections.Generic;

class Jatkokasittely
{
    static void Main(string[] args)
    {
        Console.WriteLine("Anna jokin sana tai lause, niin ohjelma tekee sille temppuja");
        string merkkijono = Console.ReadLine();

        Console.WriteLine("Alkuperäinen sana tai lause:");
        Console.WriteLine(merkkijono);

        Console.WriteLine("Harvasti:");
        TulostaHarvasti(merkkijono);

        Console.WriteLine("Takaperin:");
        TulostaTakaperin(merkkijono);

        TarkistaA(merkkijono);
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
            Console.Write("   ");
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

    static void TarkistaA(string merkkijono)
    {
        if (merkkijono == null)
        {
            Console.WriteLine("Merkkijono on null");
            return;
        }

        List<int> isoAIndeksit = new List<int>();
        List<char> isoAKirjaimet = new List<char>();
        List<int> pieniAIndeksit = new List<int>();
        List<char> pieniAKirjaimet = new List<char>();

        for (int i = 0; i < merkkijono.Length; i++)
        {
            char kirjain = merkkijono[i];

            if (kirjain == 'A')
            {
                isoAIndeksit.Add(i + 1);
                isoAKirjaimet.Add(kirjain);
            }
            else if (kirjain == 'a')
            {
                pieniAIndeksit.Add(i + 1);
                pieniAKirjaimet.Add(kirjain);
            }
        }

        if (isoAIndeksit.Count == 0 && pieniAIndeksit.Count == 0)
        {
            Console.WriteLine("Eipä löytynyt A kirjainta tästä sanasta!");
            return;
        }

        isoAIndeksit.Sort();
        isoAKirjaimet.Sort();
        pieniAIndeksit.Sort();
        pieniAKirjaimet.Sort();

        for (int i = 0; i < isoAIndeksit.Count; i++)
        {
            int indeksi = isoAIndeksit[i];
            char kirjain = isoAKirjaimet[i];

            Console.WriteLine($"\"A\" on {indeksi}. kirjain sanassa \"{merkkijono}\" ja se on iso \"A\".");
        }

        for (int i = 0; i < pieniAIndeksit.Count; i++)
        {
            int indeksi = pieniAIndeksit[i];
            char kirjain = pieniAKirjaimet[i];

            Console.WriteLine($"\"a\" on {indeksi}. kirjain sanassa \"{merkkijono}\" ja se on pieni \"a\".");
        }
    }
}
