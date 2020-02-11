using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_e_Oggetti
{
    class animale
    {
       
       public string tipo 
        {
            get 
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value + "animale da definire";
            } 
        } 
        public int zampe { get; set; }

        public bool pelo { get; set; }

        public string verso { get; set; }

        public void carAnimale()
        {
            Console.WriteLine("il " + this.tipo + "fa questo verso " + this.verso);

            if (pelo)
            {
                Console.WriteLine("ha il pelo");
            }
            else
            {
                Console.WriteLine("non ha pelo");
            }
        }

        public void scambio(string carat1, string carat2)
        {
            string temp = carat2;
            carat2 = carat1;
            carat1 = temp;

        }
    }
}
