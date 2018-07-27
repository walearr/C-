using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena3
{
    public class Kvadrats
    {
        public int MalasGarums;
        public string Krasa;
        public int Laukums()
        {
            int Laukums = MalasGarums * MalasGarums;
            Console.WriteLine("Laukums ir " + Laukums);
            return Laukums;
        }
        public void Perimetrs()
        {
            Console.WriteLine("Perimetrs ir " + MalasGarums * 4);

        }
        public void KrasasIzvade()
        {
            Console.WriteLine("Krasa ir " + Krasa);
        }
    }
}
