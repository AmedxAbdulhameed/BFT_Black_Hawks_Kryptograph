using System;
using System.IO;
using System.Text;
namespace KryptographBibliothek
{

    public class FileName
    {
         static void Auslesen(string [] args)
        {


            foreach (string line in System.IO.File.ReadLines(@"C: \Users\eric.k12\source\repos\BFT_Black_Hawks_Kryptograph\Chiffre.txt")
            { 
                System.Console.WriteLine(line);
                string Path = pfad;
                string filename = null;
                filename = Path.GetFileName(Path);
                Console.WriteLine("Filename =" + filename);
            }


        }



    }
    
       
    
}
