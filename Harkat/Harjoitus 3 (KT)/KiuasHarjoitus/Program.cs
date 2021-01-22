using System;

namespace KiuasHarjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas Harvia = new Kiuas(false, 20, 0);

            Harvia.KiuasData();
            Harvia.KiuasPäällePois(true);
            Harvia.KiuasData();

            Harvia.SäädäLämpö(40);
            Harvia.SäädäKosteus(60);
            Harvia.KiuasData();

            Harvia.SäädäKosteus(-20);
            Harvia.KiuasData();

            Harvia.SäädäLämpö(-40);
            Harvia.SäädäKosteus(-40);
            Harvia.KiuasPäällePois(false);
            Harvia.KiuasData();
        }
    }
}
