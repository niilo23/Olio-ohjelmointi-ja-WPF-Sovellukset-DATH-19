using System;

namespace TyöntekijäPomoHarjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            Työntekijä Röiukko = new Työntekijä();
            Työntekijä Röiukko2 = new Työntekijä();

            Röiukko.Nimi = "Pena";
            Röiukko.PalkkaKK = 3500;
            Röiukko.Työpaikka = "TyöpaikkaX";
            Röiukko.VkTunnit = 40;

            Röiukko2.Nimi = "Toni";
            Röiukko2.PalkkaKK = 3200;
            Röiukko2.Työpaikka = "TyöpaikkaX";
            Röiukko2.VkTunnit = 38;


            Pomo Boss = new Pomo();
            Pomo BossWannabe = new Pomo();

            Boss.Nimi = "Karpo";
            Boss.PomoBonus = 25.4;
            Boss.PalkkaKK = 4389;
            Boss.PomoAuto = "Mersu";
            Boss.Työpaikka = "TyöpaikkaX";

            Röiukko.TyöntekijäData();

            Röiukko2.TyöntekijäData();

            Boss.PomoData();

            Työntekijä.KuinkaMonta();
            Pomo.KuinkaMonta();
            // Neljättä henkilöä ei saa pois, en tiedä miksi.
            // Näytää kyllä vain yhden pomon.
            Henkilö.KuinkaMonta();
        }
    }
}
