using System;
using System.IO;
using System.Collections.Generic;
namespace KryptographBibliothek


{
    public class AuslesenTabelle
    {

        public static Dictionary<string, double> AuslesenTab()

        {
            Console.WriteLine("Bitte geben sie ein E für den Englischen Text oder D für den Deutschen Text");
            String Text = Console.ReadLine();
            Dictionary<string, double> Tabelle = new Dictionary<string, double>();

            if (Text == "D")
            {

                string[] text = System.IO.File.ReadAllLines(@"../../../../Deutsch_Wahrscheinlichkeiten.txt");

                foreach (string line in text)
                {
                    Console.WriteLine(line);
                    string[] daten = line.Split(' ', '\t');
                    Tabelle.Add(daten[0], Convert.ToDouble(daten[1]));



                }


            }
            if (Text == "E")
            {

                string[] text1 = File.ReadAllLines(@"../../../../Englisch_Wahrscheinlichkeiten.txt");

                foreach (string line in text1)
                {
                    Console.WriteLine(line);
                    string[] daten = line.Split(' ', '\t');
                    Tabelle.Add(daten[0], Convert.ToDouble(daten[1]));

                }

             
               

            }
            return Tabelle;

        }
    }
}
