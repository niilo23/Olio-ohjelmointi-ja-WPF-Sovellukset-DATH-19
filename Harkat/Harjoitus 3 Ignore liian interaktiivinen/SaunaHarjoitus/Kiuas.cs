using System;
using System.Collections.Generic;
using System.Text;

// Sori jos aivot sulaa, itekkää enää tiiä ees mitä tää tekee

namespace SaunaHarjoitus
{
    class Kiuas
    {
        public bool Päällä = false;
        public float Lämpötila { get; set; }
        public float Kosteus { get; set; }

        public string userInput;

        public bool MainLoop = true;

        public Kiuas(bool _OnOff, float _Lämpö, float _Kosteus)
        {
            Päällä = _OnOff;
            Lämpötila = _Lämpö;
            Kosteus = _Kosteus;
        }

        public void KiukaanTila()
        {
            
            while (MainLoop == true)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("Kirjoita 'Kost' säätääksesi kosteutta");
                Console.WriteLine("Kirjoita 'Lämp' säätääksesi Lämpöä");
                if (Päällä == true) // Tarkistaa onko kiuas päällä
                {
                    Console.WriteLine("Kirjoita 'Pois' laittaaksesi kiukaan pois");
                }
                else
                {
                    Console.WriteLine("Kirjoita 'Päälle' laittaaksesi kiukaan päälle");
                }

                Console.WriteLine("");

                if (Päällä == true) // Tarkistaa onko kiuas päällä
                {
                    Console.WriteLine("Kiuas on päällä");
                    Console.Beep(650, 50);
                    Console.Beep(750, 200);
                }
                else
                {
                    Console.WriteLine("Kiuas ei ole päällä");
                    Console.Beep(650, 200);
                }

                Console.WriteLine("Kiukaan lämpötila: " + Lämpötila + "°C");
                Console.WriteLine("Kiukaan kosteus: " + Kosteus + "%");
                Console.WriteLine("");

                Console.WriteLine("Jos haluat lopettaa kirjoita 'Exit'");

                Console.Write("Säädä Kiuasta: ");
                userInput = Console.ReadLine().ToLower();

                Console.Clear();

                KiuasLogiikka();
            }
        }

        public void KiuasLogiikka()
        {
            if (Päällä == false && userInput == "Päälle".ToLower())
            {
                Päällä = true;
            }
            else if (Päällä == true && userInput == "Pois".ToLower())
            {
                Päällä = false;
            }

            if(userInput == "exit".ToLower())
            {
                MainLoop = false;
                
                Console.Write("Paina Enter sulkeaksesi ohjelman");
            }

            if (userInput == "Lämp".ToLower())
            {
                Console.Write("Nosta/laske lämpötilaa: ");
                int lmp = int.Parse(Console.ReadLine());
                SäädäLämpö(lmp);
            }

            if (userInput == "Kost".ToLower())
            {
                Console.Write("Nosta/laske kosteutta: ");
                int kst = int.Parse(Console.ReadLine());
                SäädäKosteus(kst);
            }

            if (Lämpötila < 20 && Päällä == true) Console.ForegroundColor = ConsoleColor.Cyan;
            else if (Lämpötila > 70 && Päällä == true) Console.ForegroundColor = ConsoleColor.Red;
            else Console.ResetColor();
        }

        public void SäädäKosteus(int i)
        {
            Kosteus += i;
        }

        public void SäädäLämpö(int i)
        {
            Lämpötila += i;
        }
    }
}
