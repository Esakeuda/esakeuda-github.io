using System;

class Tehtävä20
{
    static void Main(string[] args)
    {
        bool jatka = true;

        while (jatka)
        {
            Console.WriteLine("Syötä merkki:");
            string syote = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(syote))
            {
                Console.WriteLine("Antamasi merkki on tyhjä merkki.");
            }
            else if (char.IsDigit(syote[0]))
            {
                Console.WriteLine("Antamasi merkki on numero: " + syote);
            }
            else if (char.IsUpper(syote[0]))
            {
                Console.WriteLine("Antamasi merkki on iso kirjain.");
            }
            else if (char.IsLower(syote[0]))
            {
                Console.WriteLine("Antamasi merkki on pieni kirjain.");
            }
            else
            {
                Console.WriteLine("Antamasi merkki on erikoismerkki.");
            }

            Console.WriteLine("Haluatko jatkaa? (k/e)");
            string vastaus = Console.ReadLine();

            if (vastaus.ToLower() != "k")
            {
                jatka = false;
            }

            Console.WriteLine();
        }
    }
}
