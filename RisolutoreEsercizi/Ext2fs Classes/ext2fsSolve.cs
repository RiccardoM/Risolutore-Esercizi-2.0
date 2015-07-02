/// <summary>
/// Questa classe serve  per risolvere gli esercizi riguardanti il File System Et2fs.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RisolutoreEsercizi {

    class ext2fsSolve {

        public void solve(long dimPar, long dimBloc, long dimInode, bool KBRadioButton, bool MBradioButton, long numIndexPrin, long numIndir) {

            // ###############################
            // #### Preparazione dei dati ####
            // ###############################
            //Calcolo vera dimensione della partizione in B
            dimPar = dimPar * Convert.ToInt32(Math.Pow(2, 30));

            //Calcolo dimensione di un blocco dati in B
            dimBloc = dimBloc * Convert.ToInt32(Math.Pow(2, 10));

            //Calcolo dimensione i-node in B
            if (KBRadioButton) {
                dimInode = dimInode * Convert.ToInt32(Math.Pow(2, 10));
            }

            else {
                dimInode = dimInode * Convert.ToInt32(Math.Pow(2, 20));
            }


            // #####################
            // #### Risoluzione ####
            // #####################
            //Calcolo numero di blocchi nella partizione
            long numBloc = dimPar / dimBloc;

            //Calcolo numero di bit necessari per indirizzare tutti i blocchi
            int numBit = 0;
            long log = Convert.ToInt64(Math.Log(numBloc, 2));

            if (log % 8 != 0) {
                numBit = Convert.ToInt32(((log / 8) + 1) * 8);
            }

            else {
                numBit = Convert.ToInt32(log);
            }

            //Calcolo quanti blocchi indirizza un i-node
            long numBlocInd = dimInode / (numBit / 8);

            //Dimensione massima del file
            double maxFileDim = 0;

            //Dimensione della struttura
            double strutDim = 0;

            //Prova a risolvere
            try {
                switch (numIndir) {
                case 0:
                    maxFileDim = numIndexPrin;
                    strutDim = dimInode;
                    break;

                case 1:
                    maxFileDim = (numIndexPrin + numBlocInd);
                    strutDim = 2 * dimInode;
                    break;

                case 2:
                    maxFileDim = (numIndexPrin + numBlocInd + Convert.ToInt64(Math.Pow(numBlocInd, 2)));
                    strutDim = (3 + numBlocInd) * dimInode;
                    break;

                case 3:
                    maxFileDim = (numIndexPrin + numBlocInd + Convert.ToInt64(Math.Pow(numBlocInd, 2)) + Convert.ToInt64(Math.Pow(numBlocInd, 3)));
                    strutDim = (4 + numBlocInd + Convert.ToInt64(Math.Pow(numBlocInd, 2))) * dimInode;
                    break;
                }
            }

            //Gestisci l'eccesione da overflow
            catch (System.OverflowException) {
                errorMessage eMessage = new errorMessage();
                eMessage.overflowError();
                return;
            }

            maxFileDim = maxFileDim * dimBloc;

            //Calcolo il rapporto inflattivo
            double rapp = Math.Round((strutDim / maxFileDim), 5) * 100;


            // ######################################
            // #### Visualizzazione dei risulati ####
            // ######################################           
            //Creo una nuova istanza del form per la visione dei risultati e lo compilo con i dati
            ext2fsResultForm extRes = new ext2fsResultForm( (Math.Log(dimPar, 2)).ToString(), (Math.Log(dimBloc, 2)).ToString(), (Math.Log(dimInode, 2)).ToString(),
                                                            (Math.Log(numBloc, 2)).ToString(), numBit.ToString(), numBlocInd.ToString(), maxFileDim.ToString(),
                                                            strutDim.ToString(), rapp.ToString() );
            //Visualizzo il form
            extRes.Show();
        }

    }

}
