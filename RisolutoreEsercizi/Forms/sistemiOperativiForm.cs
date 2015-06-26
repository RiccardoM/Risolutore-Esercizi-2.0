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

        //Richiamo il form dei File System
        private void fileSystemToolStripMenuItem_Click(object sender, EventArgs e){
            fileSystemForm FSForm = new fileSystemForm();
            FSForm.TopLevel = false;
            FSForm.AutoScroll = true;
            fileSystemPanel.Controls.Add(FSForm);
            FSForm.Show();
        }

    }
}
