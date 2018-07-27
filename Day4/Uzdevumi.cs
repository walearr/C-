using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Uzdevumi
    {
        public static void Skaitlilidz10()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Skaitlis = " + i);
            }
        }
        public static void DzimsanasGadi()
        {
            Console.WriteLine("Ievadi gadu kura esi dzimis ");
            int i = Convert.ToInt32(Console.ReadLine()); 
            for (int g = i; g <= DateTime.Now.Year; g++)
            {
               
                Console.WriteLine(g + ".Gads");
            }
            for (int g = DateTime.Now.Year; g >= i; g--)
            {
                Console.WriteLine(g + ".Gads");
            }

        }
        public static void NKvadrats()
        {
            Console.WriteLine("Ievadi velamo skaitli");
            int k = Convert.ToInt32(Console.ReadLine());
          
            for (int i = 1; i <= k; i++)
            {
               
             Console.WriteLine(" = " + i * i);
            }
        }
        public static void NSumma()
        {
            Console.WriteLine("Ievadi velamo skaitli");
            int N = Convert.ToInt32(Console.ReadLine());
            int summa = 0;
           for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(i);
                summa = summa + i; 
                // vai:
                // Summa += 1;
            }

            Console.WriteLine("Summa = " + summa);

                
        }
        public static void NNsumma()
        {
            Console.WriteLine("Ieavdi cik skaitlus");
            int M = Convert.ToInt32(Console.ReadLine());
            int summa = 0;
            for (int i = 1; i <= M; i++)
            {
                Console.WriteLine("Ievadi {0} skaitli", i);
                int skaitlis = Convert.ToInt32(Console.ReadLine());
                summa += skaitlis;

            }
            Double videja = (double)summa / M;
            Console.WriteLine("Summa = {0}", summa);
            Console.WriteLine("videja vertiba = {0}", videja);

        }
        public static void Kvadrats()
        {
            Console.WriteLine("Ievadi kvadrata malu garumu");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                for(int g = 1; g <= N; g++)
                {
                    Console.Write("#");
                    
                }
                Console.WriteLine();
                
                

            }
        }
        public static void Trijsturis()
        {
            Console.Write("Ievadi trijstura malu garumu ");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            for (int i = N - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        public static void Dimants()
        {
            Console.Write("Ievadi dimanta lielumu kur dimants it 2*N-1 liels ");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                
            }
        }

    }
}
