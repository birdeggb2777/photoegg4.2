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
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.載入圖片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編輯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.複製ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.貼上ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.濾鏡ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.反向ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.詼諧ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.模糊ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.二值化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.風格化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.浮雕ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.磁磚ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.油畫ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.噴槍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.萬花筒ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.馬賽克ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.色調分離ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.曝光過度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.彩色雜點ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.掃描線ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.色彩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.亮度對比ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.翻轉ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水平翻轉ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.垂直翻轉ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.明暗度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.旋轉180度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.編輯ToolStripMenuItem,
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
            // 編輯ToolStripMenuItem
            // 
            this.編輯ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.複製ToolStripMenuItem,
            this.貼上ToolStripMenuItem});
            this.編輯ToolStripMenuItem.Name = "編輯ToolStripMenuItem";
            this.編輯ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.編輯ToolStripMenuItem.Text = "編輯";
            // 
            // 複製ToolStripMenuItem
            // 
            this.複製ToolStripMenuItem.Name = "複製ToolStripMenuItem";
            this.複製ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.複製ToolStripMenuItem.Text = "複製";
            this.複製ToolStripMenuItem.Click += new System.EventHandler(this.複製ToolStripMenuItem_Click);
            // 
            // 貼上ToolStripMenuItem
            // 
            this.貼上ToolStripMenuItem.Name = "貼上ToolStripMenuItem";
            this.貼上ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.貼上ToolStripMenuItem.Text = "貼上";
            this.貼上ToolStripMenuItem.Click += new System.EventHandler(this.貼上ToolStripMenuItem_Click);
            // 
            // 濾鏡ToolStripMenuItem
            // 
            this.濾鏡ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.反向ToolStripMenuItem,
            this.詼諧ToolStripMenuItem,
            this.模糊ToolStripMenuItem,
            this.二值化ToolStripMenuItem,
            this.風格化ToolStripMenuItem,
            this.馬賽克ToolStripMenuItem,
            this.色調分離ToolStripMenuItem,
            this.曝光過度ToolStripMenuItem,
            this.彩色雜點ToolStripMenuItem,
            this.掃描線ToolStripMenuItem});
            this.濾鏡ToolStripMenuItem.Name = "濾鏡ToolStripMenuItem";
            this.濾鏡ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.濾鏡ToolStripMenuItem.Text = "濾鏡";
            // 
            // 反向ToolStripMenuItem
            // 
            this.反向ToolStripMenuItem.Name = "反向ToolStripMenuItem";
            this.反向ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.反向ToolStripMenuItem.Text = "反向";
            this.反向ToolStripMenuItem.Click += new System.EventHandler(this.反向ToolStripMenuItem_Click);
            // 
            // 詼諧ToolStripMenuItem
            // 
            this.詼諧ToolStripMenuItem.Name = "詼諧ToolStripMenuItem";
            this.詼諧ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.詼諧ToolStripMenuItem.Text = "詼諧";
            this.詼諧ToolStripMenuItem.Click += new System.EventHandler(this.詼諧ToolStripMenuItem_Click);
            // 
            // 模糊ToolStripMenuItem
            // 
            this.模糊ToolStripMenuItem.Name = "模糊ToolStripMenuItem";
            this.模糊ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.模糊ToolStripMenuItem.Text = "模糊";
            this.模糊ToolStripMenuItem.Click += new System.EventHandler(this.模糊ToolStripMenuItem_Click);
            // 
            // 二值化ToolStripMenuItem
            // 
            this.二值化ToolStripMenuItem.Name = "二值化ToolStripMenuItem";
            this.二值化ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.二值化ToolStripMenuItem.Text = "二值化";
            this.二值化ToolStripMenuItem.Click += new System.EventHandler(this.二值化ToolStripMenuItem_Click);
            // 
            // 風格化ToolStripMenuItem
            // 
            this.風格化ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.浮雕ToolStripMenuItem,
            this.磁磚ToolStripMenuItem,
            this.油畫ToolStripMenuItem,
            this.噴槍ToolStripMenuItem,
            this.萬花筒ToolStripMenuItem});
            this.風格化ToolStripMenuItem.Name = "風格化ToolStripMenuItem";
            this.風格化ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.風格化ToolStripMenuItem.Text = "風格化";
            // 
            // 浮雕ToolStripMenuItem
            // 
            this.浮雕ToolStripMenuItem.Name = "浮雕ToolStripMenuItem";
            this.浮雕ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.浮雕ToolStripMenuItem.Text = "浮雕";
            this.浮雕ToolStripMenuItem.Click += new System.EventHandler(this.浮雕ToolStripMenuItem_Click);
            // 
            // 磁磚ToolStripMenuItem
            // 
            this.磁磚ToolStripMenuItem.Name = "磁磚ToolStripMenuItem";
            this.磁磚ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.磁磚ToolStripMenuItem.Text = "磁磚";
            this.磁磚ToolStripMenuItem.Click += new System.EventHandler(this.磁磚ToolStripMenuItem_Click);
            // 
            // 油畫ToolStripMenuItem
            // 
            this.油畫ToolStripMenuItem.Name = "油畫ToolStripMenuItem";
            this.油畫ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.油畫ToolStripMenuItem.Text = "油畫";
            this.油畫ToolStripMenuItem.Click += new System.EventHandler(this.油畫ToolStripMenuItem_Click);
            // 
            // 噴槍ToolStripMenuItem
            // 
            this.噴槍ToolStripMenuItem.Name = "噴槍ToolStripMenuItem";
            this.噴槍ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.噴槍ToolStripMenuItem.Text = "噴槍";
            this.噴槍ToolStripMenuItem.Click += new System.EventHandler(this.噴槍ToolStripMenuItem_Click);
            // 
            // 萬花筒ToolStripMenuItem
            // 
            this.萬花筒ToolStripMenuItem.Name = "萬花筒ToolStripMenuItem";
            this.萬花筒ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.萬花筒ToolStripMenuItem.Text = "萬花筒";
            this.萬花筒ToolStripMenuItem.Click += new System.EventHandler(this.萬花筒ToolStripMenuItem_Click);
            // 
            // 馬賽克ToolStripMenuItem
            // 
            this.馬賽克ToolStripMenuItem.Name = "馬賽克ToolStripMenuItem";
            this.馬賽克ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.馬賽克ToolStripMenuItem.Text = "馬賽克";
            this.馬賽克ToolStripMenuItem.Click += new System.EventHandler(this.馬賽克ToolStripMenuItem_Click);
            // 
            // 色調分離ToolStripMenuItem
            // 
            this.色調分離ToolStripMenuItem.Name = "色調分離ToolStripMenuItem";
            this.色調分離ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.色調分離ToolStripMenuItem.Text = "色調分離";
            this.色調分離ToolStripMenuItem.Click += new System.EventHandler(this.色調分離ToolStripMenuItem_Click);
            // 
            // 曝光過度ToolStripMenuItem
            // 
            this.曝光過度ToolStripMenuItem.Name = "曝光過度ToolStripMenuItem";
            this.曝光過度ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.曝光過度ToolStripMenuItem.Text = "曝光過度";
            this.曝光過度ToolStripMenuItem.Click += new System.EventHandler(this.曝光過度ToolStripMenuItem_Click);
            // 
            // 彩色雜點ToolStripMenuItem
            // 
            this.彩色雜點ToolStripMenuItem.Name = "彩色雜點ToolStripMenuItem";
            this.彩色雜點ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.彩色雜點ToolStripMenuItem.Text = "彩色雜點";
            this.彩色雜點ToolStripMenuItem.Click += new System.EventHandler(this.彩色雜點ToolStripMenuItem_Click);
            // 
            // 掃描線ToolStripMenuItem
            // 
            this.掃描線ToolStripMenuItem.Name = "掃描線ToolStripMenuItem";
            this.掃描線ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.掃描線ToolStripMenuItem.Text = "掃描線";
            this.掃描線ToolStripMenuItem.Click += new System.EventHandler(this.掃描線ToolStripMenuItem_Click);
            // 
            // 色彩ToolStripMenuItem
            // 
            this.色彩ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.亮度對比ToolStripMenuItem,
            this.hSVToolStripMenuItem,
            this.明暗度ToolStripMenuItem});
            this.色彩ToolStripMenuItem.Name = "色彩ToolStripMenuItem";
            this.色彩ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.色彩ToolStripMenuItem.Text = "色彩";
            // 
            // 亮度對比ToolStripMenuItem
            // 
            this.亮度對比ToolStripMenuItem.Name = "亮度對比ToolStripMenuItem";
            this.亮度對比ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.亮度對比ToolStripMenuItem.Text = "亮度、對比";
            this.亮度對比ToolStripMenuItem.Click += new System.EventHandler(this.亮度對比ToolStripMenuItem_Click);
            // 
            // hSVToolStripMenuItem
            // 
            this.hSVToolStripMenuItem.Name = "hSVToolStripMenuItem";
            this.hSVToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hSVToolStripMenuItem.Text = "HSV";
            this.hSVToolStripMenuItem.Click += new System.EventHandler(this.HSVToolStripMenuItem_Click);
            // 
            // 翻轉ToolStripMenuItem
            // 
            this.翻轉ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.水平翻轉ToolStripMenuItem,
            this.垂直翻轉ToolStripMenuItem,
            this.旋轉180度ToolStripMenuItem});
            this.翻轉ToolStripMenuItem.Name = "翻轉ToolStripMenuItem";
            this.翻轉ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.翻轉ToolStripMenuItem.Text = "翻轉";
            // 
            // 水平翻轉ToolStripMenuItem
            // 
            this.水平翻轉ToolStripMenuItem.Name = "水平翻轉ToolStripMenuItem";
            this.水平翻轉ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.水平翻轉ToolStripMenuItem.Text = "水平翻轉";
            this.水平翻轉ToolStripMenuItem.Click += new System.EventHandler(this.水平翻轉ToolStripMenuItem_Click);
            // 
            // 垂直翻轉ToolStripMenuItem
            // 
            this.垂直翻轉ToolStripMenuItem.Name = "垂直翻轉ToolStripMenuItem";
            this.垂直翻轉ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.垂直翻轉ToolStripMenuItem.Text = "垂直翻轉";
            this.垂直翻轉ToolStripMenuItem.Click += new System.EventHandler(this.垂直翻轉ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 314);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(533, 314);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 128;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // 明暗度ToolStripMenuItem
            // 
            this.明暗度ToolStripMenuItem.Name = "明暗度ToolStripMenuItem";
            this.明暗度ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.明暗度ToolStripMenuItem.Text = "明暗度";
            this.明暗度ToolStripMenuItem.Click += new System.EventHandler(this.明暗度ToolStripMenuItem_Click);
            // 
            // 旋轉180度ToolStripMenuItem
            // 
            this.旋轉180度ToolStripMenuItem.Name = "旋轉180度ToolStripMenuItem";
            this.旋轉180度ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.旋轉180度ToolStripMenuItem.Text = "旋轉180度";
            this.旋轉180度ToolStripMenuItem.Click += new System.EventHandler(this.旋轉180度ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 338);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.ToolStripMenuItem 模糊ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 風格化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 浮雕ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 馬賽克ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 磁磚ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 翻轉ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 水平翻轉ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 垂直翻轉ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 色調分離ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 曝光過度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 彩色雜點ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 油畫ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 二值化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 掃描線ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 噴槍ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 萬花筒ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 亮度對比ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編輯ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 複製ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 貼上ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 明暗度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 旋轉180度ToolStripMenuItem;
    }
}

