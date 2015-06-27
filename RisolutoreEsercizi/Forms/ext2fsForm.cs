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

        // #####################################
        // #### Inizializzazione componenti ####
        // #####################################
        public ext2fsForm(){
            InitializeComponent();
        }


        // #############################
        // #### Variabili pubbliche ####
        // #############################
        public static string dimParText = "";
        public static string dimBloccoText = "";
        public static string dimInodeText = "";
        public static bool KBPressed = false;
        public static bool MBPressed = false;
        public static string numBlocIndexText = "";
        public static int indirirNum = 0;


        // ###############################
        // #### Controllo degli input ####
        // ###############################
        private void dimParTextbox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
            dimParText = dimParTextbox.Text;
        }

        private void dimBloccoTextbox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
            dimBloccoText = dimBloccoTextbox.Text;
        }

        private void dimInodeTextbox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
            dimInodeText = dimInodeTextbox.Text;
        }

        private void numIndexPrinInodeTextbox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
            numBlocIndexText = numIndexPrinInodeTextbox.Text;
        }

        private void inodeKBRadioButton_Click(object sender, EventArgs e) {
            KBPressed = true;
            MBPressed = false;
        }

        private void inodeMBradioButton_Click(object sender, EventArgs e) {
            KBPressed = false;
            MBPressed = true;
        }

        private void numIndirCombobox_SelectedIndexChanged(object sender, EventArgs e) {
            indirirNum = numIndirCombobox.SelectedIndex;
        }


        // ###############################
        // #### Gestione degli errori ####
        // ###############################
        errorMessage eMessage = new errorMessage();


        // ######################################
        // #### Generazione casuale dei dati ####
        // ######################################
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
            numIndirCombobox.SelectedIndex = indirirNum;
        }


        // #####################
        // #### Risoluzione ####
        // #####################
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
