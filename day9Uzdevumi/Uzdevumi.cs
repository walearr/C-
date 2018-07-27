using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day9Uzdevumi
{
    class Uzdevumi
    {
       
        public static void Uzdevums1()
        {
            Console.WriteLine("Ievadiet pirmo skaitli");
            double A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadiet otro skaitli");
            double B = Convert.ToInt32(Console.ReadLine());
            double q = A + B;
            double w = A - B;
            double e = A * B;
            double r = A / B;
            double t = A + B / 2;            
            Console.WriteLine("skaitlu summa ir {0}, skaitlu starpiba ir {1}, skaitlu reizinajums ir {2}, skaitlu dalijums ir {3}", q, w, e, r);                           
            if (A > B)
            {
                double y = A;
                double u = B;
                Console.WriteLine("Lielakais skaitlis ir {0} un mazakais skaitlis ir {1}", A, B);
            }
            else if (B > A)
            {
                double y = B;
                double u = A;
                Console.WriteLine("Lielakais skaitlis ir {0} un mazakais skaitlis ir {1}", B, A);
            }
            else
            {
                Console.WriteLine("Abi skaitli ir vienadi");
            }
            Console.WriteLine("Abu skaitlu videja vertiba ir {0}", t);

        }
        public static void Uzdevums2()
        {
            Console.WriteLine("Ievadiet pirmo skaitli");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadiet otro skaitli");
            int B = Convert.ToInt32(Console.ReadLine());
            for (int i = A; i <= B; i++)
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }               
            }

        }
        public static void Uzdevums3()
        {
            int[] skaitli = new int[] {1,2,3,4,5,6,7,8,9,10};
           
            for (int i = 0; i < skaitli.Length; i++)
            {
                if (skaitli[i] != 10)
                {
                    List<int> skaitlis2 = new List<int>();
                    skaitlis2.Add(skaitli[i]);
                    Console.WriteLine("Pievieno {0} jaunajam masivam", skaitli[i]);
                }               
            }
        }
        public static void Uzdevumi4()
        {
            Console.WriteLine("Ievadiet pirmo skaitli");
            int A = Convert.ToInt32(Console.ReadLine());
            int summa = 0;
                      
            while (A != 0 )
            {
                summa += A % 10;
                A /= 10;
            }
            Console.WriteLine(summa);
        }
        public static void Uzdevums5()
        {
            List<int> skaitli = new List<int>()
        {
            1,2,3,4,5,6,7,8,9,0           
        };
            int RNG = new Random().Next(skaitli.Count);
            int randomVariants = skaitli[RNG];
            Console.WriteLine("Ievadi pirmo minejumu");
            int A = Convert.ToInt32(Console.ReadLine());
            while (A != randomVariants)
            {
                if (A > randomVariants)
                {
                    Console.WriteLine("ievaditais skaitlis ir lielaks par mekleto");
                    
                    
                }
                else if (A < randomVariants)
                {
                    Console.WriteLine("ievaditais skaitlis ir mazaks par mekleto");
                    
                }
                 A = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("esat atradis mekleto skaitli");
            return;

        }
        public static void Uzdevums6()
        {

        }

    }
}
