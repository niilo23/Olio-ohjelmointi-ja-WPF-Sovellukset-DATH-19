using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus1
{
    class Koira
    {
        public string Nimi;
        public int Ikä;
        public string Rotu;

        public string HaeTiedot()
        {
            string merkkijono = Nimi + " " + Ikä + " " + Rotu;

            return merkkijono;
        }

        public void Hauku()
        {
            Console.WriteLine("Woof");
        }
    }
}
