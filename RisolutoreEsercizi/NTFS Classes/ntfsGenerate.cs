using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisolutoreEsercizi {

    class ntfsGenerate {

        public void generate() {

            //Variabile casuale
            Random rndm = new Random();

            //Genera valori delle variabili pubbliche
            ntfsForm.dimParText = Math.Pow(2, rndm.Next(4, 11)).ToString();
            ntfsForm.dimBlocText = Math.Pow(2, rndm.Next(0, 7)).ToString();
            ntfsForm.dimFileText = Math.Pow(2, rndm.Next(0, 4)).ToString();
            ntfsForm.BButton = false;
            ntfsForm.KBButton = false;
            ntfsForm.MBButton = false;
            ntfsForm.GBButton = false;

            //Variabile casuale per decidere quale dei 4 RadioButton viene selezionato
            int check = rndm.Next(0, 4);

            //Decidi il bottone
            switch (check) {
                case 0:
                    ntfsForm.BButton = true;
                    break;
                case 1:
                    ntfsForm.KBButton = true;
                    break;
                case 2:
                    ntfsForm.MBButton = true;
                    break;
                case 3:
                    ntfsForm.GBButton = true;
                    break;
            }

            //Calcola dimensione del record
            int dimRecord = Convert.ToInt32(Math.Pow(2, rndm.Next(8, 11)));

            //Calcola quanti byte sono riservati nel record principale
            int dimRecPrin = ((dimRecord / 200) * 100) + 8;

            //Calcola quanti byte sono riservati nel record di estensione
            int dimRecSec = (dimRecPrin - 8) * 2;

            //Assegna valori delle variabili pubbliche
            ntfsForm.dimRecord = dimRecord.ToString();
            ntfsForm.resBytePrin = dimRecPrin.ToString();
            ntfsForm.resByteSec = dimRecSec.ToString();

        }

    }
}
