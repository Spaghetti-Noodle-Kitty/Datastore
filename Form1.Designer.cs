
namespace Datastore
{
    partial class frmDatastore
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
            this.components = new System.ComponentModel.Container();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.txbContents = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnThemeChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbPass
            // 
            this.txbPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPass.Location = new System.Drawing.Point(14, 17);
            this.txbPass.Name = "txbPass";
            this.txbPass.PasswordChar = '*';
            this.txbPass.Size = new System.Drawing.Size(147, 13);
            this.txbPass.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txbPass, "Specify your password for the file here.\r\nIf you want to decrypt, enter password " +
        "and press decrypt.\r\nIf you want to encrypt, enter password and press save.");
            // 
            // txbContents
            // 
            this.txbContents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbContents.Location = new System.Drawing.Point(13, 40);
            this.txbContents.Multiline = true;
            this.txbContents.Name = "txbContents";
            this.txbContents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbContents.Size = new System.Drawing.Size(775, 398);
            this.txbContents.TabIndex = 1;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.FlatAppearance.BorderSize = 0;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.Location = new System.Drawing.Point(167, 13);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(102, 21);
            this.btnDecrypt.TabIndex = 2;
            this.btnDecrypt.Text = "Decrypt";
            this.toolTip1.SetToolTip(this.btnDecrypt, "Decrypts the File contents of the open file\r\nwith the password given.\r\nTo open a " +
        "File use the \"Choose File\" button.");
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.FlatAppearance.BorderSize = 0;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Location = new System.Drawing.Point(276, 13);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(92, 21);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "Save";
            this.toolTip1.SetToolTip(this.btnEncrypt, "Saves whatever you wrote into the Textfield below.\r\nWill encrypt your text with t" +
        "he specified password.");
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.FlatAppearance.BorderSize = 0;
            this.btnChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoose.Location = new System.Drawing.Point(375, 13);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(91, 21);
            this.btnChoose.TabIndex = 4;
            this.btnChoose.Text = "Choose File";
            this.toolTip1.SetToolTip(this.btnChoose, "Reads in the contents of the chosen File.\r\nNeeded for Decryption to work.");
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Help";
            // 
            // btnThemeChange
            // 
            this.btnThemeChange.FlatAppearance.BorderSize = 0;
            this.btnThemeChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemeChange.Location = new System.Drawing.Point(508, 13);
            this.btnThemeChange.Name = "btnThemeChange";
            this.btnThemeChange.Size = new System.Drawing.Size(280, 20);
            this.btnThemeChange.TabIndex = 5;
            this.btnThemeChange.Text = "Switch to darkmode";
            this.btnThemeChange.UseVisualStyleBackColor = true;
            this.btnThemeChange.Click += new System.EventHandler(this.btnThemeChange_Click);
            // 
            // frmDatastore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThemeChange);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.txbContents);
            this.Controls.Add(this.txbPass);
            this.Name = "frmDatastore";
            this.ShowIcon = false;
            this.Text = "Datastore v.1.2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txbPass;
        public System.Windows.Forms.TextBox txbContents;
        public System.Windows.Forms.Button btnDecrypt;
        public System.Windows.Forms.Button btnEncrypt;
        public System.Windows.Forms.Button btnChoose;
        public System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Button btnThemeChange;
    }
}

