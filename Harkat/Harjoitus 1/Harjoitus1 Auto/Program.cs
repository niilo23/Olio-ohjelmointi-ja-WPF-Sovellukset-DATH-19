using System;

namespace Harjoitus1_Auto
{
    class Program
    {
        static void Main(string[] args)
        {
            Ajoneuvo auto = new Ajoneuvo();

            auto.nimi = "Mersu";
            auto.nopeus = 120;
            auto.renkaat = 4;

            auto.TulostaData();

            string autoData = auto.nimi.ToString() + " " + auto.nopeus.ToString() + " " + auto.renkaat.ToString();
            Console.WriteLine(autoData);

            Console.Write("\n"); // Tulostaa uuden välin jotta lukeminen on selvempää

            Ajoneuvo rekka = new Ajoneuvo();

            rekka.nimi = "Scania";
            rekka.nopeus = 120;
            rekka.renkaat = 6;

            rekka.TulostaData();

            string rekkaData = rekka.nimi.ToString() + " " + rekka.nopeus.ToString() + " " + rekka.renkaat.ToString();
            Console.WriteLine(rekkaData);
        }
    }
}
