/// <summary>
/// Questa classe serve per risolvere gli esercizi nel pannello NTFS.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisolutoreEsercizi {

    class ntfsSolve {

        public void solve(long dimPar, long dimBloc, long dimFile, bool BRadioButton, bool KBRadioButton, bool MBRadioButton, bool GBRadioButton, long dimRecord,
                          long resBytePrin, long resByteSec) {

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

            //Calcolo la dimensione di una coppia {inizio, fine}
            int dimCop = (numBit / 8)*2;

            //Sottraggo la coppia {base, indice} al record principale
            resBytePrin = resBytePrin - 8;

            //Calcolo quante coppie ci stanno nel record principale
            long numCopPrin = resBytePrin / dimCop;

            //Calcolo quante coppie ci stanno nel record di estensione
            long numCopSec = resByteSec / dimCop;

            //Calcolo di quanti blocchi è composto il file
            double numBlocFile = dimFile / dimBloc;

            //Calcolo quanti record servono per rappresentare il file
            double numRec = 1 + Math.Ceiling(((numBlocFile - numCopPrin) / numCopSec));

            //Calcolo la dimensione dell'intera struttura NTFS
            long dimNtfs = Convert.ToInt64(numRec * dimRecord);

            //Calcolo rapporto inflattivo
            double rapp = Math.Round((Convert.ToDouble(dimNtfs / dimFile)), 5) * 100;


            // ######################################
            // #### Visualizzazione dei risulati ####
            // ######################################
            //Creo una nuova istanza del form per la visione dei risultati e lo compilo con i dati
            ntfsResultsForm ntfsRes = new ntfsResultsForm((Math.Log(dimPar, 2)).ToString(), (Math.Log(dimBloc, 2)).ToString(), (Math.Log(numBloc, 2)).ToString(),
                                                        numBit.ToString(), dimFile.ToString(), dimNtfs.ToString(), dimRecord.ToString(), resBytePrin.ToString(),
                                                        resByteSec.ToString(), numCopPrin.ToString(), numCopSec.ToString(), numRec.ToString(), rapp.ToString());

            //Visualizzo il form
            ntfsRes.Show();





        }

    }
}
