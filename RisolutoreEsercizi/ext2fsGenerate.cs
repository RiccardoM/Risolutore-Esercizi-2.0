using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisolutoreEsercizi {

    class ext2fsGenerate {

        //Genera dati casuali
        public void generate() {
            Random rndm = new Random();

            ext2fsForm.dimParText = Math.Pow(2, rndm.Next(4, 11)).ToString();
            ext2fsForm.dimBloccoText = Math.Pow(2, rndm.Next(0, 7)).ToString();
            ext2fsForm.dimInodeText = Math.Pow(2, rndm.Next(2, 11)).ToString();
            int pressed = rndm.Next(0, 2);
            ext2fsForm.KBPressed = Convert.ToBoolean(pressed);
            ext2fsForm.MBPressed = Convert.ToBoolean((pressed + 1) % 2);
            ext2fsForm.numBlocIndexText = rndm.Next(0, 15).ToString();
            ext2fsForm.indrirNum = rndm.Next(0, 4);

        }

    }
}
