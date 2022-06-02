using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace KryptographBibliothek
{
    public class Ersetzen
    {
        public static string ZeichenErsetzen(string chiffre, Dictionary<String, double> tabelle_chiffre, Dictionary<String, double> tabelle_sprache)

        {

            string klartext="";

            //1. beide Tabellen sortieren

            //
            var tabelle_sprache_sorted = from entry in tabelle_sprache orderby entry.Value descending select entry;
            var tabelle_chiffre_sorted = from entry in tabelle_chiffre orderby entry.Value descending select entry;

            Console.ReadKey();
            //foreach (KeyValuePair<string, double> kvp in Capital_sorted)
            //    {
            //        //textBox3.Text += ("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            //        Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            //    }


            //    Console.WriteLine("______________________________");
            //    var Chiffre_sorted = from entry in tabelle_chiffre orderby entry.Value ascending select entry;


            //    foreach (KeyValuePair<string, double> kvp in Chiffre_sorted)
            //    {
            //        //textBox3.Text += ("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            //        Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            //    }


            //    for(int i =0; i < Chiffre_sorted.Count(); i++)
            //    {
            //        string key_chiffre = Chiffre_sorted.ElementAt(tabelle_chiffre.Count-1-i).Key;
            //        chiffre = chiffre.Replace(' ', ',');
                 
            //    }

                 
                 


            return klartext;

        }

    }
}
