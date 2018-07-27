using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            

        }
        static void piemeri()
        {
            int[] skaitli = new int[3];
            skaitli[0] = 1;
            skaitli[1] = 4;
            skaitli[2] = 6;
            //skaitli[3] = 7;
            //izmetis kludu: IndexOutOfRange

            string[] vardi = new string[2];
            int pozicija = 0;
            vardi[pozicija] = "vards 1";
            pozicija++;
            vardi[pozicija] = "vards 2";

            int[] skaitli2 = new int[] { 1, 4, 6 };
            int[] skaitli3 = { 1, 4, 6 };

            for ( int i =0; i <skaitli2.Length; i++)
            {
                Console.WriteLine(skaitli2[i]);

                // i = 0 -> izvada 1
                // i = 1 -> izvada 4
                // i = 2 -> izvada 6
            }
            foreach(int vertiba in skaitli2)
            {
                Console.WriteLine(vertiba);

            }

        }
    }
}
