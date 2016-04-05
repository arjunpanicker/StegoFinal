namespace StegoFinal
{
    partial class Hiding_Tool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hiding_Tool));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.statusHide = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonFileImport = new System.Windows.Forms.Button();
            this.buttonHide = new System.Windows.Forms.Button();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxHide = new System.Windows.Forms.TextBox();
            this.pathImageHide = new System.Windows.Forms.Label();
            this.selectImageHide = new System.Windows.Forms.Button();
            this.hidePicBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusHide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hidePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1205, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.newToolStripMenuItem.Text = "New";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(111, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.Panel1.Controls.Add(this.statusHide);
            this.splitContainer1.Panel1.Controls.Add(this.buttonFileImport);
            this.splitContainer1.Panel1.Controls.Add(this.buttonHide);
            this.splitContainer1.Panel1.Controls.Add(this.keyBox);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.textboxHide);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.Panel2.Controls.Add(this.pathImageHide);
            this.splitContainer1.Panel2.Controls.Add(this.selectImageHide);
            this.splitContainer1.Panel2.Controls.Add(this.hidePicBox);
            this.splitContainer1.Size = new System.Drawing.Size(1205, 652);
            this.splitContainer1.SplitterDistance = 451;
            this.splitContainer1.TabIndex = 1;
            // 
            // statusHide
            // 
            this.statusHide.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusHide.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusHide.Location = new System.Drawing.Point(0, 627);
            this.statusHide.Name = "statusHide";
            this.statusHide.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusHide.Size = new System.Drawing.Size(451, 25);
            this.statusHide.TabIndex = 5;
            this.statusHide.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 20);
            this.toolStripStatusLabel1.Text = "Status: ";
            // 
            // buttonFileImport
            // 
            this.buttonFileImport.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonFileImport.Location = new System.Drawing.Point(146, 375);
            this.buttonFileImport.Name = "buttonFileImport";
            this.buttonFileImport.Size = new System.Drawing.Size(153, 41);
            this.buttonFileImport.TabIndex = 4;
            this.buttonFileImport.Text = "Import from File";
            this.buttonFileImport.UseVisualStyleBackColor = false;
            this.buttonFileImport.Click += new System.EventHandler(this.buttonFileImport_Click);
            // 
            // buttonHide
            // 
            this.buttonHide.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonHide.Location = new System.Drawing.Point(130, 554);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(179, 43);
            this.buttonHide.TabIndex = 3;
            this.buttonHide.Text = "Hide Message !!";
            this.buttonHide.UseVisualStyleBackColor = false;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(266, 456);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(143, 22);
            this.keyBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Key";
            // 
            // textboxHide
            // 
            this.textboxHide.Location = new System.Drawing.Point(46, 49);
            this.textboxHide.Multiline = true;
            this.textboxHide.Name = "textboxHide";
            this.textboxHide.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textboxHide.Size = new System.Drawing.Size(363, 302);
            this.textboxHide.TabIndex = 0;
            this.textboxHide.Text = "Type your message Here to Hide.";
            // 
            // pathImageHide
            // 
            this.pathImageHide.AutoSize = true;
            this.pathImageHide.Location = new System.Drawing.Point(26, 598);
            this.pathImageHide.Name = "pathImageHide";
            this.pathImageHide.Size = new System.Drawing.Size(119, 17);
            this.pathImageHide.TabIndex = 2;
            this.pathImageHide.Text = "Path of the Image";
            // 
            // selectImageHide
            // 
            this.selectImageHide.BackColor = System.Drawing.Color.SteelBlue;
            this.selectImageHide.Location = new System.Drawing.Point(581, 582);
            this.selectImageHide.Name = "selectImageHide";
            this.selectImageHide.Size = new System.Drawing.Size(155, 33);
            this.selectImageHide.TabIndex = 1;
            this.selectImageHide.Text = "Select Image";
            this.selectImageHide.UseVisualStyleBackColor = false;
            this.selectImageHide.Click += new System.EventHandler(this.selectImage_Click);
            // 
            // hidePicBox
            // 
            this.hidePicBox.Location = new System.Drawing.Point(18, 17);
            this.hidePicBox.Name = "hidePicBox";
            this.hidePicBox.Size = new System.Drawing.Size(718, 534);
            this.hidePicBox.TabIndex = 0;
            this.hidePicBox.TabStop = false;
            // 
            // Hiding_Tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 680);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Hiding_Tool";
            this.Text = "Hiding_Tool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusHide.ResumeLayout(false);
            this.statusHide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hidePicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label pathImageHide;
        private System.Windows.Forms.Button selectImageHide;
        private System.Windows.Forms.PictureBox hidePicBox;
        private System.Windows.Forms.TextBox textboxHide;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFileImport;
        private System.Windows.Forms.StatusStrip statusHide;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}