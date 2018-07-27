using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena3
{
    public class Auto
    {
        public string Marka;

        public string Krasa;

        public string Informacija()
        {
          

            return " Marka ir " + this.Marka + ", Krasa ir " + this.Krasa + ".";
            
        }
       
        
    }
}
