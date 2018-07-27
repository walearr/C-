using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena3
{
    public class Taisnsturis
    {
        private  int Mala1;
        private  int Mala2;
        public Taisnsturis(int mala1, int Mala2)
        {
            Mala1 = mala1;
            this.Mala2 = Mala2;
        }
        public void Laukums()
        {
            Console.WriteLine(" Taisnstura Laukums = " + (Mala1 + Mala2));
        }
    }
}
