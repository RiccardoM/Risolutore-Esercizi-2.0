/// <summary>
/// Questa classe serve per generare casualmente dei dati per il pannello FAT.
/// Dopo aver generato i dati vengono inoltre compilate le variabili pubbliche del form fatForm che le usa per compilare i vari TextBox.
/// </summary>


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisolutoreEsercizi {

    class fatGenerate {

        public void generate() {

            //Variabile casuale
            Random rndm = new Random();

            //Genera valori delle variabili pubbliche
            fatForm.dimParText = Math.Pow(2, rndm.Next(4, 11)).ToString();
            fatForm.dimBlocText = Math.Pow(2, rndm.Next(0, 7)).ToString();
            fatForm.dimFileText = Math.Pow(2, rndm.Next(0, 4)).ToString();
            fatForm.BButton = false;
            fatForm.KBButton = false;
            fatForm.MBButton = false;
            fatForm.GBButton = false;

            //Variabile casuale per decidere quale dei 4 RadioButton viene selezionato
            int check = rndm.Next(0, 4);

            //Decidi il bottone
            switch (check) {
                case 0:
                    fatForm.BButton = true;
                    break;
                case 1:
                    fatForm.KBButton = true;
                    break;
                case 2:
                    fatForm.MBButton = true;
                    break;
                case 3:
                    fatForm.GBButton = true;
                    break;
            }

        }

    }
}
