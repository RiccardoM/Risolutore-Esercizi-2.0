using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisolutoreEsercizi {

    class fatSolve {

        public void solve(long dimPar, long dimBloc, long dimFile, bool BRadioButton, bool KBRadioButton, bool MBRadioButton, bool GBRadioButton) {
            
            // ###############################
            // #### Preparazione dei dati ####
            // ###############################

            //Calcolo vera dimensione della partizione in B
            dimPar = dimPar * Convert.ToInt32(Math.Pow(2, 30));

            //Calcolo dimensione di un blocco dati in B
            dimBloc = dimBloc * Convert.ToInt32(Math.Pow(2, 10));

            //Calcolo dimensione del file
            if (KBRadioButton) {
                dimFile = dimFile * Convert.ToInt64(Math.Pow(2, 10));
            }

            else if (MBRadioButton) {
                dimFile = dimFile * Convert.ToInt64(Math.Pow(2, 20));
            }

            else if (GBRadioButton) {
                dimFile = dimFile * Convert.ToInt64(Math.Pow(2, 30));
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

            //Calcolo la dimensione di una riga della FAT
            int dimRigFat = numBit / 8;

            //Calcolo la dimensione della FAT
            double dimFat = dimRigFat * numBloc;

            //Calcolo rapporto inflattivo
            double rapp = Math.Round((dimFat / dimFile), 5) * 100;


            // ######################################
            // #### Visualizzazione dei risulati ####
            // ######################################

            //Creo una nuova istanza del form per la visione dei risultati e lo compilo con i dati
            fatResultsForm fatRes = new fatResultsForm( (Math.Log(dimPar, 2)).ToString(), (Math.Log(dimBloc, 2)).ToString(), (Math.Log(numBloc, 2)).ToString(),
                                                        numBit.ToString(), dimFile.ToString(), dimFat.ToString(), rapp.ToString());
            //Visualizzo il form
            fatRes.Show();

        }

    }
}
