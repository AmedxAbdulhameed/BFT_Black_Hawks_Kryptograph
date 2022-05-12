using System;
using System.IO;
using System.Collections.Generic;
namespace KryptographBibliothek


{
    public class AuslesenTabelle
    {

        public static void AuslesenTab()
        {
            Console.WriteLine("Bitte geben sie ein E für den Englischen Text oder D für den Deutschen Text");
            String Text = Console.ReadLine();

            if (Text == "D")
            {

                Dictionary<string, string> Tabelle_deutsch = new Dictionary<string, string>();

                string[] text = File.ReadAllLines(@"C:\Users\tim.g33\Source\Repos\BFT_Black_Hawks_Kryptograph\Deutsch_Wahrscheinlichkeiten.txt");

                foreach (string line in text)
                {
                    Console.WriteLine(line);
                    string[] daten = line.Split(' ');
                    string[] daten2 = daten[0].Split('\t');
                    Tabelle_deutsch.Add("txt", "notepad.exe");


                }
           
            



            }
            if (Text=="E")

            {
                Dictionary<string, string> Tabelle_Englisch = new Dictionary<string, string>();
                string[] text1 = File.ReadAllLines(@"C:\Users\tim.g33\Source\Repos\BFT_Black_Hawks_Kryptograph\Englisch_Wahrscheinlichkeiten.txt");

                foreach (string line in text1)
                {
                    Console.WriteLine(line);
                    string[] daten = line.Split(' ');
                    string[] daten2 = daten[0].Split('\t');
                    Tabelle_Englisch.Add("txt", "notepad.exe");


                }




            }






        }
    }
}
