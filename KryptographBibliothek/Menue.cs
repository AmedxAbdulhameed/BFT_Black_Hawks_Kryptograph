using System;
using Figgle;
using System.IO;
using System.Collections;


namespace KryptographBibliothek
{
    public class Menue
    {

        public static void MainMenu()
        {


            string pfad;




            do
            {
                (int, int) cPosBM = Console.GetCursorPosition();

                Console.WriteLine();
                //Test Chaufan
                //ASCII art Logo wird erzeugt.
                Console.WriteLine
                    (FiggleFonts.Slant.Render("Black Hawks"));

                

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Black Hawks Submenü <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");



                //Eingabeaufforderung.
                
                Console.Write("Bitte Geben Sie Pfad ein:\n");
                pfad = Console.ReadLine();
               bool result= File.Exists(pfad);
                if(result == true)
                {

                }
                else
                {
                    Console.WriteLine("Pfas nicht existent");

                }
                 


                    switch (pfad)
                    {
                     
                     

                       case "exit":
                        Environment.Exit(0);
                        break;

                      default:
                        
                            Console.WriteLine("Ungültige Eingabe");
                        Console.ReadKey();

                        (int, int) cPosAM = Console.GetCursorPosition();


                        KonsolenExtrasBibliothek.Extras.ClearCurrentConsoleLine(cPosBM.Item2, cPosAM.Item2);

                        break;
                    }


            } while (true);
        }
    }
}