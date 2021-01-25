using System;
using System.Collections.Generic;
using System.Text;

namespace TyöntekijäPomoHarjoitus
{
    class Pomo : Henkilö
    {
        public double PomoBonus { get; set; } 

        public string PomoAuto { get; set; }

        private static int instanssit;
        private static int Instanssit
        {
            get => instanssit;

            set
            {
                if (value > 1)
                {
                    value = 1;
                }
                    
                instanssit = value;
            }
        }

        public void PomoData ()
        {
            Console.WriteLine("");
            Console.WriteLine("Pomon Nimi: " + Nimi);
            Console.WriteLine("Pomon Bonus: " + PomoBonus + "%");
            Console.WriteLine("Pomon Palkka: " + PalkkaKK + "e /kk");
            Console.WriteLine("Pomon Työpaikka: " + Työpaikka);
            Console.WriteLine("Pomon Auto: " + PomoAuto);
            Console.WriteLine("");
        }

        public Pomo()
        {
            Instanssit++;
        }

        public static new void KuinkaMonta()
        {
            Console.WriteLine("Pomoja olemassa: " + Instanssit);
        }
    }
}
