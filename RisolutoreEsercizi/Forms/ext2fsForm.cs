/// <summary>
/// Questo è il form base riguardante gli esercizi Ext2fs.
/// </summary>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RisolutoreEsercizi{

    public partial class ext2fsForm : Form{

        //Inizializzo componenti
        public ext2fsForm(){
            InitializeComponent();
        }


        //Controllo che gli input nei Textbox siano solo numeri
        private void dimParTextbox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void dimBloccoTextbox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void dimInodeTextbox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void numIndexPrinInodeTextbox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }


        //Crea nuova istanza della classe per gli avvisi di errore
        errorMessage eMessage = new errorMessage();


        // ###################################
        // ####### Genero dati casuali #######
        // ###################################

        //Variabili pubbliche
        public static string dimParText = "";
        public static string dimBloccoText = "";
        public static string dimInodeText = "";
        public static bool KBPressed = false;
        public static bool MBPressed = false;
        public static string numBlocIndexText = "";
        public static int indrirNum = 0;

        private void generateButton_Click(object sender, EventArgs e) {

            //Crea nuova istanza della classe per generare dati random
            ext2fsGenerate genExt2fs = new ext2fsGenerate();

            //Genera dati
            genExt2fs.generate();

            //Compila i campi
            dimParTextbox.Text = dimParText;
            dimBloccoTextbox.Text = dimBloccoText;
            dimInodeTextbox.Text = dimInodeText;
            inodeKBRadioButton.Checked = KBPressed;
            inodeMBradioButton.Checked = MBPressed;
            numIndexPrinInodeTextbox.Text = numBlocIndexText;
            numIndirCombobox.SelectedIndex = indrirNum;

        }

        // ###################################
        // ############# Risolvo #############
        // ###################################
        private void solveButton_Click(object sender, EventArgs e) {

            //Crea nuova istanza della classe per risolvere
            ext2fsSolve solveExt2fs = new ext2fsSolve();

            //Prova a risolvere
            try {
                solveExt2fs.solve( Convert.ToInt64(dimParTextbox.Text), Convert.ToInt64(dimBloccoTextbox.Text), Convert.ToInt64(dimInodeTextbox.Text),
                                   inodeKBRadioButton.Checked, inodeMBradioButton.Checked, Convert.ToInt64(numIndexPrinInodeTextbox.Text),
                                   Convert.ToInt64(numIndirCombobox.Text) );
            }

            //Gestisci l'eccezione da formato
            catch (System.FormatException) {
                eMessage.formatError();
            }

        }

    }
}
