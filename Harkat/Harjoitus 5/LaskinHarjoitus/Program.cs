using System;

namespace LaskinHarjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            bool laskinloop = true;

            Laskin laskin = new Laskin();

            while (laskinloop == true)
            {
                try
                {
                    Console.Clear();
                    Console.Write("Aseta ensimmäinen numero: ");
                    float a = float.Parse(Console.ReadLine());

                    Console.Write("Aseta operaattori [+] [-] [*] [/]:");
                    string operaattori = Console.ReadLine();

                    Console.Write("Aseta toinen numero: ");
                    float b = float.Parse(Console.ReadLine());

                    laskin.LaskinLogiikka(a, b, operaattori);

                }
                catch // Heittää errorin jos laittaa jotain muuta kun numeron
                {
                    Console.WriteLine("Aseta vain numeroita tähän");
                    Console.WriteLine("Paina Enter jatkaaksesi");
                    Console.ReadLine();
                    Console.Clear();
                }

            }
        }
    }
}
