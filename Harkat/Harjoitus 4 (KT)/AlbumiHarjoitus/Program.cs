using System;

namespace AlbumiHarjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            Albumi Alpumi = new Albumi("Artisti_123", "Musiikki_123", "Pop", 10);
            Alpumi.lisääKappale("kappale1");
            Alpumi.lisääKappale("kappale2");
            Alpumi.lisääKappale("kappale3");
            Alpumi.lisääKappale("kappale4");
            Alpumi.lisääKappale("kappale5");

            Alpumi.TulostaAlbumiData();
            Alpumi.TulostaKappaleet();
        }
    }
}
