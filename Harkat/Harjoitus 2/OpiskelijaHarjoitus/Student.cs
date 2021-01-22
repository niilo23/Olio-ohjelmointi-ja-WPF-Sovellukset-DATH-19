using System;
using System.Collections.Generic;
using System.Text;

namespace OpiskelijaHarjoitus
{
    class Student
    {
        private string nimi { get; set; }
        private string opiskelijaID { get; set; }

        private int Opintopisteet { get; set; }

        public Student(string _nimi, string _id, int _op)
        {
            nimi = _nimi;
            opiskelijaID = _id;
            Opintopisteet = _op;
        }

        public void TulostaData()
        {
            Console.WriteLine("");
            Console.WriteLine("Opiskelijan Nimi: " + nimi);
            Console.WriteLine("Opiskelijan ID: " + opiskelijaID);
            Console.WriteLine("Opiskelijan Opintopisteet: " + Opintopisteet);
            Console.WriteLine("");
        }

        public void MuokkaaOpintopisteitä(int i)
        {
            Opintopisteet += i;
        }
    }
}
