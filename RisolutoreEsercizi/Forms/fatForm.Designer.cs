namespace RisolutoreEsercizi {
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
            this.takeButton = new System.Windows.Forms.Button();
            this.dimFileTextbox = new System.Windows.Forms.TextBox();
            this.dimFileLabel = new System.Windows.Forms.Label();
            this.KBBloccoLabel = new System.Windows.Forms.Label();
            this.GBParLabel = new System.Windows.Forms.Label();
            this.dimBloccoTextbox = new System.Windows.Forms.TextBox();
            this.dimBloccoLabel = new System.Windows.Forms.Label();
            this.dimParTextbox = new System.Windows.Forms.TextBox();
            this.dimParLabel = new System.Windows.Forms.Label();
            this.BRadioButton = new System.Windows.Forms.RadioButton();
            this.MBRadioButton = new System.Windows.Forms.RadioButton();
            this.GBRadioButton = new System.Windows.Forms.RadioButton();
            this.KBRadioButton = new System.Windows.Forms.RadioButton();
            this.generateButton = new System.Windows.Forms.Button();
            this.solveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // takeButton
            // 
            this.takeButton.Location = new System.Drawing.Point(12, 121);
            this.takeButton.Name = "takeButton";
            this.takeButton.Size = new System.Drawing.Size(467, 39);
            this.takeButton.TabIndex = 31;
            this.takeButton.Text = "Preleva dati dal pannello Ext2fs";
            this.takeButton.UseVisualStyleBackColor = true;
            this.takeButton.Click += new System.EventHandler(this.takeButton_Click);
            // 
            // dimFileTextbox
            // 
            this.dimFileTextbox.Location = new System.Drawing.Point(143, 70);
            this.dimFileTextbox.MaxLength = 32;
            this.dimFileTextbox.Name = "dimFileTextbox";
            this.dimFileTextbox.Size = new System.Drawing.Size(130, 20);
            this.dimFileTextbox.TabIndex = 23;
            this.dimFileTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dimFileTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dimInodeTextbox_KeyPress);
            // 
            // dimFileLabel
            // 
            this.dimFileLabel.AutoSize = true;
            this.dimFileLabel.Location = new System.Drawing.Point(9, 73);
            this.dimFileLabel.Name = "dimFileLabel";
            this.dimFileLabel.Size = new System.Drawing.Size(81, 13);
            this.dimFileLabel.TabIndex = 22;
            this.dimFileLabel.Text = "Dimensione file:";
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
            this.dimBloccoTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dimBloccoTextbox_KeyPress);
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
            this.dimParTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dimParTextbox_KeyPress);
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
            // BRadioButton
            // 
            this.BRadioButton.AutoSize = true;
            this.BRadioButton.Location = new System.Drawing.Point(282, 71);
            this.BRadioButton.Name = "BRadioButton";
            this.BRadioButton.Size = new System.Drawing.Size(32, 17);
            this.BRadioButton.TabIndex = 24;
            this.BRadioButton.TabStop = true;
            this.BRadioButton.Text = "B";
            this.BRadioButton.UseVisualStyleBackColor = true;
            // 
            // MBRadioButton
            // 
            this.MBRadioButton.AutoSize = true;
            this.MBRadioButton.Location = new System.Drawing.Point(365, 70);
            this.MBRadioButton.Name = "MBRadioButton";
            this.MBRadioButton.Size = new System.Drawing.Size(41, 17);
            this.MBRadioButton.TabIndex = 25;
            this.MBRadioButton.TabStop = true;
            this.MBRadioButton.Text = "MB";
            this.MBRadioButton.UseVisualStyleBackColor = true;
            // 
            // GBRadioButton
            // 
            this.GBRadioButton.AutoSize = true;
            this.GBRadioButton.Location = new System.Drawing.Point(412, 70);
            this.GBRadioButton.Name = "GBRadioButton";
            this.GBRadioButton.Size = new System.Drawing.Size(40, 17);
            this.GBRadioButton.TabIndex = 33;
            this.GBRadioButton.TabStop = true;
            this.GBRadioButton.Text = "GB";
            this.GBRadioButton.UseVisualStyleBackColor = true;
            // 
            // KBRadioButton
            // 
            this.KBRadioButton.AutoSize = true;
            this.KBRadioButton.Location = new System.Drawing.Point(320, 71);
            this.KBRadioButton.Name = "KBRadioButton";
            this.KBRadioButton.Size = new System.Drawing.Size(39, 17);
            this.KBRadioButton.TabIndex = 32;
            this.KBRadioButton.TabStop = true;
            this.KBRadioButton.Text = "KB";
            this.KBRadioButton.UseVisualStyleBackColor = true;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(12, 190);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(467, 39);
            this.generateButton.TabIndex = 35;
            this.generateButton.Text = "Genera dati casuali";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // solveButton
            // 
            this.solveButton.Location = new System.Drawing.Point(12, 235);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(467, 39);
            this.solveButton.TabIndex = 34;
            this.solveButton.Text = "Risolvi";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // fatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 573);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.GBRadioButton);
            this.Controls.Add(this.KBRadioButton);
            this.Controls.Add(this.takeButton);
            this.Controls.Add(this.MBRadioButton);
            this.Controls.Add(this.BRadioButton);
            this.Controls.Add(this.dimFileTextbox);
            this.Controls.Add(this.dimFileLabel);
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

        private System.Windows.Forms.Button takeButton;
        private System.Windows.Forms.TextBox dimFileTextbox;
        private System.Windows.Forms.Label dimFileLabel;
        private System.Windows.Forms.Label KBBloccoLabel;
        private System.Windows.Forms.Label GBParLabel;
        private System.Windows.Forms.TextBox dimBloccoTextbox;
        private System.Windows.Forms.Label dimBloccoLabel;
        private System.Windows.Forms.TextBox dimParTextbox;
        private System.Windows.Forms.Label dimParLabel;
        private System.Windows.Forms.RadioButton BRadioButton;
        private System.Windows.Forms.RadioButton MBRadioButton;
        private System.Windows.Forms.RadioButton GBRadioButton;
        private System.Windows.Forms.RadioButton KBRadioButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button solveButton;
    }
}