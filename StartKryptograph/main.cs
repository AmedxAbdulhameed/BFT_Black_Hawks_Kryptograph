using System;

namespace StartKryptograph
{
    class main
    {
        static void Main(string[] args)
        {
     
           System.Collections.Generic.Dictionary<string,double> name = KryptographBibliothek.AuslesenTabelle.AuslesenTab();
            foreach (var n in name)
            {
                Console.WriteLine(n.Value);
            }
        }
    }
}
