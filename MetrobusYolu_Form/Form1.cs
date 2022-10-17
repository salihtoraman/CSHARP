using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MetrobusYolu_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void turuncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void pembeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }

        private void kahverengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Brown;
        }

        private void siyahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void googleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.google.com");
        }

        private void youtubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.youtube.com");
        }

        private void twitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.twitter.com");
        }

        private void navigasyonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com.tr/maps/");
        }
        int sayac = 0;
        private void başlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label2.Text = sayac.ToString();
        }

        private void BtnBaslat_Click(object sender, EventArgs e)
        {
            timer2.Start();
            
        }

        private void BtnDurdur_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        int sure = 0;
        SoundPlayer ses = new SoundPlayer();
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Text = sure.ToString();
            sure++;
            if (sure >= 0 && sure <= 40)
            {
                pictureBox1.Left += 4;
            }
            if (sure >= 40 && sure <= 60)
            {
                if (sure == 50)
                {
                    ses.SoundLocation = "sogutlucesme.wav";
                    ses.Play();
                }
                Random r = new Random();
                label3.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            }
            if (sure>=60 && sure <=120)
            {
                label3.BackColor = Color.DarkGray;
                pictureBox1.Left += 4;
            }
            if (sure >= 120 && sure <= 140)
            {
                if (sure == 130)
                {
                    ses.SoundLocation = "fikirtepe.wav";
                    ses.Play();
                }
                Random r = new Random();
                label4.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            }
            if (sure > 140 && sure <= 200)
            {
                label4.BackColor = Color.DarkGray;
                pictureBox1.Left += 4;
            }
            if (sure >= 200 && sure <= 220)
            {
                if (sure == 210)
                {
                    ses.SoundLocation = "uzuncayir.wav";
                    ses.Play();
                }
                Random r = new Random();
                label5.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            }
            if (sure > 220 && sure <= 280)
            {
                label5.BackColor = Color.DarkGray;
                pictureBox1.Left += 4;
            }
            if (sure == 271)
            {
                label5.BackColor = Color.DarkGray;
                timer2.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void renklerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
