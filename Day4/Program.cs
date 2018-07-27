using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uzdevumi.Skaitlilidz10();
            // Uzdevumi.DzimsanasGadi();
            //Uzdevumi.NKvadrats();
            //Uzdevumi.NSumma();
            //Uzdevumi.NNsumma();
            // Uzdevumi.Kvadrats();

            // Uzdevumi.Trijsturis();
            // Uzdevumi.Dimants();
            Program.Piemeri();
            Console.ReadLine();

        }
        public static void Piemeri()
        {
            for (int i = 1; i <= 10; i++)
            //for (int i = 1; i <= 10; i= i + 1)
            {
                Console.WriteLine(i);
            }
            Console.Write("Ievadi paroli ");
            string parole = Console.ReadLine();
            int meiginajumi = 0;
            while(parole != "pass123" && meiginajumi <5)
            {
                //if(meiginajumi >5)
               // {
                 //   break;
              //  }


                meiginajumi++;
                Console.WriteLine("Nepareiza parole!");
                parole = Console.ReadLine();

            }
            if(meiginajumi  < 5)
            {
                Console.WriteLine("Parole Pareiza");
            }
            else
            {
                Console.WriteLine("esi aizmirsis paroli");
            }
            Console.ReadLine();
        }
    }
}
