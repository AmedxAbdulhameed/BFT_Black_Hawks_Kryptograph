using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace KryptographBibliothek
{
    public class ZeichenZaehlen
    {
       public static Dictionary<string,double> Zeichenzaehlen()
{
Dictionary<string, double> Zählen = new Dictionary<string, double>();



string text = "Kly ulbl";
text = text.ToUpper();




//Momentanes zeichen zählen
//Schauen ob Zeichen in der Tabelle vorhanden ist (c# check if char inf Dictionary/ c# schau ob karakter ind Dictionary)
//Zeichen mit Wahrscheinlichkeit hinzufügen (c# add key and value to dictionary/ c# eintrag in dictionary hinzufügen)




for (int i=0; i<text.Length; i++)
{
//text[i]



//help start
bool dupeCharFlag = false;
for (int j = 0; j < i;j++)
{
if (text[j] == text[i])
{
dupeCharFlag = true;
}
}
if (dupeCharFlag)
{
continue;
}
// help end



Console.WriteLine(text[i]);
int anzahl = text.Count(c => c == text[i]);



if (!Zählen.ContainsKey(text[i].ToString()))
{



double Prozent = anzahl * 100/ (text.Length) ;




Console.WriteLine("Der Prozent werd im Text ist:" + Prozent + "%");




}



}








return Zählen;
}

    }
}
