using System;

class Musikplayer
{
    static void Main()
    {
        bool songGefunden = false;
        bool naechsterSong = false;

        Console.WriteLine("Musikplayer gestartet");

        // Song suchen
        while (!songGefunden)
        {
            Console.Write("Song eingeben: ");
            string song = Console.ReadLine();

            // Vereinfachte Prüfung
            Console.Write("Song gefunden? (ja/nein): ");
            string antwort = Console.ReadLine();

            if (antwort.ToLower() == "ja")
            {
                songGefunden = true;
            }
            else
            {
                Console.WriteLine("Song nicht gefunden, bitte erneut versuchen.");
            }
        }

        // Songs abspielen
        do
        {
            Console.WriteLine("Play gedrückt");
            Console.WriteLine("Song wird abgespielt...");

            Console.Write("Nächsten Song suchen? (ja/nein): ");
            string weiter = Console.ReadLine();

            if (weiter.ToLower() == "ja")
            {
                naechsterSong = true;
            }
            else
            {
                naechsterSong = false;
            }

        } while (naechsterSong);

        Console.WriteLine("Musikplayer beendet");
    }
}