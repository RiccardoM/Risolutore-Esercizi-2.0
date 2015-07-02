namespace RisolutoreEsercizi
{
    partial class fileSystemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ext2fsPanel = new System.Windows.Forms.Panel();
            this.fatPanel = new System.Windows.Forms.Panel();
            this.ext2fsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nTFSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ntfsPanel = new System.Windows.Forms.Panel();
            this.ext2fsPanel.SuspendLayout();
            this.fatPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ext2fsPanel
            // 
            this.ext2fsPanel.Controls.Add(this.fatPanel);
            this.ext2fsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ext2fsPanel.Location = new System.Drawing.Point(0, 24);
            this.ext2fsPanel.Name = "ext2fsPanel";
            this.ext2fsPanel.Size = new System.Drawing.Size(491, 549);
            this.ext2fsPanel.TabIndex = 1;
            // 
            // fatPanel
            // 
            this.fatPanel.Controls.Add(this.ntfsPanel);
            this.fatPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fatPanel.Location = new System.Drawing.Point(0, 0);
            this.fatPanel.Name = "fatPanel";
            this.fatPanel.Size = new System.Drawing.Size(491, 549);
            this.fatPanel.TabIndex = 0;
            // 
            // ext2fsToolStripMenuItem
            // 
            this.ext2fsToolStripMenuItem.Name = "ext2fsToolStripMenuItem";
            this.ext2fsToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.ext2fsToolStripMenuItem.Text = "Ext2fs";
            this.ext2fsToolStripMenuItem.Click += new System.EventHandler(this.ext2fsToolStripMenuItem_Click);
            // 
            // fATToolStripMenuItem
            // 
            this.fATToolStripMenuItem.Name = "fATToolStripMenuItem";
            this.fATToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fATToolStripMenuItem.Text = "FAT";
            this.fATToolStripMenuItem.Click += new System.EventHandler(this.fATToolStripMenuItem_Click);
            // 
            // nTFSToolStripMenuItem
            // 
            this.nTFSToolStripMenuItem.Name = "nTFSToolStripMenuItem";
            this.nTFSToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.nTFSToolStripMenuItem.Text = "NTFS";
            this.nTFSToolStripMenuItem.Click += new System.EventHandler(this.nTFSToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ext2fsToolStripMenuItem,
            this.fATToolStripMenuItem,
            this.nTFSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(491, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ntfsPanel
            // 
            this.ntfsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ntfsPanel.Location = new System.Drawing.Point(0, 0);
            this.ntfsPanel.Name = "ntfsPanel";
            this.ntfsPanel.Size = new System.Drawing.Size(491, 549);
            this.ntfsPanel.TabIndex = 0;
            // 
            // fileSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 573);
            this.Controls.Add(this.ext2fsPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fileSystemForm";
            this.Text = "mainFileSystemForm";
            this.ext2fsPanel.ResumeLayout(false);
            this.fatPanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel ext2fsPanel;
        private System.Windows.Forms.Panel fatPanel;
        private System.Windows.Forms.Panel ntfsPanel;
        private System.Windows.Forms.ToolStripMenuItem ext2fsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fATToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nTFSToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}