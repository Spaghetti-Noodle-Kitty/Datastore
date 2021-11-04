using System;
using System.Windows.Forms;

namespace Datastore
{
    public partial class frmDatastore : Form
    {
        public static bool isLightTheme = true;

        public frmDatastore()
        {
            #region Define darkmode colors
            System.Drawing.Color DMTextFG = System.Drawing.Color.FromArgb(221, 221, 221);
            System.Drawing.Color DMButton = System.Drawing.Color.FromArgb(44, 44, 44);
            System.Drawing.Color DMForm = System.Drawing.Color.FromArgb(60, 60, 60);
            System.Drawing.Color DMTextBG = System.Drawing.Color.FromArgb(90, 90, 90);
            #endregion
            InitializeComponent();
            FileHandling.SetupWorkingFolder();
            #region Setup darktheme for startup
            this.ForeColor = DMTextFG;
            this.btnChoose.ForeColor = DMTextFG;
            this.btnDecrypt.ForeColor = DMTextFG;
            this.btnEncrypt.ForeColor = DMTextFG;
            this.btnThemeChange.ForeColor = DMTextFG;
            this.btnChoose.BackColor = DMButton;
            this.btnDecrypt.BackColor = DMButton;
            this.btnEncrypt.BackColor = DMButton;
            this.btnThemeChange.BackColor = DMButton;

            this.BackColor = DMForm;
            this.ForeColor = DMTextFG;

            this.txbContents.ForeColor = DMTextFG;
            this.txbPass.ForeColor = DMTextFG;
            this.txbContents.BackColor = DMTextBG;
            this.txbPass.BackColor = DMTextBG;

            this.btnThemeChange.Text = "Switch to lightmode";
            isLightTheme = false;
            #endregion

        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (txbPass.Text == "" || txbPass.Text.Length != 16)
                MessageBox.Show("You need to set a password of 16 chars");
            else
            {
                string TMPEncTXT = txbContents.Text;
                AES.SetKey(txbPass.Text);
                txbContents.Text = AES.AesDecrypt(TMPEncTXT);
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string TMPEnc = "";

            if (txbPass.Text == "" || txbPass.Text.Length != 16)
                MessageBox.Show("You need to set a password of 16 chars");
            else
            {
                AES.SetKey(txbPass.Text);
                TMPEnc = AES.AesEncrypt(txbContents.Text);

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.InitialDirectory = FileHandling.WorkingFolder;
                sfd.DefaultExt = ".dst";
                sfd.Filter = "Encrypted Datastore Files | *.dst";
                if (sfd.ShowDialog() == DialogResult.OK)
                    FileHandling.WriteFileContents(sfd.FileName, TMPEnc);
                txbContents.Text = TMPEnc;
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = FileHandling.WorkingFolder;
            ofd.DefaultExt = ".dst";
            ofd.Filter = "Encrypted Datastore Files | *.dst";
            if (ofd.ShowDialog() == DialogResult.OK)
                txbContents.Text = FileHandling.ReadFileContents(ofd.FileName);
        }

        private void btnThemeChange_Click(object sender, EventArgs e)
        {
            System.Drawing.Color DMTextFG = System.Drawing.Color.FromArgb(221, 221, 221);
            System.Drawing.Color DMButton = System.Drawing.Color.FromArgb(44, 44, 44);
            System.Drawing.Color DMForm = System.Drawing.Color.FromArgb(60, 60, 60);
            System.Drawing.Color DMTextBG = System.Drawing.Color.FromArgb(90, 90, 90);

            System.Drawing.Color LMTextFG = System.Drawing.Color.FromArgb(44, 44, 44);
            System.Drawing.Color LMButton = System.Drawing.Color.FromArgb(243, 243, 243);
            System.Drawing.Color LMForm = System.Drawing.Color.FromArgb(220, 220, 220);
            System.Drawing.Color LMTextBG = System.Drawing.Color.FromArgb(238, 238, 238);

            if (isLightTheme)
            {
                this.ForeColor = DMTextFG;
                this.btnChoose.ForeColor = DMTextFG;
                this.btnDecrypt.ForeColor = DMTextFG;
                this.btnEncrypt.ForeColor = DMTextFG;
                this.btnThemeChange.ForeColor = DMTextFG;
                this.btnChoose.BackColor = DMButton;
                this.btnDecrypt.BackColor = DMButton;
                this.btnEncrypt.BackColor = DMButton;
                this.btnThemeChange.BackColor = DMButton;

                this.BackColor = DMForm;
                this.ForeColor = DMTextFG;

                this.txbContents.ForeColor = DMTextFG;
                this.txbPass.ForeColor = DMTextFG;
                this.txbContents.BackColor = DMTextBG;
                this.txbPass.BackColor = DMTextBG;

                this.btnThemeChange.Text = "Switch to lightmode";
                isLightTheme = false;
            }
            else
            {
                this.btnChoose.ForeColor = LMTextFG;
                this.btnDecrypt.ForeColor = LMTextFG;
                this.btnEncrypt.ForeColor = LMTextFG;
                this.btnThemeChange.ForeColor = LMTextFG;
                this.btnChoose.BackColor = LMButton;
                this.btnDecrypt.BackColor = LMButton;
                this.btnEncrypt.BackColor = LMButton;
                this.btnThemeChange.BackColor = LMButton;

                this.BackColor = LMForm;
                this.ForeColor = LMTextFG;

                this.txbContents.ForeColor = LMTextFG;
                this.txbPass.ForeColor = LMTextFG;
                this.txbContents.BackColor = LMTextBG;
                this.txbPass.BackColor = LMTextBG;

                this.btnThemeChange.Text = "Switch to darkmode";
                isLightTheme = true;
            }
        }
    }
}
