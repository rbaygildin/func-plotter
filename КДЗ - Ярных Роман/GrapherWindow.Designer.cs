namespace КДЗ___Ярных_Роман
{
    partial class GrapherWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butDrawGraph = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trBarZ = new System.Windows.Forms.TrackBar();
            this.trBarY = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxXmax = new System.Windows.Forms.TextBox();
            this.tboxDx = new System.Windows.Forms.TextBox();
            this.tboxXmin = new System.Windows.Forms.TextBox();
            this.graphicsBox = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hintProvider = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.funcvaluestip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trBarZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBarY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphicsBox)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.butDrawGraph);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.trBarZ);
            this.groupBox1.Controls.Add(this.trBarY);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tboxXmax);
            this.groupBox1.Controls.Add(this.tboxDx);
            this.groupBox1.Controls.Add(this.tboxXmin);
            this.groupBox1.Location = new System.Drawing.Point(825, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 332);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод параметров функции";
            // 
            // butDrawGraph
            // 
            this.butDrawGraph.Location = new System.Drawing.Point(24, 290);
            this.butDrawGraph.Name = "butDrawGraph";
            this.butDrawGraph.Size = new System.Drawing.Size(166, 23);
            this.butDrawGraph.TabIndex = 10;
            this.butDrawGraph.Text = "Нарисовать график";
            this.butDrawGraph.UseVisualStyleBackColor = true;
            this.butDrawGraph.Click += new System.EventHandler(this.butDrawGraph_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Параметр Z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Параметр Y";
            // 
            // trBarZ
            // 
            this.trBarZ.Location = new System.Drawing.Point(6, 239);
            this.trBarZ.Maximum = 40;
            this.trBarZ.Name = "trBarZ";
            this.trBarZ.Size = new System.Drawing.Size(207, 45);
            this.trBarZ.TabIndex = 7;
            this.trBarZ.Scroll += new System.EventHandler(this.trBar_Scroll);
            // 
            // trBarY
            // 
            this.trBarY.Location = new System.Drawing.Point(6, 187);
            this.trBarY.Maximum = 40;
            this.trBarY.Name = "trBarY";
            this.trBarY.Size = new System.Drawing.Size(207, 45);
            this.trBarY.TabIndex = 6;
            this.trBarY.Scroll += new System.EventHandler(this.trBar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "dx";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Xmax";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Xmin";
            // 
            // tboxXmax
            // 
            this.tboxXmax.Location = new System.Drawing.Point(62, 76);
            this.tboxXmax.Name = "tboxXmax";
            this.tboxXmax.Size = new System.Drawing.Size(100, 20);
            this.tboxXmax.TabIndex = 2;
            // 
            // tboxDx
            // 
            this.tboxDx.Location = new System.Drawing.Point(62, 118);
            this.tboxDx.Name = "tboxDx";
            this.tboxDx.Size = new System.Drawing.Size(100, 20);
            this.tboxDx.TabIndex = 1;
            // 
            // tboxXmin
            // 
            this.tboxXmin.Location = new System.Drawing.Point(62, 37);
            this.tboxXmin.Name = "tboxXmin";
            this.tboxXmin.Size = new System.Drawing.Size(100, 20);
            this.tboxXmin.TabIndex = 0;
            // 
            // graphicsBox
            // 
            this.graphicsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graphicsBox.BackColor = System.Drawing.Color.White;
            this.graphicsBox.Location = new System.Drawing.Point(12, 46);
            this.graphicsBox.Name = "graphicsBox";
            this.graphicsBox.Size = new System.Drawing.Size(813, 596);
            this.graphicsBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.graphicsBox.TabIndex = 1;
            this.graphicsBox.TabStop = false;
            this.graphicsBox.SizeChanged += new System.EventHandler(this.graphicsBox_SizeChanged);
            this.graphicsBox.Paint += new System.Windows.Forms.PaintEventHandler(this.graphicsBox_Paint);
            this.graphicsBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.graphicsBox_MouseMove);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1037, 24);
            this.menuStrip.TabIndex = 12;
            this.menuStrip.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // GrapherWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 644);
            this.Controls.Add(this.graphicsBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip);
            this.MinimumSize = new System.Drawing.Size(1053, 682);
            this.Name = "GrapherWindow";
            this.Text = "Построение графика";
            this.Load += new System.EventHandler(this.GrapherWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trBarZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBarY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphicsBox)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trBarZ;
        private System.Windows.Forms.TrackBar trBarY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxXmax;
        private System.Windows.Forms.TextBox tboxDx;
        private System.Windows.Forms.TextBox tboxXmin;
        private System.Windows.Forms.PictureBox graphicsBox;
        private System.Windows.Forms.Button butDrawGraph;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolTip hintProvider;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ToolTip funcvaluestip;
    }
}

