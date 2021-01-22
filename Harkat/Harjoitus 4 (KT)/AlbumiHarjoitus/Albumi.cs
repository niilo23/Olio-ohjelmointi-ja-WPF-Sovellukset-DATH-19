using System;
using System.Collections.Generic;
using System.Text;

namespace AlbumiHarjoitus
{
    class Albumi
    {
        private string artisti { get; set; }
        private string musiikinNimi { get; set; }
        private string genre { get; set; }
        private int hinta { get; set; }

        public List<string> Kappale = new List<string>(10);
        
        public Albumi (string _artisti, string _musiikki, string _genre, int _hinta)
        {
            artisti = _artisti;
            musiikinNimi = _musiikki;
            genre = _genre;
            hinta = _hinta;
        }

        public void TulostaAlbumiData()
        {
            Console.WriteLine("");
            Console.WriteLine("Artisti: " + artisti);
            Console.WriteLine("Nimi: " + musiikinNimi);
            Console.WriteLine("Genre: " + genre);
            Console.WriteLine("Hinta: " + hinta + "e");
            Console.WriteLine("\n" + "Songs");
        }

        public void lisääKappale(string Nimi)
        {
            Kappale.Add(Nimi);
        }

        public void TulostaKappaleet()
        {
            foreach (String Nimi in Kappale)
            {
                Console.WriteLine("--Nimi: " + Nimi);
            }
        }
    }
}
