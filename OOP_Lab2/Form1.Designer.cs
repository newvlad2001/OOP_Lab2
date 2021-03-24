namespace OOP_Lab2_Form
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DrawPanel = new System.Windows.Forms.PictureBox();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.UndoButt = new System.Windows.Forms.Button();
            this.RedoButt = new System.Windows.Forms.Button();
            this.ColorButt = new System.Windows.Forms.Button();
            this.PenWidthBar = new System.Windows.Forms.TrackBar();
            this.ClearButt = new System.Windows.Forms.Button();
            this.TriangleButt = new System.Windows.Forms.Button();
            this.LineButt = new System.Windows.Forms.Button();
            this.RectButt = new System.Windows.Forms.Button();
            this.SquareButt = new System.Windows.Forms.Button();
            this.EllipseButt = new System.Windows.Forms.Button();
            this.CircleButt = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DrawPanel)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PenWidthBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawPanel
            // 
            this.DrawPanel.BackColor = System.Drawing.Color.White;
            this.DrawPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawPanel.Location = new System.Drawing.Point(0, 0);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(942, 530);
            this.DrawPanel.TabIndex = 1;
            this.DrawPanel.TabStop = false;
            this.DrawPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseDown);
            this.DrawPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseMove);
            this.DrawPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1021, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.saveFileToolStripMenuItem.Text = "Save File...";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "jpg (*.jpg)|*.jpg";
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Filter = "jpg (*.jpg)|*.jpg";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.UndoButt);
            this.splitContainer1.Panel1.Controls.Add(this.RedoButt);
            this.splitContainer1.Panel1.Controls.Add(this.ColorButt);
            this.splitContainer1.Panel1.Controls.Add(this.PenWidthBar);
            this.splitContainer1.Panel1.Controls.Add(this.ClearButt);
            this.splitContainer1.Panel1.Controls.Add(this.TriangleButt);
            this.splitContainer1.Panel1.Controls.Add(this.LineButt);
            this.splitContainer1.Panel1.Controls.Add(this.RectButt);
            this.splitContainer1.Panel1.Controls.Add(this.SquareButt);
            this.splitContainer1.Panel1.Controls.Add(this.EllipseButt);
            this.splitContainer1.Panel1.Controls.Add(this.CircleButt);
            this.splitContainer1.Panel1MinSize = 75;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DrawPanel);
            this.splitContainer1.Size = new System.Drawing.Size(1023, 532);
            this.splitContainer1.SplitterDistance = 75;
            this.splitContainer1.TabIndex = 3;
            // 
            // UndoButt
            // 
            this.UndoButt.Location = new System.Drawing.Point(7, 328);
            this.UndoButt.Name = "UndoButt";
            this.UndoButt.Size = new System.Drawing.Size(86, 23);
            this.UndoButt.TabIndex = 21;
            this.UndoButt.Text = "Undo";
            this.UndoButt.UseVisualStyleBackColor = true;
            this.UndoButt.Click += new System.EventHandler(this.UndoButt_Click);
            // 
            // RedoButt
            // 
            this.RedoButt.Location = new System.Drawing.Point(7, 357);
            this.RedoButt.Name = "RedoButt";
            this.RedoButt.Size = new System.Drawing.Size(86, 23);
            this.RedoButt.TabIndex = 20;
            this.RedoButt.Text = "Redo";
            this.RedoButt.UseVisualStyleBackColor = true;
            this.RedoButt.Click += new System.EventHandler(this.RedoButt_Click);
            // 
            // ColorButt
            // 
            this.ColorButt.BackColor = System.Drawing.Color.Black;
            this.ColorButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorButt.Location = new System.Drawing.Point(30, 240);
            this.ColorButt.Name = "ColorButt";
            this.ColorButt.Size = new System.Drawing.Size(40, 40);
            this.ColorButt.TabIndex = 19;
            this.ColorButt.UseVisualStyleBackColor = false;
            this.ColorButt.Click += new System.EventHandler(this.ColorButt_Click);
            // 
            // PenWidthBar
            // 
            this.PenWidthBar.Location = new System.Drawing.Point(7, 173);
            this.PenWidthBar.Name = "PenWidthBar";
            this.PenWidthBar.Size = new System.Drawing.Size(86, 56);
            this.PenWidthBar.TabIndex = 18;
            // 
            // ClearButt
            // 
            this.ClearButt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ClearButt.Location = new System.Drawing.Point(0, 507);
            this.ClearButt.Name = "ClearButt";
            this.ClearButt.Size = new System.Drawing.Size(73, 23);
            this.ClearButt.TabIndex = 17;
            this.ClearButt.Text = "Clear";
            this.ClearButt.UseVisualStyleBackColor = true;
            this.ClearButt.Click += new System.EventHandler(this.ClearButt_Click);
            // 
            // TriangleButt
            // 
            this.TriangleButt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TriangleButt.BackgroundImage")));
            this.TriangleButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TriangleButt.Location = new System.Drawing.Point(53, 95);
            this.TriangleButt.Name = "TriangleButt";
            this.TriangleButt.Size = new System.Drawing.Size(40, 40);
            this.TriangleButt.TabIndex = 16;
            this.TriangleButt.UseVisualStyleBackColor = true;
            this.TriangleButt.Click += new System.EventHandler(this.TriangleButt_Click);
            // 
            // LineButt
            // 
            this.LineButt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LineButt.BackgroundImage")));
            this.LineButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LineButt.Location = new System.Drawing.Point(53, 53);
            this.LineButt.Name = "LineButt";
            this.LineButt.Size = new System.Drawing.Size(40, 40);
            this.LineButt.TabIndex = 15;
            this.LineButt.UseVisualStyleBackColor = true;
            this.LineButt.Click += new System.EventHandler(this.LineButt_Click);
            // 
            // RectButt
            // 
            this.RectButt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RectButt.BackgroundImage")));
            this.RectButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RectButt.Location = new System.Drawing.Point(53, 11);
            this.RectButt.Name = "RectButt";
            this.RectButt.Size = new System.Drawing.Size(40, 40);
            this.RectButt.TabIndex = 14;
            this.RectButt.UseVisualStyleBackColor = true;
            this.RectButt.Click += new System.EventHandler(this.RectButt_Click);
            // 
            // SquareButt
            // 
            this.SquareButt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SquareButt.BackgroundImage")));
            this.SquareButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SquareButt.Location = new System.Drawing.Point(7, 95);
            this.SquareButt.Name = "SquareButt";
            this.SquareButt.Size = new System.Drawing.Size(40, 40);
            this.SquareButt.TabIndex = 13;
            this.SquareButt.UseVisualStyleBackColor = true;
            this.SquareButt.Click += new System.EventHandler(this.SquareButt_Click);
            // 
            // EllipseButt
            // 
            this.EllipseButt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EllipseButt.BackgroundImage")));
            this.EllipseButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EllipseButt.Location = new System.Drawing.Point(7, 53);
            this.EllipseButt.Name = "EllipseButt";
            this.EllipseButt.Size = new System.Drawing.Size(40, 40);
            this.EllipseButt.TabIndex = 12;
            this.EllipseButt.UseVisualStyleBackColor = true;
            this.EllipseButt.Click += new System.EventHandler(this.EllipseButt_Click);
            // 
            // CircleButt
            // 
            this.CircleButt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CircleButt.BackgroundImage")));
            this.CircleButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CircleButt.Location = new System.Drawing.Point(7, 11);
            this.CircleButt.Name = "CircleButt";
            this.CircleButt.Size = new System.Drawing.Size(40, 40);
            this.CircleButt.TabIndex = 11;
            this.CircleButt.UseVisualStyleBackColor = true;
            this.CircleButt.Click += new System.EventHandler(this.CircleButt_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(1023, 561);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Thickness";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Color";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 561);
            this.Controls.Add(this.splitContainer2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyPaint";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DrawPanel)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PenWidthBar)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox DrawPanel;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button UndoButt;
        private System.Windows.Forms.Button RedoButt;
        private System.Windows.Forms.Button ColorButt;
        private System.Windows.Forms.TrackBar PenWidthBar;
        private System.Windows.Forms.Button ClearButt;
        private System.Windows.Forms.Button TriangleButt;
        private System.Windows.Forms.Button LineButt;
        private System.Windows.Forms.Button RectButt;
        private System.Windows.Forms.Button SquareButt;
        private System.Windows.Forms.Button EllipseButt;
        private System.Windows.Forms.Button CircleButt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}