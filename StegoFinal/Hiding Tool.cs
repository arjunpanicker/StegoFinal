using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace StegoFinal
{
    public partial class Hiding_Tool : Form
    {
        private Bitmap bmp = null;
        //private string extractedText = string.Empty;
        public Hiding_Tool()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Cursor = Cursors.Arrow;
            MaximizeBox = false;
        }

        private void selectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "JPEG File(*.jpg)|*.jpg";
                //dlg.Filter = "PNG File(*.png)|*.png";

                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    pathImageHide.Text = dlg.FileName;
                    hidePicBox.Image = new Bitmap(dlg.FileName);
                    hidePicBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)hidePicBox.Image;

            string text = textboxHide.Text;
            if (text.Equals(""))
            {
                MessageBox.Show("The text that you want to hide can't be empty", "Warning");
                return;
            }
            else;

            if(keyBox.Text.Equals("") || keyBox.Text.Length<6)
            {
                MessageBox.Show("Please enter a key with atleast 6 characters", "Warning");
                return;
            }
            else
            {
                text = EncryptionFile.EncryptStringAES(text, keyBox.Text);
                textboxHide.Text = text;
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonFileImport_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog fileDlg = new OpenFileDialog())
            {
                fileDlg.Title = "Select File";
                fileDlg.Filter = "Text Files (*.txt)|*.txt";

                if(fileDlg.ShowDialog() == DialogResult.OK)
                {
                    textboxHide.Text = File.ReadAllText(fileDlg.FileName);
                }
            }
        }
    }
}
