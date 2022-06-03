using System;

namespace KryptographBibliothek
{
    public class Ausgabe
    {
        public static string AusgabenZeichen()
        {

            string chiffre = "Kyl, ";
            string klartext = "Das, ";


            Console.WriteLine("Ergebnis");
            Console.WriteLine("--------------------------");

            for (int i = 0; i < chiffre.Length; i++)
            {
                if (chiffre[i] != klartext[i])
                {
                    Console.BackgroundColor
                    = ConsoleColor.Red;

                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;

                }

                Console.WriteLine(chiffre);
                Console.WriteLine(klartext);


            }

            Console.BackgroundColor = ConsoleColor.Black;

            return klartext;
        }

    }
}
