using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Piemers();
            //uzdevums1();
            //uzdevums2();
            Auto auto1 = new Auto();
            auto1.Krasa = " melna";
            auto1.Marka = " BMW";
            Console.WriteLine(auto1.Informacija());
            Auto auto2 = new Auto();
            auto2.Krasa = " Sarkans";
            auto2.Marka = " Audi";
            Console.WriteLine(auto2.Informacija());

            Kvadrats  Kvadrats1 = new Kvadrats ();
            Kvadrats1.Krasa = " Sarkans";
            Kvadrats1.MalasGarums  = 5;
            Kvadrats1.Laukums();
            Kvadrats1.Perimetrs();
            Kvadrats1.KrasasIzvade();

            Kvadrats Kvadrats2 = new Kvadrats();
            Kvadrats2.Krasa = " Melns";
            Kvadrats2.MalasGarums = 13;
            Kvadrats2.Laukums();
            Kvadrats2.Perimetrs();
            Kvadrats2.KrasasIzvade();

            Taisnsturis Taisnsturis1 = new Taisnsturis(4, 6);
            //Taisnsturis1.Mala1 = 10;
            //Taisnsturis1.Mala2 = 20;

            Taisnsturis1.Laukums();












            Console.ReadLine();

        }

        static void Piemers()
        {
            Console.Write("ievadi menesi");
            string menesis = Console.ReadLine().ToLower();

            switch(menesis)
            {
                case "jan":
                    Console.WriteLine("31 diena");
                    Console.WriteLine("janvaris");
                    break;
                case "apr":
                case "maj":
                case "jun":
                case "sep":
                    Console.WriteLine("30 dieans");
                    if (menesis == "maj")
                    {
                        Console.WriteLine("maijs");
                    }
                    // nekad neizpildiesies, jo nav case par februari.
                    if (menesis == "feb")
                    {
                        Console.WriteLine("februaris");
                    }
                    break;
                default:
                    Console.WriteLine("nezinams menesis");
                    break;



            }
            

        }
        static void uzdevums1()
        {
            Console.WriteLine("Ievadi valsti");
            String valsts = Console.ReadLine().ToLower();

            switch(valsts)
            {
                case "igaunija":
                    Console.WriteLine("Igaunijas galvaspilseta ir Talina");
                    break;
                case "somija":
                    Console.WriteLine("Somijas galvaspilseta ir Helsinki");
                    break;
                case "ukraina":
                    Console.WriteLine("Ukrainas galvaspilseta ir Kijeva");
                    break;
                case "zviedrija":
                    Console.WriteLine("Zviedrijas galvaspilseta ir Stokholma");
                    break;
                case "krievija":
                    Console.WriteLine("Krievijas galvaspilseta ir Maskava");
                    break;
                default:
                
                    Console.WriteLine("nezinama valsts");
                    break;
            }
        }
        static void uzdevums2()
        {
            Console.WriteLine("ievadi pirmo skaitli");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ievadi otro skaitli");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ievadi velamo darbibu");
            char darbiba = Convert.ToChar(Console.ReadLine());
            // ja lieto " char" tad pec case lieto ' pedinas
            double skr;
            switch (darbiba)
            {
                case '+':
                     skr = sk1 + sk2;
                   
                    break;
                case '-':
                     skr = sk1 - sk2;
                    
                    break;
                case '*':
                     skr = sk1 * sk2;
                   
                    break;
                case '/':
                    skr = sk1 / sk2;
                    
                    break;
                default:
                    Console.WriteLine("nezinama darbiba");
                   return;
                    //break aptur, return partrauc. vainu vainu.
            }
            Console.WriteLine("rezultats ir " + skr);
        }

        
        

        
    }

}
