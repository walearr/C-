using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtraDiena
{
    class Uzdevumi2
    {
        public void uzdevums1()
        {
            Console.WriteLine("Ievadi 1 skaitli");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ievadi 2 skaitli");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            if(sk1 == sk2)
            {
                Console.WriteLine("Ievaditie skaitli ir vienadi");
            }
            else
            {
                Console.WriteLine("ievaditie skaili NAV vienadi");
            }
            Console.ReadLine();
        }
        public void uzdevums2()
        {
            Console.WriteLine("Kur's menesis tevi intrese?");
            string menesis = Console.ReadLine();
            menesis = menesis.ToLower();
            if (menesis == "februaris")
            {
                Console.WriteLine("dotaja menesi ir 28 diena");
            }
            else if(menesis == "aprilis")
            {
                Console.WriteLine("dotaja menesi ir 30 dienas");
            }

            else if (menesis == "junijs")
            {
                Console.WriteLine("dotaja menesi ir 30 dienas");
            }
            else if (menesis == "septembris")
            {
                Console.WriteLine("dotaja menesi ir 30 dienas");
            }
            else if (menesis == "novembris")
            {
                Console.WriteLine("dotaja menesi ir 30 dienas");
            }
            else 
            {
                Console.WriteLine("dotaja menesi ir 31 dienas");
            }
        }
        public void uzdevums3()
        {
            Console.WriteLine("Ievadi mervienibu");
            string mervieniba = Console.ReadLine().ToUpper();

            Console.WriteLine("ievadi gradus");
            int gradi = Convert.ToInt32(Console.ReadLine());
            if (mervieniba == "F")
            {
                double gradi2 = (double)(gradi - 32) / (double)1.8;
                Console.WriteLine(gradi2 + "C");
            }
            else if (mervieniba == "C")
            {
                double gradi3 = gradi * (double)1.8 + (double)32;
                Console.WriteLine(gradi3 + "F");
            }
            else
            {
                Console.WriteLine("nezinama mervieniba");
            }
        }

        public void uzdevums4()
        {
            Console.WriteLine("ievadi atalumu (metros)");
            int metri = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ievadi cik stundas pavadi cela");
            int stundas = Convert.ToInt32(Console.ReadLine());
            if (stundas > 60)
            {
                Console.WriteLine("nepareizs laika formats");
            }
            Console.WriteLine("ievadi cik minutes pavadi cela");
            int minutes = Convert.ToInt32(Console.ReadLine());
            if (minutes > 60)
            {
                Console.WriteLine("nepareizs laika formats");
            }
                Console.WriteLine("ievadi cik sekundes pavadi cela");
            int sekundes = Convert.ToInt32(Console.ReadLine());
            if (stundas > 60)
            {
                Console.WriteLine("nepareizs laika formats");
            }

            int koplaiks = (stundas * 3600) + minutes * 60 + sekundes;
            Console.WriteLine(" cela kopa pavadiji " + koplaiks + " sekundes");
            int atrums = metri / koplaiks;
            Console.WriteLine("Videjais atrums tev bija " + atrums);
            int kilometri = metri / 1000;
            Console.WriteLine("Tas ir " + kilometri + " kilomentri");
            Double kopstundas = (Double) koplaiks / 3600;

            Double kmh = kilometri / (Double) kopstundas;
            Console.WriteLine("taves videjais atrums bija " + kmh + " km/h");
            Double judzes = (Double) kilometri * 0.621371;
            Console.WriteLine("Tas ir " + judzes + " judzes");


        }
        


    }

}
