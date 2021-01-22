using System;

namespace OpiskelijaHarjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Opiskelija = new Student("Pena", "TT261", 50);

            
            Opiskelija.TulostaData();
            Opiskelija.MuokkaaOpintopisteitä(8);
            Opiskelija.TulostaData();


            Student Opiskelija2 = new Student("Karpo", "2611", 26);
            Opiskelija2.TulostaData();
            Opiskelija2.MuokkaaOpintopisteitä(10);
            Opiskelija2.TulostaData();
        }
    }
}
