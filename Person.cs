using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_e_Oggetti
{
    class Person
    {
        public string nome { get; set; }
        public string cognome { get; set; }
        public int eta { get; set; }


        public void parla()
        {
            Console.WriteLine("mi chiamo " + this.nome + " " + this.cognome);
            Console.WriteLine("ho " + this.eta + " anni");
        }
    }
}
