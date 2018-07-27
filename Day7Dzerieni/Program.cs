using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzerienuAutomats
{
    class Program
    {
        static void Main(string[] args)
        {
            Automats automats = new Automats();

            while(true)
            {
                Console.WriteLine("Ievadiet velamo darbibu");
                Console.WriteLine("Jusu piejamas opcijas ir: Iemaksat, Pirkts un  atlikums");
                string D = Console.ReadLine().ToLower();
                switch(D)
                {
                    case "pirkt":
                        automats.PirktDzerienu();
                        break;
                    case "iemaksat":
                        Console.WriteLine("Kadu summu velaties iemaksat?");
                        int Summa = Convert.ToInt32(Console.ReadLine());
                        automats.Iemaksat(Summa);
                        break;
                    case "atlikums":
                        automats.SanemtAtlikumu();
                        break;
                    default:
                        return;


                }
            }



        }
    }
}
