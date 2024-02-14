namespace _3Dmigoto_Sword_GUI
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genshinImpactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.honkaiStarRailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.honkaiImpact3rdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zenlessZoneZeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.narakaBladepointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(12, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reverse Single";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(158, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Reverse Merged";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.discordToolStripMenuItem,
            this.githubToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(295, 25);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genshinImpactToolStripMenuItem,
            this.honkaiStarRailToolStripMenuItem,
            this.honkaiImpact3rdToolStripMenuItem,
            this.zenlessZoneZeroToolStripMenuItem,
            this.narakaBladepointToolStripMenuItem});
            this.gameToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(54, 21);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // genshinImpactToolStripMenuItem
            // 
            this.genshinImpactToolStripMenuItem.Name = "genshinImpactToolStripMenuItem";
            this.genshinImpactToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.genshinImpactToolStripMenuItem.Text = "Genshin Impact";
            this.genshinImpactToolStripMenuItem.Click += new System.EventHandler(this.genshinImpactToolStripMenuItem_Click);
            // 
            // honkaiStarRailToolStripMenuItem
            // 
            this.honkaiStarRailToolStripMenuItem.Name = "honkaiStarRailToolStripMenuItem";
            this.honkaiStarRailToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.honkaiStarRailToolStripMenuItem.Text = "Honkai StarRail";
            this.honkaiStarRailToolStripMenuItem.Click += new System.EventHandler(this.honkaiStarRailToolStripMenuItem_Click);
            // 
            // honkaiImpact3rdToolStripMenuItem
            // 
            this.honkaiImpact3rdToolStripMenuItem.Name = "honkaiImpact3rdToolStripMenuItem";
            this.honkaiImpact3rdToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.honkaiImpact3rdToolStripMenuItem.Text = "Honkai Impact 3rd";
            this.honkaiImpact3rdToolStripMenuItem.Click += new System.EventHandler(this.honkaiImpact3rdToolStripMenuItem_Click);
            // 
            // zenlessZoneZeroToolStripMenuItem
            // 
            this.zenlessZoneZeroToolStripMenuItem.Name = "zenlessZoneZeroToolStripMenuItem";
            this.zenlessZoneZeroToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.zenlessZoneZeroToolStripMenuItem.Text = "Zenless Zone Zero";
            this.zenlessZoneZeroToolStripMenuItem.Click += new System.EventHandler(this.zenlessZoneZeroToolStripMenuItem_Click);
            // 
            // narakaBladepointToolStripMenuItem
            // 
            this.narakaBladepointToolStripMenuItem.Name = "narakaBladepointToolStripMenuItem";
            this.narakaBladepointToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.narakaBladepointToolStripMenuItem.Text = "Naraka Bladepoint";
            this.narakaBladepointToolStripMenuItem.Click += new System.EventHandler(this.narakaBladepointToolStripMenuItem_Click);
            // 
            // discordToolStripMenuItem
            // 
            this.discordToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.discordToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.discordToolStripMenuItem.Name = "discordToolStripMenuItem";
            this.discordToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.discordToolStripMenuItem.Text = "Discord";
            this.discordToolStripMenuItem.Click += new System.EventHandler(this.discordToolStripMenuItem_Click);
            // 
            // githubToolStripMenuItem
            // 
            this.githubToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.githubToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            this.githubToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.githubToolStripMenuItem.Text = "Github";
            this.githubToolStripMenuItem.Click += new System.EventHandler(this.githubToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(295, 90);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3Dmigoto-Sword V3.0.0.1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genshinImpactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem honkaiStarRailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem honkaiImpact3rdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zenlessZoneZeroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem narakaBladepointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

