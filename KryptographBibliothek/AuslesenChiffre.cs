using System;
using System.IO;
using System.Text;
namespace KryptographBibliothek
{

    public class AuslesenChiffre
    {
        

        public static string Auslesen( )
         {

        
            string text = System.IO.File.ReadAllText(pfad);

          
            return text;

         }



    }
    
       
    
}
