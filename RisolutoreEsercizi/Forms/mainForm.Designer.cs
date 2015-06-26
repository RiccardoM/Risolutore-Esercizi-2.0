namespace RisolutoreEsercizi
{
    partial class mainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemiOperativiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemiOperativiPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemiOperativiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(475, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemiOperativiToolStripMenuItem
            // 
            this.sistemiOperativiToolStripMenuItem.Name = "sistemiOperativiToolStripMenuItem";
            this.sistemiOperativiToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.sistemiOperativiToolStripMenuItem.Text = "Sistemi Operativi";
            this.sistemiOperativiToolStripMenuItem.Click += new System.EventHandler(this.sistemiOperativiToolStripMenuItem_Click);
            // 
            // sistemiOperativiPanel
            // 
            this.sistemiOperativiPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sistemiOperativiPanel.Location = new System.Drawing.Point(0, 24);
            this.sistemiOperativiPanel.Name = "sistemiOperativiPanel";
            this.sistemiOperativiPanel.Size = new System.Drawing.Size(475, 511);
            this.sistemiOperativiPanel.TabIndex = 1;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 535);
            this.Controls.Add(this.sistemiOperativiPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Risolutore";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemiOperativiToolStripMenuItem;
        private System.Windows.Forms.Panel sistemiOperativiPanel;
    }
}

