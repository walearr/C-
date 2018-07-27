using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena11
{
    class ManaPirmaKlase
    {
        public void TekstaIzvade()
        {
            Console.Write("vards ");
            Console.WriteLine("cits vards un jauna rinda");

            string teksts = "teksts no mainiga";
            Console.WriteLine(teksts);
        }
        public void Tekstaievade()
        {
            Console.WriteLine("ievadi skaitli");
            string vertiba = Console.ReadLine();

            Console.WriteLine("tu ievadiji " + vertiba);
        }
    }

}
