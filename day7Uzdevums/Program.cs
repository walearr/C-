using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7Uzdevums
{
    class Program
    {
        //1. precu saraksts
        static List<Prece> preces = new List<Prece>()
           {
            new Prece("dators", 900),
            new Prece("bikses", 50),
            new Prece("auto", 10000),
            new Prece("mobilais",200),
            new Prece("tv",550),
            new Prece("koferis",100),
            new Prece("cimdi",20),
            new Prece("cepure",10),
            };
        //static List<Prece> grozs = new List<Prece>();
        static void Main(string[] args)
        {
            //2.jaizvada visas pieejamas preces ( foreach()  )
            //3.cikliski javaica ievadit preces nosaukumu  (   \(true)  )
            //4. ja ievada "0" , partrauc ciklu un izvada summu

            Console.WriteLine("Pieejamas preces: ");
            foreach(Prece prece in preces)            
            {
                Console.WriteLine("{0}, cena = {1}", prece.Nosaukums, prece.Cena);
            }
            int summa = 0;
            while (true)
            {
                Console.WriteLine("Ievadiet interesejosas preces ");
                string Pirkums = Console.ReadLine().ToLower();               
                if (Pirkums == "0")
                {
                    break;
                }              
                foreach(Prece prece in preces)
                {
                    if(Pirkums == prece.Nosaukums)
                    {
                        
                        summa += prece.Cena;
                        break;
                    }
                }                                                                 
            }
            Console.WriteLine("Kopeja summa: " + summa);
            Console.ReadLine();

           // summa = 0;
            //foreach (Prece prece in grozs)
           // {
             //   summa += prece.Cena;
           //     Console.Write("Tu nopirmi " + prece.Nosaukums);
           // }
         //   Console.WriteLine("Summa = {0}", summa);
          //  }
        }
    }
}
