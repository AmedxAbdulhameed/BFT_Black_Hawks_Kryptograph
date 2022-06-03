using System;
using System.IO;
using System.Text;
namespace KryptographBibliothek
{

    public class AuslesenChiffre
    {
         public static void Auslesen( )
         {
            //wie gebe ich durch einen pfad den inhalt einer textdatei in c# aus?

            //------------------------------------------------

            string text = System.IO.File.ReadAllText(pfad);

            string chiffre =   text;


            //-----------------------------------

            return chiffre;

         }



    }
    
       
    
}
