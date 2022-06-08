using System;
using Figgle;
using System.IO;
using System.Collections.Generic;


namespace KryptographBibliothek
{
    public class Menue
    {

        public static void MainMenu()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            bool Exit = false;
            bool flag = false;
            string chiffre = "";
            string dateipfad = "";


            do
            {
                (int, int) cPosBM = Console.GetCursorPosition();

                Console.WriteLine();
                //Test Chaufan
                //ASCII art Logo wird erzeugt.
                Console.WriteLine
                    (FiggleFonts.Slant.Render("Black Hawks"));

                

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Black Hawks Submenü <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");



                //Eingabeaufforderung.

                Console.WriteLine("Bitte geben Sie den Pfad der Chiffre an.:\n");
                Console.Write("Eingabe:");
                dateipfad = Console.ReadLine();
                //fragt dateipfad ab
                switch (dateipfad)
                {
                    case "exit":
                        
                        break;
                    default:
                        flag = Pfadprüfer(dateipfad);
                        if (flag)
                        {
                            string get = KryptographBibliothek.Entfernen.Zeichen_Entfernen();
                            var chiffretabelle = new Dictionary<string, double>();
                            chiffretabelle = KryptographBibliothek.ZeichenZaehlen.Zeichenzaehlen();
                           // string fertig_chiff = KryptographBibliothek.Zeichenersetzen.Ersetzen(get, chiffretabelle);
                           // KryptographBibliothek.Ausgabe.AusgabenZeichen(chiffre, fertig_chiff);



                        }
                        else
                        {
                            Console.WriteLine("Detiepfad nicht gefunden");
                        }
                        break;
                }



            } while (!flag);
            if (Exit)
            {
                Environment.Exit(0);
            }
        }
        public static bool Pfadprüfer(string pfad)
        {
            if (File.Exists(pfad))
            {
                Console.WriteLine("der Pfad '{0}'existiert.", pfad);
                return true;
            }
            else
            {
                Console.WriteLine("{0} ist kein richtig angegebener Pfad.", pfad);
                return false;
            }
        }
    }
}