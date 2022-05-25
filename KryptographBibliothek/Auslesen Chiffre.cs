using System;
using System.IO;
using System.Text;
namespace KryptographBibliothek
{

    public class FileName
    {
         static void Auslesen( )
        {
            

            
            foreach (string line in System.IO.File.ReadLines(@"c:\Chiffre.txt"))
            {
                System.Console.WriteLine(line);
                
            }




            return;



        }



    }
    
       
    
}
