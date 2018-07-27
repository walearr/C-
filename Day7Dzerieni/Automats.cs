using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzerienuAutomats
{
    public class Automats
    {
        public double iemaksataSumma;

        public Automats()
        {
            iemaksataSumma = 0;
        }

        public void Iemaksat(double Summa)
        {
            
            iemaksataSumma += Summa;
        }
        public void PirktDzerienu()
        {
            if (iemaksataSumma < (double)0.80)
            {
                Console.WriteLine("Nepietiek lidzeklu");
            }
            else
            {
                iemaksataSumma -= (double)0.80;
                Console.WriteLine("Atlikums = " + iemaksataSumma);

            }
        }
        public void SanemtAtlikumu()
        {
            Console.WriteLine("Tiek atgriezts atlikums {0} vertiba", iemaksataSumma);
            iemaksataSumma = 0;
        }
        
        

    }
}
