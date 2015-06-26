using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RisolutoreEsercizi {

    class errorMessage {

        public void formatError() {
            MessageBox.Show("Controlla di aver inserito correttamente tutti i dati", "Errore");
        }

        public void overflowError() {
            MessageBox.Show("Errore di overflow durante l'esecuzione dei calcoli", "Errore");
        }

    }
}
