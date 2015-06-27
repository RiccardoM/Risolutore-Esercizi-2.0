using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisolutoreEsercizi {

    class fatTakeData {

        public void takeData() {

            //ext2fsForm.

            //Calcolo la dimensione massima
            ext2fsMaxFileDim extMaxFile = new ext2fsMaxFileDim();
            long maxFile = extMaxFile.maxFileDim( Convert.ToInt64(ext2fsForm.dimParText), Convert.ToInt64(ext2fsForm.dimBloccoText),
                                                  Convert.ToInt64(ext2fsForm.dimInodeText), ext2fsForm.KBPressed, ext2fsForm.MBPressed,
                                                  Convert.ToInt64(ext2fsForm.numBlocIndexText), Convert.ToInt64(ext2fsForm.indirirNum) );


            fatForm.dimParText = ext2fsForm.dimParText;
            fatForm.dimBlocText = ext2fsForm.dimBloccoText;
            fatForm.dimFileText = maxFile.ToString();

            

        }

    }
}
