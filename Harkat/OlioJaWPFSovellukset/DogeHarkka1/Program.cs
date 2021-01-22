using System;

namespace Harjoitus1
{
    class Program
    {
        static void Main(string[] args)
        {
            Koira mopsi = new Koira();

            mopsi.Nimi = "Rekku";
            mopsi.Ikä = 2;
            mopsi.Rotu = "Mopsi";

            Console.WriteLine(mopsi.HaeTiedot());
        }
    }
}
