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

    public partial class mainForm : Form{

        public mainForm(){
            InitializeComponent();
        }

        //Richiamo il form di Sistemi Operativi
        private void sistemiOperativiToolStripMenuItem_Click(object sender, EventArgs e) {
            sistemiOperativiForm SOForm = new sistemiOperativiForm();
            SOForm.TopLevel = false;
            SOForm.AutoScroll = true;
            sistemiOperativiPanel.Controls.Add(SOForm);
            SOForm.Show();
        }

    }
}
