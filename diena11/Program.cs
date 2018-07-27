using System;

namespace Diena11
{
    class Program
    {
        static void Main(string[] args)
        {
            int rezultats1 = SkaitlaIzvade();
            int rezultats2 = SkaitlaKapinasana(10);
            int rezultats3 = SkaitlaKapinasana(rezultats2);

            // izvadis: rezultats1 = 5
            Console.WriteLine("rezultats1 = " + rezultats1);
            // izvadis: rezultats2 =100
            Console.WriteLine("rezultats2 = " + rezultats2);
            // izvadis: rezultats3 =10000
            Console.WriteLine("rezultats3 = " + rezultats3);

            //funkcijas no citam klasem
            ManaPirmaKlase klase = new ManaPirmaKlase();
            klase.TekstaIzvade();
            klase.Tekstaievade(); 
            
            //nopauzet logu
            Console.ReadLine();
        }

        static int SkaitlaIzvade()
        {
            return 5;
        }
        static int SkaitlaKapinasana(int skaitlis)
        {
            return skaitlis * skaitlis;
        }
    }
}
