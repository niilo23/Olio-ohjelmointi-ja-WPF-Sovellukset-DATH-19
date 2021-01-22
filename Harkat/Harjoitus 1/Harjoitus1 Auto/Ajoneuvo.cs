using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus1_Auto
{
    class Ajoneuvo
    {
        public string nimi { get; set; }
        public int nopeus { get; set; }
        public int renkaat { get; set; }

        public void TulostaData()
        {
            Console.WriteLine("Auton Nimi: " + nimi);
            Console.WriteLine("Auton Renkaat: " + renkaat);
            Console.WriteLine("Auton Nopeus: " + nopeus);
        }



    }
}
