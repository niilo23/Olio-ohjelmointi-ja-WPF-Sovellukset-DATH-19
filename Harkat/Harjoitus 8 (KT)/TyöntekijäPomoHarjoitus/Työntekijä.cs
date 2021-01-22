using System;
using System.Collections.Generic;
using System.Text;

namespace TyöntekijäPomoHarjoitus
{
    class Työntekijä : Henkilö
    {

        public int VkTunnit { get; set; }
        private static int Instanssit = 0;
        public void TyöntekijäData()
        {
            Console.WriteLine("");
            Console.WriteLine("Työntekijän Nimi: " + Nimi);
            Console.WriteLine("Työntekijän Palkka: " + PalkkaKK + "e /kk");
            Console.WriteLine("Työntekijän Työpaikka: " + Työpaikka);
            Console.WriteLine("Työntekijän tunnit viikossa: " + VkTunnit + " h");
            Console.WriteLine("");
        }

        public Työntekijä()
        {
            Instanssit++;
        }

        public static new void KuinkaMonta()
        {
            Console.WriteLine("Työntekijöitä olemassa: " + Instanssit);
        }
    }
}
