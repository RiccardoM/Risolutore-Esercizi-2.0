/// <summary>
/// Questa classe serve per generare casualmente dei dati per il pannello Ext2fs.
/// Dopo aver generato i dati vengono inoltre compilate le variabili pubbliche del form ext2fsForm che le usa per compilare i vari TextBox.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisolutoreEsercizi {

    class ext2fsGenerate {

        //Genera dati casuali
        public void generate() {

            //Variabile casuale
            Random rndm = new Random();

            //Genera valori della variabili pubbliche
            ext2fsForm.dimParText = Math.Pow(2, rndm.Next(4, 11)).ToString();
            ext2fsForm.dimBloccoText = Math.Pow(2, rndm.Next(0, 7)).ToString();
            ext2fsForm.dimInodeText = Math.Pow(2, rndm.Next(2, 11)).ToString();
            int pressed = rndm.Next(0, 2);
            ext2fsForm.KBPressed = Convert.ToBoolean(pressed);
            ext2fsForm.MBPressed = Convert.ToBoolean((pressed + 1) % 2);
            ext2fsForm.numBlocIndexText = rndm.Next(13, 15).ToString();
            ext2fsForm.indirirNum = rndm.Next(0, 4);

        }

    }
}
