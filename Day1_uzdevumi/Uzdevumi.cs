using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_uzdevumi
{
    class Uzdevumi
    {
        public void vardaievade()
        {
            Console.WriteLine("Ka tevi sauc?");
            string vards = Console.ReadLine();

            Console.WriteLine("tevi sauc " + vards);
        }
        public void SkaitluSumma()
        {

            Console.WriteLine("Ievadi pirmo skaitli");
            string Skaitlis1 = Console.ReadLine();
            Console.WriteLine("Ievadi otro skaitli");
            string Skaitlis2 = Console.ReadLine();

            int sk1 = Convert.ToInt32(Skaitlis1);
            int sk2 = Convert.ToInt32(Skaitlis2);
            int rezultats = sk1 + sk2;
            Console.WriteLine("Summa = " + rezultats);
        }
        public void SkaitluSumma2()
        {
            Console.WriteLine("Ievadi pirmo skaitli");
            string Skaitlis1 = Console.ReadLine();
            Console.WriteLine("Ievadi otro skaitli");
            string Skaitlis2 = Console.ReadLine();

            int sk1 = Convert.ToInt32(Skaitlis1);
            int sk2 = Convert.ToInt32(Skaitlis2);
            int rezultats1 = sk1 + sk2;
            Console.WriteLine("Summa = " + rezultats1);
            int rezultats2 = sk1 - sk2;
            Console.WriteLine("Starpiba = " + rezultats2);
            int rezultats3 = sk1 * sk2;
            Console.WriteLine("rezinajums = " + rezultats3);
            int rezultats4 = sk1 / sk2;
            Console.WriteLine("Dalijums = " + rezultats4);
            int rezultats5 = sk1 % sk2;
            Console.WriteLine("Dalijuma atlikums = " + rezultats5);

        }

        public void SkaitlusDalisana()
        {
            Console.WriteLine("Ievadi skaitli");
            int sk6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ievadi otro skaitli");
            int sk7 = Convert.ToInt32(Console.ReadLine());
            // "double" lauj dabut decimal skaitli un vismaz 1 no skaitliem ko dala jabut decimalskaitlim
            double dalijums = (double)sk6 / sk7;
            Console.WriteLine(" Dalijums = " + dalijums);

        }
        public void Uzdevums4()
        {
            Console.WriteLine("ievadi pirmo skaitli");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ievadi otro skaitli");
            int sk2 = Convert.ToInt32(Console.ReadLine());

            int vecavertiba = sk1;
            sk1 = sk2;
            sk2 = vecavertiba;

            Console.WriteLine(" skaitlis1 = " + sk1);
            Console.WriteLine(" skaitlis2 = " + sk2);
        }
        public void Uzdevums5()
        {
            Console.WriteLine("ievadi gradus pec Celsija:");
            int Sk1 = Convert.ToInt32(Console.ReadLine());

            Double Sk2 = Sk1 + (double)273.15;
            Double Sk3 = Sk1 * (double)1.8 + 32;

            Console.WriteLine("gradi pec kelvina = " + Sk2 + "K");
            Console.WriteLine("gradi pec Farenheita = " + Sk3 + "F");

        }
    }
}
