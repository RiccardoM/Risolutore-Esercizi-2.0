/// <summary>
/// Questa è la classe che contiene i vari messaggi di errore. 
/// </summary>


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RisolutoreEsercizi {

    class errorMessage {

        //Messaggio di errore nel caso di formatException
        public void formatError() {
            MessageBox.Show("Controlla di aver inserito correttamente tutti i dati", "Errore");
        }

        //Messaggio di errore nel caso di overflowException
        public void overflowError() {
            MessageBox.Show("Errore di overflow durante l'esecuzione dei calcoli", "Errore");
        }

        public void formatErrorExt2fs() {
            MessageBox.Show("Controlla di aver inserito correttamente tutti i dati nella pannello Ext2fs", "Errore");
        }

    }
}
