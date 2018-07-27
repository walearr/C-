using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darbinieks
{
    class Adrese
    {
        public string Valsts;

        public string pilseta;
        public string iela;
        public int Majasnr;
        public int DzivoklaNr;
        public void pilnaAdrese()
        {
            Console.WriteLine(Valsts + " " + pilseta + " " + iela + " Iela " + Majasnr + " " + DzivoklaNr);
        }

    }
}
