namespace photoegg4._1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.載入圖片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.濾鏡ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.反向ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.詼諧ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.模糊ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.風格化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.浮雕ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.馬賽克ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.色彩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.亮度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.磁磚ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.翻轉ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水平翻轉ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.垂直翻轉ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(21, 21);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.濾鏡ToolStripMenuItem,
            this.色彩ToolStripMenuItem,
            this.翻轉ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(533, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.載入圖片ToolStripMenuItem});
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.檔案ToolStripMenuItem.Text = "檔案";
            // 
            // 載入圖片ToolStripMenuItem
            // 
            this.載入圖片ToolStripMenuItem.Name = "載入圖片ToolStripMenuItem";
            this.載入圖片ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.載入圖片ToolStripMenuItem.Text = "載入圖片";
            this.載入圖片ToolStripMenuItem.Click += new System.EventHandler(this.載入圖片ToolStripMenuItem_Click);
            // 
            // 濾鏡ToolStripMenuItem
            // 
            this.濾鏡ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.反向ToolStripMenuItem,
            this.詼諧ToolStripMenuItem,
            this.模糊ToolStripMenuItem,
            this.風格化ToolStripMenuItem,
            this.馬賽克ToolStripMenuItem});
            this.濾鏡ToolStripMenuItem.Name = "濾鏡ToolStripMenuItem";
            this.濾鏡ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.濾鏡ToolStripMenuItem.Text = "濾鏡";
            // 
            // 反向ToolStripMenuItem
            // 
            this.反向ToolStripMenuItem.Name = "反向ToolStripMenuItem";
            this.反向ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.反向ToolStripMenuItem.Text = "反向";
            this.反向ToolStripMenuItem.Click += new System.EventHandler(this.反向ToolStripMenuItem_Click);
            // 
            // 詼諧ToolStripMenuItem
            // 
            this.詼諧ToolStripMenuItem.Name = "詼諧ToolStripMenuItem";
            this.詼諧ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.詼諧ToolStripMenuItem.Text = "詼諧";
            this.詼諧ToolStripMenuItem.Click += new System.EventHandler(this.詼諧ToolStripMenuItem_Click);
            // 
            // 模糊ToolStripMenuItem
            // 
            this.模糊ToolStripMenuItem.Name = "模糊ToolStripMenuItem";
            this.模糊ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.模糊ToolStripMenuItem.Text = "模糊";
            this.模糊ToolStripMenuItem.Click += new System.EventHandler(this.模糊ToolStripMenuItem_Click);
            // 
            // 風格化ToolStripMenuItem
            // 
            this.風格化ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.浮雕ToolStripMenuItem,
            this.磁磚ToolStripMenuItem});
            this.風格化ToolStripMenuItem.Name = "風格化ToolStripMenuItem";
            this.風格化ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.風格化ToolStripMenuItem.Text = "風格化";
            // 
            // 浮雕ToolStripMenuItem
            // 
            this.浮雕ToolStripMenuItem.Name = "浮雕ToolStripMenuItem";
            this.浮雕ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.浮雕ToolStripMenuItem.Text = "浮雕";
            this.浮雕ToolStripMenuItem.Click += new System.EventHandler(this.浮雕ToolStripMenuItem_Click);
            // 
            // 馬賽克ToolStripMenuItem
            // 
            this.馬賽克ToolStripMenuItem.Name = "馬賽克ToolStripMenuItem";
            this.馬賽克ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.馬賽克ToolStripMenuItem.Text = "馬賽克";
            this.馬賽克ToolStripMenuItem.Click += new System.EventHandler(this.馬賽克ToolStripMenuItem_Click);
            // 
            // 色彩ToolStripMenuItem
            // 
            this.色彩ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.亮度ToolStripMenuItem,
            this.hSVToolStripMenuItem});
            this.色彩ToolStripMenuItem.Name = "色彩ToolStripMenuItem";
            this.色彩ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.色彩ToolStripMenuItem.Text = "色彩";
            // 
            // 亮度ToolStripMenuItem
            // 
            this.亮度ToolStripMenuItem.Name = "亮度ToolStripMenuItem";
            this.亮度ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.亮度ToolStripMenuItem.Text = "亮度";
            this.亮度ToolStripMenuItem.Click += new System.EventHandler(this.亮度ToolStripMenuItem_Click);
            // 
            // hSVToolStripMenuItem
            // 
            this.hSVToolStripMenuItem.Name = "hSVToolStripMenuItem";
            this.hSVToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.hSVToolStripMenuItem.Text = "HSV";
            this.hSVToolStripMenuItem.Click += new System.EventHandler(this.HSVToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 314);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(533, 314);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // 磁磚ToolStripMenuItem
            // 
            this.磁磚ToolStripMenuItem.Name = "磁磚ToolStripMenuItem";
            this.磁磚ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.磁磚ToolStripMenuItem.Text = "磁磚";
            this.磁磚ToolStripMenuItem.Click += new System.EventHandler(this.磁磚ToolStripMenuItem_Click);
            // 
            // 翻轉ToolStripMenuItem
            // 
            this.翻轉ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.水平翻轉ToolStripMenuItem,
            this.垂直翻轉ToolStripMenuItem});
            this.翻轉ToolStripMenuItem.Name = "翻轉ToolStripMenuItem";
            this.翻轉ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.翻轉ToolStripMenuItem.Text = "翻轉";
            // 
            // 水平翻轉ToolStripMenuItem
            // 
            this.水平翻轉ToolStripMenuItem.Name = "水平翻轉ToolStripMenuItem";
            this.水平翻轉ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.水平翻轉ToolStripMenuItem.Text = "水平翻轉";
            this.水平翻轉ToolStripMenuItem.Click += new System.EventHandler(this.水平翻轉ToolStripMenuItem_Click);
            // 
            // 垂直翻轉ToolStripMenuItem
            // 
            this.垂直翻轉ToolStripMenuItem.Name = "垂直翻轉ToolStripMenuItem";
            this.垂直翻轉ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.垂直翻轉ToolStripMenuItem.Text = "垂直翻轉";
            this.垂直翻轉ToolStripMenuItem.Click += new System.EventHandler(this.垂直翻轉ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 338);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 載入圖片ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem 濾鏡ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 反向ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 詼諧ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 色彩ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 亮度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 模糊ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 風格化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 浮雕ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 馬賽克ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 磁磚ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 翻轉ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 水平翻轉ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 垂直翻轉ToolStripMenuItem;
    }
}

