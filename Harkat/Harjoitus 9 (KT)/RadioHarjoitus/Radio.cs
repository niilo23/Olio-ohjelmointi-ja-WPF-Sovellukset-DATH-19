using System;
using System.Collections.Generic;
using System.Text;

namespace RadioHarjoitus
{
    class Radio
    {
        private bool PäälläPois { get; set; } // Radion päälle tai pois kytkevä boolean
        private bool mainLoop = true; // bool joka määrää looppia jolla ohjelma pyörii

        private string input;

        private static double Äänenvoimakkuus = 5;
        private static double äänenvoimakkuus
        {
            get => Äänenvoimakkuus;
            set
            {
                if (value < 0) // Tarkistaa ettei ääni ole alle 0, muuttaa takaisin jos on
                {
                    value = 0;
                }
                else if (value > 9) // Tarkistaa ettei ääni ole yli 9, jos on niin muuttaa sen takaisin 9
                {
                    value = 9;
                }

                Äänenvoimakkuus = value;
            }
        }

        public static float taajuus = 106.2f; // Vakiona taajuus on 106,2 MHz
        private static float Taajuus
        {
            get => taajuus;

            set
            {
                if (value > 107.9f)
                {
                    value = 107.9f;
                }
                else if (value < 88.0f)
                {
                    value = 88.0f;
                }

                taajuus = value;
            }
        }

        public void Tila (bool t)
        {
            PäälläPois = t;
        }

        public static void AsetaTaajuus(float i)
        {
            Taajuus = i;
        }

        public static void AsetaÄäni(double i)
        {
            äänenvoimakkuus = i;
        }

        public void RadioToiminta() // Metodi joka ohjaa koko radion toimintaa
        {
            while (mainLoop)
            {
                Kanavat.TarkistaTaajus();
                Console.WriteLine("Kanavalista: ");
                Kanavat.TulostaKanavalista();
                Console.WriteLine("");


                if (PäälläPois == true) 
                {
                    Console.WriteLine("Kirjoita Pois sammuttaaksesi radion");
                }
                else
                {
                    Console.WriteLine("Kirjoita Päälle laittaaksesi radion päälle");
                }

                Console.WriteLine("");

                if (PäälläPois == true) // Muuttaa tekstiä näyttämään onko radio päällä vai pois
                {
                    Console.WriteLine("Radio on päällä");
                }
                else
                {
                    Console.WriteLine("Radio ei ole päällä");
                }

                Console.WriteLine("Radion Äänenvoimakkuus: " + Äänenvoimakkuus);
                Console.WriteLine("Radion Taajuus: " + Taajuus + " MHz");
                Console.WriteLine("Kanava: " + Kanavat.kanavaNimi);
                Console.WriteLine("");
                Console.WriteLine("Kirjoita Taajuus säätääksesi taajuutta (88.0 - 107.9)");
                Console.WriteLine("Kirjoita Ääni säätääksesi äänenvoimakkuutta (0 - 9)");
                Console.WriteLine("");
                Console.WriteLine("Kirjoita Exit sammuttaaksesi ohjelman");
                Console.WriteLine("");
                Console.Write("Säädä Radioa: ");

                input = Console.ReadLine().ToLower(); // ToLower() on tässä koska sitten ei tarvitse tarkastella erikseen inputtia
                                                      // vaan voi katsoa if lauseella vain pienillä kirjaimilla kirjoitettua tekstiä

                if (input == "taajuus")
                {
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("Kanavalista: ");
                        Kanavat.TulostaKanavalista();
                        Console.WriteLine("");

                        Console.Write("Säädä taajuutta (88.0 - 107.9): ");
                        AsetaTaajuus(float.Parse(Console.ReadLine())); // Muuntaa string inputin integeriksi ja asettaa taajuuden sen mukaan
                    }
                    catch // Tarkistaa että syöttönä on vain numero ja heittää errorin mikäli se on jotain muuta
                    {
                        Console.WriteLine("Asettamasi luku ei ollut kokonaisluku");
                        Console.ReadLine();
                    }
                }

                if (input == "ääni")
                {
                    Console.Clear();
                    try
                    {
                        Console.Write("Säädä Äänenvoimakkuutta (0 - 9): ");
                        AsetaÄäni(int.Parse(Console.ReadLine())); // Muuntaa string inputin integeriksi ja asettaa taajuuden sen mukaan
                    }
                    catch // Tarkistaa että syöttönä on vain numero ja heittää errorin mikäli se on jotain muuta
                    {
                        Console.WriteLine("Asettamasi luku ei ollut kokonaisluku");
                        Console.ReadLine();
                    }
                }

                if (input == "exit")
                {
                    mainLoop = false; // Pysäyttää loopin jotta ohjelman voi sammuttaa
                }

                if (input == "päälle")
                {
                    Tila(true); // Radio päälle
                }
                else if (input == "pois")
                {
                    Tila(false); // Radio pois päältä
                }

                Console.Clear(); // Puhdistaa konsoli ikkunan joka loopin jälkeen, tehty vain siksi että näyttää puhtaammalta
            }
        }
    }
}
