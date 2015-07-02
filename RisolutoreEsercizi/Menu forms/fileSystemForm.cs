/// <summary>
/// Questo è il form che contiene il menu riguardante le varie tipologie di esercizi sui File System (ext2fs, FAT e NTFS). 
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

    public partial class fileSystemForm : Form{

        public fileSystemForm(){
            InitializeComponent();
        }

        //Visualizza il form Ext2fs
        private void ext2fsToolStripMenuItem_Click(object sender, EventArgs e) {

            //Disabilita pulsante Ext2fs e abiltia gli altri
            ext2fsToolStripMenuItem.Enabled = false;
            fATToolStripMenuItem.Enabled = true;
            nTFSToolStripMenuItem.Enabled = true;

            //Crea il form Ext2fs e associalo al pannello appropriato
            ext2fsForm extForm = new ext2fsForm();
            extForm.TopLevel = false;
            extForm.AutoScroll = true;
            ext2fsPanel.Controls.Add(extForm);
            extForm.Show();

            //Mostra solo il pannello Ext2fs
            ext2fsPanel.Visible = true;
            fatPanel.Visible = false;
            ntfsPanel.Visible = false;
        }

        //Visualizza il form FAT
        private void fATToolStripMenuItem_Click(object sender, EventArgs e) {

            //Disabilita pulsante FAT e abiltia gli altri
            ext2fsToolStripMenuItem.Enabled = true;
            fATToolStripMenuItem.Enabled = false;
            nTFSToolStripMenuItem.Enabled = true;

            //Crea il form FAT e associalo al pannello appropriato
            fatForm fatForm = new fatForm();
            fatForm.TopLevel = false;
            fatForm.AutoScroll = true;
            fatPanel.Controls.Add(fatForm);
            fatForm.Show();

            //Mostra solo il pannello FAT
            ext2fsPanel.Visible = true;
            fatPanel.Visible = true;
            ntfsPanel.Visible = false;
        }

        //Visualizza il form NTFS
        private void nTFSToolStripMenuItem_Click(object sender, EventArgs e) {

            //Disabilita pulsante NTFS e abiltia gli altri
            ext2fsToolStripMenuItem.Enabled = true;
            fATToolStripMenuItem.Enabled = true;
            nTFSToolStripMenuItem.Enabled = false;

            //Crea il form NTFS e associalo al pannello appropriato
            ntfsForm ntfsForm = new ntfsForm();
            ntfsForm.TopLevel = false;
            ntfsForm.AutoScroll = true;
            ntfsPanel.Controls.Add(ntfsForm);
            ntfsForm.Show();

            //Mostra solo il pannello NTFS
            ext2fsPanel.Visible = true;
            fatPanel.Visible = true ;
            ntfsPanel.Visible = true;
        }

    }
}
