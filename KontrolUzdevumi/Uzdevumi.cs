using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolUzdevumi
{
    class Uzdevumi
    {
        public static void Uzdevums1()
        {
            Console.Write("Ievadi Skaitli N ");
            int N = Convert.ToInt32(Console.ReadLine());



            for (int i = N; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
        public static void Uzdevums2()
        {
            Console.WriteLine("Ievadi interesejoso dienu");
            String D = Console.ReadLine().ToLower();
            Console.WriteLine("Vai interesejosa diena ir atvalinajuma");
            String A = Console.ReadLine().ToLower();

            if (A == "ja")
            {
                switch (D)
                {
                    case "se":
                    case "sv":
                        Console.WriteLine("Modinatajam nav jazvana");
                        break;
                    case "p":
                    case "o":
                    case "t":
                    case "c":
                    case "pk":
                        Console.WriteLine("Modinatajam jazvana Plkst: 10:00");
                        break;
                    default:
                        Console.WriteLine("nezinama nedelas diena");
                        break;
                }
            }
            else if (A == "ne")
            {
                switch (D)
                {
                    case "se":
                    case "sv":
                        Console.WriteLine("Modinatajam jazvana Plkst: 10:00");
                        break;
                    case "p":
                    case "o":
                    case "t":
                    case "c":
                    case "pk":
                        Console.WriteLine("Modinatajam jazvana Plkst: 7:00");
                        break;
                    default:
                        Console.WriteLine("nezinama nedelas diena");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Nav zinams vai artodaties atvalinajuma");

            }
        }
        public static void Uzdevums3()
        {
            Console.WriteLine("Vai Personai ir Dzimsanas diena?");
            String D = Console.ReadLine().ToLower();
            Console.WriteLine("Ar kadu atrumu Persona devas?");
            int A = Convert.ToInt32(Console.ReadLine());
            if (D == "ja")
            {
                if (A <= 65)
                {


                    Console.WriteLine("Persona netiek sodita");
                }
                else if (A > 80)
                {
                    Console.WriteLine("Persona tiek sodita ar 2 Soda meru");
                }
                else
                {
                    Console.WriteLine("Persona tiek sodita ar 1 Soda meru");

                }
            }
            else if (D == "ne")
            {


                if (A <= 60)
                {


                    Console.WriteLine("Persona netiek sodita");
                }
                else if (A > 80)
                { 
                Console.WriteLine("Persona tiek sodita ar 2 Soda meru");
            }
                    else
                { 
                        Console.WriteLine("Persona tiek sodita ar 1 Soda meru");
                        
                }
            }
            else
            {
                Console.WriteLine("Neesat pareizi noradijis vai personai ir dzimsanas diena");
            }
        }
        public static void Uzdevums4()
        {
            Console.WriteLine("Ievadiet pirmo vertibu");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadiet otro vertibu");
            int B = Convert.ToInt32(Console.ReadLine());
           
         
            for (int i = A; i <= B; i++)
         
            {
               
                
                  if (i% 3 == 0 && i% 5 ==0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }




            }
         
        }
        public static void uzdevums5()
        {
            Console.WriteLine("Ievadiet skaitli");
            int summa = 0;
            int A = Convert.ToInt32(Console.ReadLine());
            summa = summa + A;
            while (A != 13)
                {
                Console.WriteLine("diemzel neesat atradis isto ciparu, meiginiet velreiz");
                A = Convert.ToInt32(Console.ReadLine());
                summa = summa + A;
             

            }

            Console.WriteLine("Apsveicu, esat atradis isto ciparu, kopeja nepareizu numuru summa ir " + (summa - 13));

        }
        public static void Uzdevums6()
        {
            Console.WriteLine(" Ieavdiet pirmo skaitli");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Ieavdiet otro skaitli");
            int B = Convert.ToInt32(Console.ReadLine());
            if (A > 21)
            {
                A = 0;
            }
            else if (B > 21)
            {
                B = 0;
            }


            if (A > B && A != 0)
            {
                Console.WriteLine("Tuvaks ciparam 21 bija ievaditais skaitlis " + A);
            }
            else if (B > A && B != 0)
            {
                Console.WriteLine("Tuvaks ciparam 21 bija ievaditais skaitlis " + B);
            }
            else if (A == B)
            {
                Console.WriteLine("Abi ievaditie skaitli ir vienlidz tuvu 21");
            }
            else
            {
                Console.WriteLine("Abi skaitli ir lielaki par 21");
            }
            

            
            
        }
    }
}






                






            













        






                


















            
        
        
       
    

