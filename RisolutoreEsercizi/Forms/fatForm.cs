using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RisolutoreEsercizi {
    public partial class fatForm : Form {

        //Inizializzo componenti
        public fatForm() {
            InitializeComponent();
        }

        //Controllo che gli input nei Textbox siano solo numeri
        private void dimInodeTextbox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void dimBloccoTextbox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void dimParTextbox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        //Crea nuova istanza della classe per gli avvisi di errore
        errorMessage eMessage = new errorMessage();


        // ###################################
        // ############# Risolvo #############
        // ###################################
        private void solveButton_Click(object sender, EventArgs e) {

            //Crea nuova istanza della classe per risolvere
            fatSolve fatSolve = new fatSolve();

            //Prova a risolvere
            try {
                fatSolve.solve( Convert.ToInt64(dimParTextbox.Text), Convert.ToInt64(dimBloccoTextbox.Text), Convert.ToInt64(dimFileTextbox.Text),
                                BRadioButton.Checked, KBRadioButton.Checked, MBRadioButton.Checked, GBRadioButton.Checked );
            }

            //Gestisci l'eccezione da formato
            catch (System.FormatException) {
                eMessage.formatError();
            }
        }
    }
}
