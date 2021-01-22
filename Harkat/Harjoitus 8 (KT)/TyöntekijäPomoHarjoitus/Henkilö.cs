using System;
using System.Collections.Generic;
using System.Text;

namespace TyöntekijäPomoHarjoitus
{
    public abstract class Henkilö
    {

        public string Nimi { get; set; }

        public string Työpaikka { get; set; }

        public double PalkkaKK { get; set; }

        public static int instanssit = 0;

        public Henkilö()
        {
            instanssit++;
        }

        public static void KuinkaMonta()
        {
            Console.WriteLine("Henkilöitä olemassa: " + instanssit);
        }
    }
}
