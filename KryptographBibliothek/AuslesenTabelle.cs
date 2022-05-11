using System;
using System.IO;
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


                string[] text = File.ReadAllLines(@"C:\Users\tim.g33\Source\Repos\BFT_Black_Hawks_Kryptograph1\Deutsch_Wahrscheinlichkeiten.txt");

                foreach (string line in text)
                {
                    string[] daten = line.Split(' ');
                    string[] daten2 = daten[0].Split('\t');
                    int nummer = int.Parse(daten[0]);
                    string name = daten[1];
                    double gehalt = double.Parse(daten[2]);


                }
           
            



            }
            if (Text=="E")

            {
                string[] text1 = File.ReadAllLines(@"C:\Users\tim.g33\Source\Repos\BFT_Black_Hawks_Kryptograph1\Englisch_Wahrscheinlichkeiten.txt");

                foreach (string text2 in text1)
                {
                    string[] daten = text2.Split(';');
                    int nummer = int.Parse(daten[0]);
                    string name = daten[1];
                    double gehalt = double.Parse(daten[2]);


                }




            }






        }
    }
}
