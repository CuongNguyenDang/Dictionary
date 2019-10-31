namespace Dictionary_winform
{
    partial class Dictionary_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dictionary_form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.InputWord = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TabControl();
            this.EN_VI = new System.Windows.Forms.TabPage();
            this.ListEnViWord = new System.Windows.Forms.ListBox();
            this.VI_EN = new System.Windows.Forms.TabPage();
            this.ListVIEnWord = new System.Windows.Forms.ListBox();
            this.HistoryWordList = new System.Windows.Forms.Button();
            this.SearchWord = new System.Windows.Forms.Button();
            this.BackInHistoryList = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.randomWord = new System.Windows.Forms.Button();
            this.delWord = new System.Windows.Forms.Button();
            this.addWord = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ReadWord = new System.Windows.Forms.Button();
            this.txtMeaning = new System.Windows.Forms.TextBox();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordsStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.SearchBox.SuspendLayout();
            this.EN_VI.SuspendLayout();
            this.VI_EN.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.InputWord);
            this.panel1.Controls.Add(this.SearchBox);
            this.panel1.Controls.Add(this.HistoryWordList);
            this.panel1.Controls.Add(this.SearchWord);
            this.panel1.Controls.Add(this.BackInHistoryList);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.randomWord);
            this.panel1.Controls.Add(this.delWord);
            this.panel1.Controls.Add(this.addWord);
            this.panel1.Location = new System.Drawing.Point(9, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 437);
            this.panel1.TabIndex = 1;
            // 
            // InputWord
            // 
            this.InputWord.AutoSize = true;
            this.InputWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputWord.ForeColor = System.Drawing.Color.DarkOrange;
            this.InputWord.Location = new System.Drawing.Point(3, -3);
            this.InputWord.Name = "InputWord";
            this.InputWord.Size = new System.Drawing.Size(80, 25);
            this.InputWord.TabIndex = 3;
            this.InputWord.Text = "Nhập từ";
            // 
            // SearchBox
            // 
            this.SearchBox.Controls.Add(this.EN_VI);
            this.SearchBox.Controls.Add(this.VI_EN);
            this.SearchBox.Location = new System.Drawing.Point(3, 67);
            this.SearchBox.Multiline = true;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.SelectedIndex = 0;
            this.SearchBox.Size = new System.Drawing.Size(185, 328);
            this.SearchBox.TabIndex = 9;
            // 
            // EN_VI
            // 
            this.EN_VI.Controls.Add(this.ListEnViWord);
            this.EN_VI.Location = new System.Drawing.Point(4, 25);
            this.EN_VI.Name = "EN_VI";
            this.EN_VI.Padding = new System.Windows.Forms.Padding(3);
            this.EN_VI.Size = new System.Drawing.Size(177, 299);
            this.EN_VI.TabIndex = 0;
            this.EN_VI.Text = "Anh-Việt";
            this.EN_VI.UseVisualStyleBackColor = true;
            // 
            // ListEnViWord
            // 
            this.ListEnViWord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListEnViWord.FormattingEnabled = true;
            this.ListEnViWord.ItemHeight = 16;
            this.ListEnViWord.Location = new System.Drawing.Point(0, 1);
            this.ListEnViWord.Name = "ListEnViWord";
            this.ListEnViWord.Size = new System.Drawing.Size(181, 308);
            this.ListEnViWord.TabIndex = 0;
            this.ListEnViWord.SelectedIndexChanged += new System.EventHandler(this.ListEnViWord_SelectedIndexChanged);
            // 
            // VI_EN
            // 
            this.VI_EN.Controls.Add(this.ListVIEnWord);
            this.VI_EN.Location = new System.Drawing.Point(4, 25);
            this.VI_EN.Name = "VI_EN";
            this.VI_EN.Padding = new System.Windows.Forms.Padding(3);
            this.VI_EN.Size = new System.Drawing.Size(177, 299);
            this.VI_EN.TabIndex = 1;
            this.VI_EN.Text = "Việt-Anh";
            this.VI_EN.UseVisualStyleBackColor = true;
            // 
            // ListVIEnWord
            // 
            this.ListVIEnWord.FormattingEnabled = true;
            this.ListVIEnWord.ItemHeight = 16;
            this.ListVIEnWord.Location = new System.Drawing.Point(-4, 2);
            this.ListVIEnWord.Name = "ListVIEnWord";
            this.ListVIEnWord.Size = new System.Drawing.Size(181, 292);
            this.ListVIEnWord.TabIndex = 0;
            this.ListVIEnWord.SelectedIndexChanged += new System.EventHandler(this.ListVIEnWord_SelectedIndexChanged);
            // 
            // HistoryWordList
            // 
            this.HistoryWordList.Location = new System.Drawing.Point(101, 403);
            this.HistoryWordList.Name = "HistoryWordList";
            this.HistoryWordList.Size = new System.Drawing.Size(87, 24);
            this.HistoryWordList.TabIndex = 8;
            this.HistoryWordList.Text = "History";
            this.HistoryWordList.UseVisualStyleBackColor = true;
            // 
            // SearchWord
            // 
            this.SearchWord.Image = ((System.Drawing.Image)(resources.GetObject("SearchWord.Image")));
            this.SearchWord.Location = new System.Drawing.Point(189, 17);
            this.SearchWord.Name = "SearchWord";
            this.SearchWord.Size = new System.Drawing.Size(52, 51);
            this.SearchWord.TabIndex = 6;
            this.SearchWord.UseVisualStyleBackColor = true;
            // 
            // BackInHistoryList
            // 
            this.BackInHistoryList.Location = new System.Drawing.Point(0, 401);
            this.BackInHistoryList.Name = "BackInHistoryList";
            this.BackInHistoryList.Size = new System.Drawing.Size(43, 26);
            this.BackInHistoryList.TabIndex = 7;
            this.BackInHistoryList.Text = "<<";
            this.BackInHistoryList.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(1, 25);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(183, 27);
            this.textBox3.TabIndex = 4;
            // 
            // randomWord
            // 
            this.randomWord.Location = new System.Drawing.Point(194, 233);
            this.randomWord.Name = "randomWord";
            this.randomWord.Size = new System.Drawing.Size(75, 27);
            this.randomWord.TabIndex = 3;
            this.randomWord.Text = "Random";
            this.randomWord.UseVisualStyleBackColor = true;
            // 
            // delWord
            // 
            this.delWord.Location = new System.Drawing.Point(194, 165);
            this.delWord.Name = "delWord";
            this.delWord.Size = new System.Drawing.Size(75, 27);
            this.delWord.TabIndex = 2;
            this.delWord.Text = "Delete";
            this.delWord.UseVisualStyleBackColor = true;
            this.delWord.Click += new System.EventHandler(this.delWord_Click);
            // 
            // addWord
            // 
            this.addWord.Location = new System.Drawing.Point(194, 97);
            this.addWord.Name = "addWord";
            this.addWord.Size = new System.Drawing.Size(75, 27);
            this.addWord.TabIndex = 1;
            this.addWord.Text = "Add";
            this.addWord.UseVisualStyleBackColor = true;
            this.addWord.Click += new System.EventHandler(this.addWord_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ReadWord);
            this.panel2.Controls.Add(this.txtMeaning);
            this.panel2.Location = new System.Drawing.Point(478, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(511, 396);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // ReadWord
            // 
            this.ReadWord.Image = ((System.Drawing.Image)(resources.GetObject("ReadWord.Image")));
            this.ReadWord.Location = new System.Drawing.Point(29, 23);
            this.ReadWord.Name = "ReadWord";
            this.ReadWord.Size = new System.Drawing.Size(50, 45);
            this.ReadWord.TabIndex = 2;
            this.ReadWord.UseVisualStyleBackColor = true;
            // 
            // txtMeaning
            // 
            this.txtMeaning.Location = new System.Drawing.Point(29, 71);
            this.txtMeaning.Multiline = true;
            this.txtMeaning.Name = "txtMeaning";
            this.txtMeaning.Size = new System.Drawing.Size(462, 316);
            this.txtMeaning.TabIndex = 1;
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // wordsStoreToolStripMenuItem
            // 
            this.wordsStoreToolStripMenuItem.Name = "wordsStoreToolStripMenuItem";
            this.wordsStoreToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.wordsStoreToolStripMenuItem.Text = "Words Store";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.wordsStoreToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1012, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(309, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Dictionary_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1012, 506);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dictionary_form";
            this.Text = "Dictionary";
            this.Load += new System.EventHandler(this.Dictionary_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SearchBox.ResumeLayout(false);
            this.EN_VI.ResumeLayout(false);
            this.VI_EN.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ReadWord;
        private System.Windows.Forms.TextBox txtMeaning;
        private System.Windows.Forms.TabControl SearchBox;
        private System.Windows.Forms.TabPage VI_EN;
        private System.Windows.Forms.ListBox ListVIEnWord;
        private System.Windows.Forms.Button HistoryWordList;
        private System.Windows.Forms.Button BackInHistoryList;
        private System.Windows.Forms.Button SearchWord;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button randomWord;
        private System.Windows.Forms.Button delWord;
        private System.Windows.Forms.Button addWord;
        private System.Windows.Forms.Label InputWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordsStoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage EN_VI;
        private System.Windows.Forms.ListBox ListEnViWord;
    }
}

