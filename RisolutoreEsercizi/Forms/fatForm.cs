/// <summary>
/// Questo è il form base riguardante gli esercizi FAT.
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

namespace RisolutoreEsercizi {

    public partial class fatForm : Form {

        // #####################################
        // #### Inizializzazione componenti ####
        // #####################################
        public fatForm() {
            InitializeComponent();
        }


        // #############################
        // #### Variabili pubbliche ####
        // #############################
        public static string dimParText;
        public static string dimBlocText;
        public static string dimFileText;
        public static bool BButton;
        public static bool KBButton;
        public static bool MBButton;
        public static bool GBButton;


        // ###############################
        // #### Controllo degli input ####
        // ###############################
        private void dimInodeTextbox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void dimBloccoTextbox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void dimParTextbox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }


        // ###############################
        // #### Gestione degli errori ####
        // ###############################
        errorMessage eMessage = new errorMessage();
        

        // ###########################
        // ##### Prelevo dei dati ####
        // ###########################
        private void takeButton_Click(object sender, EventArgs e) {

            try {
                fatTakeData fatTake = new fatTakeData();
                fatTake.takeData();

                //Compila i campi
                dimParTextbox.Text = dimParText;
                dimBloccoTextbox.Text = dimBlocText;
                dimFileTextbox.Text = dimFileText;
                BRadioButton.Checked = true;
            }

            //Gestione dell'eccezione se la sezione Etx2fs non è completa di tutti i dati
            catch (System.FormatException) {
                eMessage.formatErrorExt2fs();
            }

        }


        // ######################################
        // #### Generazione casuale dei dati ####
        // ######################################
        private void generateButton_Click(object sender, EventArgs e) {

            //Crea nuova istanza della classe per generare i dati
            fatGenerate fatGen = new fatGenerate();

            //Genera dati
            fatGen.generate();

            //Compila i campi
            dimParTextbox.Text = dimParText;
            dimBloccoTextbox.Text = dimBlocText;
            dimFileTextbox.Text = dimFileText;
            BRadioButton.Checked = BButton;
            KBRadioButton.Checked = KBButton;
            MBRadioButton.Checked = MBButton;
            GBRadioButton.Checked = GBButton;
        }


        // #####################
        // #### Risoluzione ####
        // #####################
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
