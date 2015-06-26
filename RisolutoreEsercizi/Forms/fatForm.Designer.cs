namespace RisolutoreEsercizi.Forms {
    partial class fatForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.generateButton = new System.Windows.Forms.Button();
            this.takeButton = new System.Windows.Forms.Button();
            this.numIndexPrinInodeTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.KBBloccoLabel = new System.Windows.Forms.Label();
            this.GBParLabel = new System.Windows.Forms.Label();
            this.dimBloccoTextbox = new System.Windows.Forms.TextBox();
            this.dimBloccoLabel = new System.Windows.Forms.Label();
            this.dimParTextbox = new System.Windows.Forms.TextBox();
            this.dimParLabel = new System.Windows.Forms.Label();
            this.solveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(12, 235);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(467, 39);
            this.generateButton.TabIndex = 31;
            this.generateButton.Text = "Genera dati casuali";
            this.generateButton.UseVisualStyleBackColor = true;
            // 
            // takeButton
            // 
            this.takeButton.Location = new System.Drawing.Point(12, 146);
            this.takeButton.Name = "takeButton";
            this.takeButton.Size = new System.Drawing.Size(467, 39);
            this.takeButton.TabIndex = 30;
            this.takeButton.Text = "Preleva dati dal pannello Ext2fs";
            this.takeButton.UseVisualStyleBackColor = true;
            // 
            // numIndexPrinInodeTextbox
            // 
            this.numIndexPrinInodeTextbox.Location = new System.Drawing.Point(130, 70);
            this.numIndexPrinInodeTextbox.MaxLength = 32;
            this.numIndexPrinInodeTextbox.Name = "numIndexPrinInodeTextbox";
            this.numIndexPrinInodeTextbox.Size = new System.Drawing.Size(143, 20);
            this.numIndexPrinInodeTextbox.TabIndex = 27;
            this.numIndexPrinInodeTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Dimensione file:";
            // 
            // KBBloccoLabel
            // 
            this.KBBloccoLabel.AutoSize = true;
            this.KBBloccoLabel.Location = new System.Drawing.Point(279, 41);
            this.KBBloccoLabel.Name = "KBBloccoLabel";
            this.KBBloccoLabel.Size = new System.Drawing.Size(21, 13);
            this.KBBloccoLabel.TabIndex = 21;
            this.KBBloccoLabel.Text = "KB";
            // 
            // GBParLabel
            // 
            this.GBParLabel.AutoSize = true;
            this.GBParLabel.Location = new System.Drawing.Point(279, 9);
            this.GBParLabel.Name = "GBParLabel";
            this.GBParLabel.Size = new System.Drawing.Size(22, 13);
            this.GBParLabel.TabIndex = 20;
            this.GBParLabel.Text = "GB";
            // 
            // dimBloccoTextbox
            // 
            this.dimBloccoTextbox.Location = new System.Drawing.Point(224, 38);
            this.dimBloccoTextbox.MaxLength = 4;
            this.dimBloccoTextbox.Name = "dimBloccoTextbox";
            this.dimBloccoTextbox.Size = new System.Drawing.Size(49, 20);
            this.dimBloccoTextbox.TabIndex = 19;
            this.dimBloccoTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dimBloccoLabel
            // 
            this.dimBloccoLabel.AutoSize = true;
            this.dimBloccoLabel.Location = new System.Drawing.Point(9, 41);
            this.dimBloccoLabel.Name = "dimBloccoLabel";
            this.dimBloccoLabel.Size = new System.Drawing.Size(120, 13);
            this.dimBloccoLabel.TabIndex = 18;
            this.dimBloccoLabel.Text = "Dimensione blocco dati:";
            // 
            // dimParTextbox
            // 
            this.dimParTextbox.Location = new System.Drawing.Point(224, 6);
            this.dimParTextbox.MaxLength = 4;
            this.dimParTextbox.Name = "dimParTextbox";
            this.dimParTextbox.Size = new System.Drawing.Size(49, 20);
            this.dimParTextbox.TabIndex = 17;
            this.dimParTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dimParLabel
            // 
            this.dimParLabel.AutoSize = true;
            this.dimParLabel.Location = new System.Drawing.Point(9, 9);
            this.dimParLabel.Name = "dimParLabel";
            this.dimParLabel.Size = new System.Drawing.Size(113, 13);
            this.dimParLabel.TabIndex = 16;
            this.dimParLabel.Text = "Dimensione partizione:";
            // 
            // solveButton
            // 
            this.solveButton.Location = new System.Drawing.Point(12, 280);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(467, 39);
            this.solveButton.TabIndex = 33;
            this.solveButton.Text = "Risolvi";
            this.solveButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "B";
            // 
            // fatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 573);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.takeButton);
            this.Controls.Add(this.numIndexPrinInodeTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KBBloccoLabel);
            this.Controls.Add(this.GBParLabel);
            this.Controls.Add(this.dimBloccoTextbox);
            this.Controls.Add(this.dimBloccoLabel);
            this.Controls.Add(this.dimParTextbox);
            this.Controls.Add(this.dimParLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fatForm";
            this.Text = "fatForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button takeButton;
        private System.Windows.Forms.TextBox numIndexPrinInodeTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label KBBloccoLabel;
        private System.Windows.Forms.Label GBParLabel;
        private System.Windows.Forms.TextBox dimBloccoTextbox;
        private System.Windows.Forms.Label dimBloccoLabel;
        private System.Windows.Forms.TextBox dimParTextbox;
        private System.Windows.Forms.Label dimParLabel;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.Label label2;
    }
}