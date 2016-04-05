using System;
using System.Drawing;
using System.Windows.Forms;

namespace StegoFinal
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; 
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Cursor = Cursors.Arrow;
            Icon icon = Icon.ExtractAssociatedIcon("C:/Users/Arjun Panicker/Documents/Visual Studio 2015/Projects/StegoFinal/Stego.ico");
            this.Icon = icon;
            MaximizeBox = false;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gotoHiding(object sender, EventArgs e)
        {
            Visible = false;
            Hiding_Tool hider = new Hiding_Tool();
            hider.ShowDialog(this);
            Visible = true;
        }

        private void gotoExtraction(object sender, EventArgs e)
        {
            Visible = false;
            Extraction_Tool extract = new Extraction_Tool();
            extract.ShowDialog(this);
            Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.AutoSize = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made By:-\n\tAditya Bharti\t1031310393\n\tArjun Panicker\t1031310398\n\tDipannita Panda\t1031310399\n\nSafe Pic @2016", "About");
        }
    }
}
