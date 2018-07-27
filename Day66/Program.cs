using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day66
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uzdevumi.skaitluIevade();
           // Uzdevumi.Uzdevums2();
            Uzdevumi.Uzdevums4();
            Console.ReadLine();

        }
        static void piemeri()
        {
            

                int[] skaitli = new int[3];
                skaitli[0] = 1;
                skaitli[1] = 4;
                skaitli[2] = 6;

                string[] vardi = new string[2];
                int pozicija = 0;
                vardi[pozicija] = "vards 1";
                pozicija++;
                vardi[pozicija] = "vards 2";

                int[] skaitli2 = new int[] { 1, 4, 6 };
                int[] skaitli3 = { 1, 4, 6 };

                for (int i = 0; i < skaitli2.Length; i++)
                {
                    Console.WriteLine(skaitli2[i]);
                    //i = 0 -> izvada 1
                    //i = 1 -> izvada 4
                    //i = 2 -> izvada 6

                }

                foreach (int vertiba in skaitli2)
                {
                    Console.WriteLine(vertiba);
                }
        }  
        static void piemers2()
        {
            int[] masivs = new int[3];
            List<int> saraksts = new List<int>();
            saraksts.Add(5);
            saraksts.Add(29);
            saraksts.Add(30);

            foreach (int skaitlis in masivs)
            {
                Console.Write(skaitlis);
            }
            for (int i = 0; i< saraksts.Count; i++)
            {
                Console.Write(saraksts[i]);
            }
        }
        List<string> vardi = new List<string>()
        {
            "vards1",
            "vards2",
            "vards3"
        };   
       // vardi.Add("vards4");

     


    }
}
