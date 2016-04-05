using System;
using System.Drawing;
using System.Windows.Forms;

namespace StegoFinal
{
    public partial class Extraction_Tool : Form
    {
        public Extraction_Tool()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Cursor = Cursors.Arrow;
            Icon icon= Icon.ExtractAssociatedIcon("C:/Users/Arjun Panicker/Documents/Visual Studio 2015/Projects/StegoFinal/Stego.ico");
            this.Icon = icon;
            MaximizeBox = false;
        }

        private void selectImage_Click(object sender, EventArgs e)
        {

        }

        private void buttonExtract_Click(object sender, EventArgs e)
        {

        }

        private void selectImageExtract_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog dig = new OpenFileDialog())
            {
                dig.Title = "Open Image";
                dig.Filter = "All Files(*.*)|*.*|JPEG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png";


                if(dig.ShowDialog() == DialogResult.OK)
                {
                    pathImageExtract.Text = dig.FileName;
                    extractPicBox.Image = new Bitmap(dig.FileName);
                    extractPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //InitializeComponent();
        }
    }
}
