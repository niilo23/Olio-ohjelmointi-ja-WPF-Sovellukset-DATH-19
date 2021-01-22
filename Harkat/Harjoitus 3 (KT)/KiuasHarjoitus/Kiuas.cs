using System;
using System.Collections.Generic;
using System.Text;

namespace KiuasHarjoitus
{
    class Kiuas
    {
        private bool päällä;
        private float lämpö;
        private float kosteus;

        public Kiuas (bool _OnOff, float _lämpö, float _kosteus)
        {
            päällä = _OnOff;
            lämpö = _lämpö;
            kosteus = _kosteus;
        }

        public void KiuasData()
        {
            Console.WriteLine("");
            Console.WriteLine("Kiuas päällä: " + päällä);
            Console.WriteLine("Kiukaan lämpö: " + lämpö + "°C");
            Console.WriteLine("Kiukaan kostues: " + kosteus + "%");
            Console.WriteLine("");
        }

        public void KiuasPäällePois(bool p)
        {
            päällä = p;
        }

        public void SäädäLämpö(int i)
        {
            lämpö += i;
        }

        public void SäädäKosteus(int i)
        {
            kosteus += i;
        }
    }
}
