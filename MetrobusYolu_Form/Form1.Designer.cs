namespace MetrobusYolu_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.başlatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kırmızıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turuncuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pembeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kahverengiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siyahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.durdurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webSiteleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youtubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigasyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnBaslat = new System.Windows.Forms.Button();
            this.BtnDurdur = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 650);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(31, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zaman";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayarlarToolStripMenuItem,
            this.renklerToolStripMenuItem,
            this.webSiteleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1385, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.başlatToolStripMenuItem,
            this.durdurToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(70, 26);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // başlatToolStripMenuItem
            // 
            this.başlatToolStripMenuItem.Name = "başlatToolStripMenuItem";
            this.başlatToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.başlatToolStripMenuItem.Text = "Başlat";
            this.başlatToolStripMenuItem.Click += new System.EventHandler(this.başlatToolStripMenuItem_Click);
            // 
            // renklerToolStripMenuItem
            // 
            this.renklerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sarıToolStripMenuItem,
            this.kırmızıToolStripMenuItem,
            this.maviToolStripMenuItem,
            this.turuncuToolStripMenuItem,
            this.pembeToolStripMenuItem,
            this.kahverengiToolStripMenuItem,
            this.siyahToolStripMenuItem});
            this.renklerToolStripMenuItem.Name = "renklerToolStripMenuItem";
            this.renklerToolStripMenuItem.Size = new System.Drawing.Size(72, 26);
            this.renklerToolStripMenuItem.Text = "Renkler";
            this.renklerToolStripMenuItem.Click += new System.EventHandler(this.renklerToolStripMenuItem_Click);
            // 
            // sarıToolStripMenuItem
            // 
            this.sarıToolStripMenuItem.Name = "sarıToolStripMenuItem";
            this.sarıToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sarıToolStripMenuItem.Text = "Sarı";
            this.sarıToolStripMenuItem.Click += new System.EventHandler(this.sarıToolStripMenuItem_Click);
            // 
            // kırmızıToolStripMenuItem
            // 
            this.kırmızıToolStripMenuItem.Name = "kırmızıToolStripMenuItem";
            this.kırmızıToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kırmızıToolStripMenuItem.Text = "Kırmızı";
            this.kırmızıToolStripMenuItem.Click += new System.EventHandler(this.kırmızıToolStripMenuItem_Click);
            // 
            // maviToolStripMenuItem
            // 
            this.maviToolStripMenuItem.Name = "maviToolStripMenuItem";
            this.maviToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.maviToolStripMenuItem.Text = "Mavi";
            this.maviToolStripMenuItem.Click += new System.EventHandler(this.maviToolStripMenuItem_Click);
            // 
            // turuncuToolStripMenuItem
            // 
            this.turuncuToolStripMenuItem.Name = "turuncuToolStripMenuItem";
            this.turuncuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.turuncuToolStripMenuItem.Text = "Turuncu";
            this.turuncuToolStripMenuItem.Click += new System.EventHandler(this.turuncuToolStripMenuItem_Click);
            // 
            // pembeToolStripMenuItem
            // 
            this.pembeToolStripMenuItem.Name = "pembeToolStripMenuItem";
            this.pembeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pembeToolStripMenuItem.Text = "Pembe";
            this.pembeToolStripMenuItem.Click += new System.EventHandler(this.pembeToolStripMenuItem_Click);
            // 
            // kahverengiToolStripMenuItem
            // 
            this.kahverengiToolStripMenuItem.Name = "kahverengiToolStripMenuItem";
            this.kahverengiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kahverengiToolStripMenuItem.Text = "Kahverengi";
            this.kahverengiToolStripMenuItem.Click += new System.EventHandler(this.kahverengiToolStripMenuItem_Click);
            // 
            // siyahToolStripMenuItem
            // 
            this.siyahToolStripMenuItem.Name = "siyahToolStripMenuItem";
            this.siyahToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.siyahToolStripMenuItem.Text = "Siyah";
            this.siyahToolStripMenuItem.Click += new System.EventHandler(this.siyahToolStripMenuItem_Click);
            // 
            // durdurToolStripMenuItem
            // 
            this.durdurToolStripMenuItem.Name = "durdurToolStripMenuItem";
            this.durdurToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.durdurToolStripMenuItem.Text = "Durdur";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(64, 271);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1265, 227);
            this.webBrowser1.TabIndex = 4;
            // 
            // webSiteleriToolStripMenuItem
            // 
            this.webSiteleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.googleToolStripMenuItem,
            this.youtubeToolStripMenuItem,
            this.twitterToolStripMenuItem,
            this.navigasyonToolStripMenuItem});
            this.webSiteleriToolStripMenuItem.Name = "webSiteleriToolStripMenuItem";
            this.webSiteleriToolStripMenuItem.Size = new System.Drawing.Size(103, 26);
            this.webSiteleriToolStripMenuItem.Text = "Web Siteleri";
            // 
            // googleToolStripMenuItem
            // 
            this.googleToolStripMenuItem.Name = "googleToolStripMenuItem";
            this.googleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.googleToolStripMenuItem.Text = "Google";
            this.googleToolStripMenuItem.Click += new System.EventHandler(this.googleToolStripMenuItem_Click);
            // 
            // youtubeToolStripMenuItem
            // 
            this.youtubeToolStripMenuItem.Name = "youtubeToolStripMenuItem";
            this.youtubeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.youtubeToolStripMenuItem.Text = "Youtube";
            this.youtubeToolStripMenuItem.Click += new System.EventHandler(this.youtubeToolStripMenuItem_Click);
            // 
            // twitterToolStripMenuItem
            // 
            this.twitterToolStripMenuItem.Name = "twitterToolStripMenuItem";
            this.twitterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.twitterToolStripMenuItem.Text = "Twitter";
            this.twitterToolStripMenuItem.Click += new System.EventHandler(this.twitterToolStripMenuItem_Click);
            // 
            // navigasyonToolStripMenuItem
            // 
            this.navigasyonToolStripMenuItem.Name = "navigasyonToolStripMenuItem";
            this.navigasyonToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.navigasyonToolStripMenuItem.Text = "Navigasyon";
            this.navigasyonToolStripMenuItem.Click += new System.EventHandler(this.navigasyonToolStripMenuItem_Click);
            // 
            // BtnBaslat
            // 
            this.BtnBaslat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBaslat.Location = new System.Drawing.Point(29, 113);
            this.BtnBaslat.Name = "BtnBaslat";
            this.BtnBaslat.Size = new System.Drawing.Size(114, 45);
            this.BtnBaslat.TabIndex = 5;
            this.BtnBaslat.Text = "Başlat";
            this.BtnBaslat.UseVisualStyleBackColor = false;
            this.BtnBaslat.Click += new System.EventHandler(this.BtnBaslat_Click);
            // 
            // BtnDurdur
            // 
            this.BtnDurdur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnDurdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDurdur.Location = new System.Drawing.Point(29, 180);
            this.BtnDurdur.Name = "BtnDurdur";
            this.BtnDurdur.Size = new System.Drawing.Size(114, 50);
            this.BtnDurdur.TabIndex = 6;
            this.BtnDurdur.Text = "Durdur";
            this.BtnDurdur.UseVisualStyleBackColor = false;
            this.BtnDurdur.Click += new System.EventHandler(this.BtnDurdur_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(471, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 152);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(731, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 152);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(1023, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 152);
            this.panel3.TabIndex = 9;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(467, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 43);
            this.label3.TabIndex = 10;
            this.label3.Text = "Söğütlüçeşme";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(789, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 46);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fikirtepe";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(1099, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 43);
            this.label5.TabIndex = 12;
            this.label5.Text = "Uzunçayır";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(226, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 152);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1385, 579);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnDurdur);
            this.Controls.Add(this.BtnBaslat);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem başlatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kırmızıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turuncuToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pembeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kahverengiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siyahToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem durdurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webSiteleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem googleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem youtubeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twitterToolStripMenuItem;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripMenuItem navigasyonToolStripMenuItem;
        private System.Windows.Forms.Button BtnBaslat;
        private System.Windows.Forms.Button BtnDurdur;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

