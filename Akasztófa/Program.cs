using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Akasztófa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] szavak = { "Ablak", "Tenger", "Pillangó", "Könyv", "Virág", "Házikó", "Számít", "Utazás", "Kertész", "Napfény", "Madarak", "Hegyek", "Csendes", "Barátok", "Iskola", "Város", "Tavasz", "Gyümölcs", "Szélben", "Kézzel" };
            Random rnd = new Random();
            string randomszo = szavak[rnd.Next(0, szavak.Length)];
            int hossz = randomszo.Length;
            string kiirszo = "_";
            bool hamis = false;
            int tippek = 5;
            Console.WriteLine("AKASZTÓFA\n\n\n");
            string kiirszoalak = "";
            string allapot = "";
            string nemtalaltb = "" ;
            for (int i = 0; i < hossz; i++)
            {
                kiirszoalak += kiirszo;
                
            }
            do
            {
                Console.WriteLine(allapot);
                Console.Write($"Nem talált betűk: {nemtalaltb}\n\n\n\n");
                for (int i = 0; i < hossz; i++)
                {
                    Console.Write(kiirszoalak[i] + " ");
                }
                Console.WriteLine($"\nMaradt tippek: {tippek}");





                Console.Write("\nKérem, adjon meg egy betűt (Kilépéshez nyomjon entert): ");
                string tipp = Console.ReadLine();
                if (tipp == "")
                {
                    Console.Clear();
                    Console.WriteLine("Viszlát!");
                    break;
                }
                else if (tipp.Length > 1)
                {
                    allapot = "Egyszerre csak egy betűt írjon!\n\n\n";
                }
                else if (tipp.Length < 2 && randomszo.Contains(tipp))
                {
                    allapot = "\n\nEltaláltad!\n\n\n";
                    for (int i = 0; i < hossz; i++)
                    {
                        if (randomszo[i] == tipp[0])
                        {
                            kiirszoalak = kiirszoalak.Insert(i, tipp).Remove(i + 1, 1);
                        }
                    }
                }
                else
                {
                    tippek -= 1;
                    nemtalaltb += tipp;
                   allapot = "Nem talált!\n\n\n";

                }
                
                if (tippek == 0)
                {
                    Console.Clear();
                    Console.WriteLine($"Vesztettél! A szó a(z) {randomszo} volt");
                    break;
                }
                if (kiirszoalak == randomszo)
                {
                    Console.Clear();
                    Console.WriteLine($"Gratulálok, kitaláltad!");
                    break;
                }
                Console.Clear();
            } while (!hamis);
            
        }
    }
}
