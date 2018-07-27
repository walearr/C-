using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_uzdevumi
{
    class Program
    {
        static void Main(string[] args)
        {
            Uzdevumi klase = new Uzdevumi();
            klase.vardaievade();
            Console.ReadLine(); 

            Uzdevumi klase2 = new Uzdevumi();
            klase2.SkaitluSumma();
            Console.ReadLine();

            Uzdevumi klase3 = new Uzdevumi();
            klase3.SkaitluSumma2();
            Console.ReadLine();

            Uzdevumi klase4 = new Uzdevumi();
            klase4.SkaitlusDalisana();
            Console.ReadLine();

            Uzdevumi klase5 = new Uzdevumi();
            klase5.Uzdevums4();
            Console.ReadLine();

            Uzdevumi klase6 = new Uzdevumi();
            klase6.Uzdevums5();
            Console.ReadLine();
        }

    }
}
