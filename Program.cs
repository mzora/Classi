using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_e_Oggetti
{
    class Program
    {
        static void Main(string[] args)
        {
   
            Person pers_1 = new Person();
            pers_1.nome = "Gianca";
            pers_1.cognome = "Magalli";
            pers_1.eta = 66;

            //pers_1.parla();

            animale anim_1 = new animale();
            anim_1.tipo = "cane";
            //anim_1.pelo = true;
            //anim_1.verso = "bau";

            animale anim_2 = new animale();
            anim_2.tipo = "gatto";

            
            //anim_1.carAnimale();

            //scambio(anim_1.tipo, anim_2.tipo);
            // o era meglio: anim_1.scambio(anim_2.tipo)

            
            Console.ReadKey();
        }
        static void faiQualcosa(animale anim)
        {
            //es funzione su oggetto completo
        }

        static void faiAltroConStringa(string nome)
        {
            //es funzione su proprietà oggetto
        }

        static bool confermaCarat(string nome)
        {
            if(nome == "fedele")
            {
                return true;
            }
            return false;
        }


    }
}
