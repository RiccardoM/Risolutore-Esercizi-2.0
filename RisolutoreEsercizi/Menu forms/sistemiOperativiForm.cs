/// <summary>
/// Questo è il form che contiene il menu per i vari esercizi del corso di Sistemi Operativi. 
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

    public partial class sistemiOperativiForm : Form{

        public sistemiOperativiForm(){
            InitializeComponent();
        }

        //Richiama il form dei File System
        private void fileSystemToolStripMenuItem_Click(object sender, EventArgs e){
            fileSystemForm FSForm = new fileSystemForm();
            FSForm.TopLevel = false;
            FSForm.AutoScroll = true;
            fileSystemPanel.Controls.Add(FSForm);
            FSForm.Show();
        }

    }
}
