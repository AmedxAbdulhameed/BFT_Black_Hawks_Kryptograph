using System;

namespace KryptographBibliothek
{
    public class Entfernen

    {
        public static string Zeichen_Entfernen(string str)

        {

            do
            {
               
                    Console.WriteLine("Eingabe:exit\t->\tZeichen Entfernen beendet");
                    Console.WriteLine("-------------------------------------------------");



                    Console.WriteLine("                                                                                                                     CHIFFRE");
                    Console.WriteLine("_____________________________________________________________________________________________________________________________________________________________________________________________________________________________________________");
                    Console.WriteLine(str);
                    Console.WriteLine("_____________________________________________________________________________________________________________________________________________________________________________________________________________________________________________");

                    Console.WriteLine("Welches zeichen wollen Sie davon Entfernt haben");
                    Console.Write("Eingabe:");



                string charsToRemove = Console.ReadLine();

                if (charsToRemove == "exit")
                {

                    Environment.Exit(0);

                }
                else
                {

                  




                    str = str.Replace(charsToRemove.ToLower(), "");

                    str = str.Replace(charsToRemove.ToUpper(), "");

                }



                Console.Clear();
            

            } while (true);


            return str;


        }
    }
}
