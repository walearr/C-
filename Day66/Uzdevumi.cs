using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day66
{
    class Uzdevumi
    {
        public static void skaitluIevade()
        {
            Console.WriteLine("Ievadi cik skailus dosi");
            int SK = Convert.ToInt32(Console.ReadLine());

            int[] masivs = new int[SK];

            for (int i = 0; i < SK; i++)
            {
                Console.Write("Ievadi skaitli: ");
                masivs[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(masivs[i]);
            }
            foreach (int skaitlis in masivs)
            {
                Console.WriteLine(skaitlis);

            }
            for (int i = masivs.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(masivs[i]);
            }



        }
        public static void Uzdevums2()
        {
            int[] Masivs = { 0, 10, 20, 30, 40, 50 };
            Console.WriteLine("Ievadi interesjuso skaitli");
            int Skaitlis = Convert.ToInt32(Console.ReadLine());
            bool vaiSkaitlisIrAtrasts = false;
            int i;
            for (i = 0; i < Masivs.Length; i++)
            {
                if (Skaitlis == Masivs[i])
                {

                    vaiSkaitlisIrAtrasts = true;
                    break;
                }


            }
            if (vaiSkaitlisIrAtrasts == true)
            {
                Console.WriteLine("Interesejusais skaitlis atrodas masiva, " + i + "pozicija");

            }
            else
            {
                Console.WriteLine("Skaitlis nav atrasts");

            }


        }
        //public static void Uzdevums3()
        // {
        //int[] Masivs = { 0, 10, 20, 30, 40, 50 };
        //Console.WriteLine("Ievadi interesjuso skaitli");
        // int Skaitlis = Convert.ToInt32(Console.ReadLine());
        //for (int 1 = 0; i < Masivs.Length; i++)
        //{
        //if (Skaitlis == Masivs[i])
        // {
        //Console.WriteLine("Interesejusais skaitlis atrodas masiva, " + i + "pozicija");
        //return;
        // }
        // }
        //Console.WriteLine("Skaitlis nav atrasts");

        //}
        public static void Uzdevums4()
        {

            Console.WriteLine("ievadi cik skaitlus ievadisi?");
            int Skaitlis = Convert.ToInt32(Console.ReadLine());
            int[] masivs = new int[Skaitlis];

            int i;
            for (i = 0; i <= Skaitlis; i++)
            {
                Console.WriteLine("Ievadi skaili");
                masivs[i] = Convert.ToInt32(Console.ReadLine());
            }
            int pieciskaititajs = 0;
            foreach (int skaitlis in masivs)
            {
                if (skaitlis == 5)
                {
                    pieciskaititajs++;
                }
            }
            if (pieciskaititajs == 0)
            {
                Console.WriteLine("Skaitlis 5 netika atrasts");
            }
            else
            {
                Console.WriteLine("Skaitlis 5 tika atrasts {0} reizes", pieciskaititajs);
            }








        }
        public static void Uzdevums5()
            {
            //1. Aizpilda sarakstu/masivu
            //2. atrod mazako skaitli masiva/saraksta
            //3. atrod lielako skaitli masiva/saraksta
            //4. izvada atrastas vertibas
            




            }

    

    
        


        

    }
}
