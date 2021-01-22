using System;
using System.Collections.Generic;
using System.Text;

namespace LaskinHarjoitus
{
    class Laskin
    {
        static void Plus (float a, float b)
        {
            Console.WriteLine("Vastaus on: " + (a + b));
            Console.ReadLine();
        }

        static void Miinus (float a, float b)
        {
            Console.WriteLine("Vastaus on: " + (a - b));
            Console.ReadLine();
        }

        static void Kerto (float a, float b)
        {
            Console.WriteLine("Vastaus on: " + (a * b));
            Console.ReadLine();
        }

        static void Jako (float a, float b)
        {
            Console.WriteLine("Vastaus on: " + (a / b));
            Console.ReadLine();
        }

        // Logiikka jolla laskin päättelee tuloksen
        public void LaskinLogiikka(float a, float b, string operaattori)
        {
            switch (operaattori)
            {
                case "+":
                       Laskin.Plus(a, b);
                    break;

                case "-":
                    Laskin.Miinus(a, b);
                    break;

                case "*":
                    Laskin.Kerto(a, b);
                    break;
                case "/":
                    Laskin.Jako(a, b);
                    break;

                default:
                    Console.WriteLine("Aseta jokin edella mainituista operaattoreista!");
                    Console.WriteLine("Paina Enter jatkaaksesi");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
            
        }
    }
}
