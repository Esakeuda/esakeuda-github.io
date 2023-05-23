using System;

class Nopanheitto
{
    static void Main()
    {
        // Luo Random-olio satunnaislukujen arpomista varten
        Random random = new Random();

        do
        {
            int summa = 0;

            // Heitä noppaa viisi kertaa ja laske yhteissumma
            for (int i = 0; i < 5; i++)
            {
                // Arvo kaksi silmälukua väliltä 1-6
                int silmaluku1 = random.Next(1, 7);
                int silmaluku2 = random.Next(1, 7);

                // Lisää silmälukujen summa yhteensummaan
                summa += silmaluku1 + silmaluku2;
            }

            // Tulosta kaikkien heittojen yhteenlaskettu summa
            Console.WriteLine("Kaikkien heittojen yhteissumma: " + summa);
            Console.WriteLine(); // Lisää tyhjä rivi

            // Heitä noppaa uudelleen viisi kertaa ja tulosta heittojen tiedot
            for (int i = 0; i < 5; i++)
            {
                // Arvo kaksi silmälukua väliltä 1-6
                int silmaluku1 = random.Next(1, 7);
                int silmaluku2 = random.Next(1, 7);

                // Tulosta heiton tiedot
                Console.WriteLine("Heitto {0}: Nopat ovat {1} ja {2} --> Kahden nopan summa on {3}", i + 1, silmaluku1, silmaluku2, silmaluku1 + silmaluku2);
                Console.WriteLine(); // Lisää tyhjä rivi
            }

            // Kysy haluatko jatkaa
            Console.Write("Haluatko jatkaa (k/e)? ");
            string vastaus = Console.ReadLine();

            if (vastaus.ToLower() != "k")
                break;

            Console.WriteLine(); // Lisää tyhjä rivi
        } while (true);

        // Pysäytä ohjelma odottamaan enterin painallusta ennen sulkemista
        Console.ReadLine();
    }
}
