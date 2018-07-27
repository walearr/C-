using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtraDiena
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uzdevumi2 klase1 = new Uzdevumi2();
            //klase1.uzdevums1();
            //Console.ReadLine();

            //Uzdevumi2 klase2 = new Uzdevumi2();
            //klase2.uzdevums2();
            //Console.ReadLine();

            //Uzdevumi2 klase3 = new Uzdevumi2();
            //klase3.uzdevums3();
            //Console.ReadLine();

            Uzdevumi2 klase4 = new Uzdevumi2();
            klase4.uzdevums4();
            Console.ReadLine();
        }
        static void Piemers(string[] args)
        {
            int Sk1 = 100;
            if(Sk1 < 100)
            {
                Console.WriteLine("Skaitlis ir mazaks par 100");
            }
            else if (Sk1 == 100)
            {
                Console.WriteLine("skaitlis vienads ar 100");
            }
            else
            {
                Console.WriteLine("skaitlis ir lielaks par 100");
            }
            if(Sk1 == 0)
            {
                Console.WriteLine("skaitlis ir 0");
            }
            Console.ReadLine();
            
        }
    }
}
