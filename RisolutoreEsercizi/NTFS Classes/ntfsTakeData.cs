/// <summary>
/// Questa è la classe per prelevare i dati dal pannello Ext2fs e inserirli nei campi appropriati del pannello NTFS.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisolutoreEsercizi {

    class ntfsTakeData {

        public void takeData() {

            //Calcolo la dimensione massima di un file nel pannello Et2fs
            ext2fsMaxFileDim extMaxFile = new ext2fsMaxFileDim();
            long maxFile = extMaxFile.maxFileDim(Convert.ToInt64(ext2fsForm.dimParText), Convert.ToInt64(ext2fsForm.dimBloccoText),
                                                  Convert.ToInt64(ext2fsForm.dimInodeText), ext2fsForm.KBPressed, ext2fsForm.MBPressed,
                                                  Convert.ToInt64(ext2fsForm.numBlocIndexText), Convert.ToInt64(ext2fsForm.indirirNum));

            //Se c'è stato un errore durante il calcolo del file ritorna senza scrivere nulla
            if (maxFile == 0) {
                return;
            }

            //Scrivo nel pannello NTFS i datiprelevati
            ntfsForm.dimParText = ext2fsForm.dimParText;
            ntfsForm.dimBlocText = ext2fsForm.dimBloccoText;
            ntfsForm.dimFileText = maxFile.ToString();

        }

    }
}
