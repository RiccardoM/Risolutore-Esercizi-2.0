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

        /*
        //Variabili pubbliche
        public static string dimParText;
        public static string dimBloccoText;
        public static string dimInodeText;
        public static bool KBPressed;
        public static bool MBPressed;
        public static string numBlocIndexText;
        public static int indrirNum;
        */

        //Inizializzo componenti
        public ext2fsForm(){
            InitializeComponent();
        }

        //Crea nuova istanza della classe per gli avvisi di errore
        errorMessage eMessage = new errorMessage();


        // ###################################
        // ####### Genero dati casuali #######
        // ###################################
        private void generateButton_Click(object sender, EventArgs e) {

            //Crea nuova istanza della classe per generare dati random
            ext2fsGenerate genExt2fs = new ext2fsGenerate();

            //Genera dati
            genExt2fs.generate();

            /*
            //Compila i campi
            dimParTextbox.Text = dimParText;
            dimBloccoTextbox.Text = dimBloccoText;
            dimInodeTextbox.Text = dimInodeText;
            inodeKBRadioButton.Checked = KBPressed;
            inodeMBradioButton.Checked = MBPressed;
            numIndexPrinInodeTextbox.Text = numBlocIndexText;
            indirNumCombobox.SelectedIndex = indrirNum;
            */

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

            //Se qualcosa non va
            catch (System.FormatException) {

                //Mostra l'avviso
                eMessage.formatError();

            }

        }

        
    }
}
