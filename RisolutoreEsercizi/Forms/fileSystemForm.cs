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

    public partial class fileSystemForm : Form{

        public fileSystemForm(){
            InitializeComponent();
        }

        //Richiamo il form Ext2fs
        private void ext2fsToolStripMenuItem_Click(object sender, EventArgs e) {
            ext2fsForm extForm = new ext2fsForm();
            extForm.TopLevel = false;
            extForm.AutoScroll = true;
            ext2fsPanel.Controls.Add(extForm);
            extForm.Show();
        }
    }
}
