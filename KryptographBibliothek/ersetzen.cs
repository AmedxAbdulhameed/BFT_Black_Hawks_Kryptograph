using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace KryptographBibliothek
{
    public class Ersetzen
    {
        public static string ZeichenErsetzen(string Ersetzen)

        {
            string chiffre = "Kly ulbl";

            Dictionary<String, double> tabelle_chiffre = new Dictionary<string, double>();
            tabelle_chiffre.Add("K", 1 / 7.0);//14%->0,14
            tabelle_chiffre.Add("L", 3 / 7.0);//43%->0,43
            tabelle_chiffre.Add("Y", 1 / 7.0);//14%->0,14
            tabelle_chiffre.Add("U", 1 / 7.0);//14%->0,14
            tabelle_chiffre.Add("B", 1 / 7.0);//14%->0,14



            Dictionary<String, double> Capitals
                = new Dictionary<string, double>();

                Capitals.Add("A", 0.0558);
                Capitals.Add("Ä", 0.0054);
                Capitals.Add("B", 0.0196);
                Capitals.Add("C", 0.0316);
                Capitals.Add("D", 0.0498);
                Capitals.Add("E", 0.1693);
                Capitals.Add("F", 0.0149);
                Capitals.Add("G", 0.0302);
                Capitals.Add("H", 0.0498);
                Capitals.Add("I", 0.0802);
                Capitals.Add("J", 0.0024);
                Capitals.Add("K", 0.0132);
                Capitals.Add("L", 0.0360);
                Capitals.Add("M", 0.0255);
                Capitals.Add("N", 0.1053);
                Capitals.Add("O", 0.0224);
                Capitals.Add("Ö", 0.0030);
                Capitals.Add("P", 0.0067);
                Capitals.Add("Q", 0.0002);
                Capitals.Add("R", 0.0689);
                Capitals.Add("ß", 0.0037);
                Capitals.Add("S", 0.0642);
                Capitals.Add("T", 0.0579);
                Capitals.Add("U", 0.0383);
                Capitals.Add("Ü", 0.0065);
                Capitals.Add("V", 0.0084);
                Capitals.Add("W", 0.0178);
                Capitals.Add("X", 0.0005);
                Capitals.Add("Y", 0.0005);
                Capitals.Add("Z", 0.0121);

                var Capital_sorted = from entry in Capitals orderby entry.Value ascending select entry;


                foreach (KeyValuePair<string, double> kvp in Capital_sorted)
                {
                    //textBox3.Text += ("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
                    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
                }


                Console.WriteLine("______________________________");
                var Chiffre_sorted = from entry in tabelle_chiffre orderby entry.Value ascending select entry;


                foreach (KeyValuePair<string, double> kvp in Chiffre_sorted)
                {
                    //textBox3.Text += ("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
                    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
                }


                for(int i =0; i < Chiffre_sorted.Count(); i++)
                {
                    string key_chiffre = Chiffre_sorted.ElementAt(tabelle_chiffre.Count-1-i).Key;
                    chiffre = chiffre.Replace(' ', ',');
                   
                }

                 
                 


            return Ersetzen;

        }

    }
}
