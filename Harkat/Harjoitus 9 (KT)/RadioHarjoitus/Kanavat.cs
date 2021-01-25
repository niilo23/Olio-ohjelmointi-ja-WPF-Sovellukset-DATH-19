using System;
using System.Collections.Generic;
using System.Text;

namespace RadioHarjoitus
{
    class Kanavat : Radio
    {
        public static string kanavaNimi;

        public static readonly string[] kanava = {"Radio Nova [106,2 MHz]", "Iskelmä [96,2 MHz]", "Radio Rock [94,9 MHz]", "The Voice [104,6 MHz]", "YLE Radio Suomi [94,0 MHz]"}; // Kanava array

        private static int KanavaNum;

        public static void TarkistaTaajus()
        {
            switch (Radio.taajuus) // Tarkistaa mikä on radion tämänhetkinen taajuus ja päättää siitä mikä kanava arraysta otetaan
            {
                case 106.2f:
                    kanavaNimi = kanava[0];
                    break;
                case 96.2f:
                    kanavaNimi = kanava[1];
                    break;
                case 94.9f:
                    kanavaNimi = kanava[2];
                    break;
                case 104.6f:
                    kanavaNimi = kanava[3];
                    break;
                case 94.0f:
                    kanavaNimi = kanava[4];
                    break;
                default:
                    kanavaNimi = "*kohinaa*";
                    break;
            }
        }

        public static void TulostaKanavalista()
        {
            KanavaNum = 0; // Nollaa kanavanumeron jotta se ei jatka kasvua loputtomasti

            foreach (string kanava in kanava)
            {
                KanavaNum++;
                Console.WriteLine(KanavaNum + ". " + kanava);
            }
        }

    }
}
