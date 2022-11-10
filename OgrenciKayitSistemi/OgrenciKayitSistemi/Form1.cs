using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OgrenciKayitSistemi
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Ogrenciler;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }
        private void OgrenciEkle()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Ogrenciler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label7.Visible = false;
            label8.Visible = false;
            string TC = Convert.ToString(masked_TC.Text);
            baglanti.Open();
            SqlCommand komut = new SqlCommand($"SELECT * FROM Ogrenciler");
            komut.Connection = baglanti;
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();
            SqlDataAdapter daa = new SqlDataAdapter($"SELECT * FROM Ogrenciler", baglanti);
            DataTable dtt = new DataTable();
            daa.Fill(dtt);
            dataGridView1.DataSource = dtt;
            baglanti.Close();
            dataGridView1.Columns[5].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tcm = Convert.ToString(masked_TC.Text);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlCommand komut1 = new SqlCommand($"select *from Ogrenciler WHERE TC = '{tcm}'", baglanti);
            SqlDataReader reader = komut1.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Bu TC'ye ait bir öğrenci var");
            }
            else
            {
                if (masked_TC.Text.Length < 11)
                {
                    label7.Visible = true;
                }
                else
                {
                    label7.Visible = false;
                }
                if (masked_Telefon.Text.Length < 11)
                {
                    label8.Visible = true;
                }
                else
                {
                    label8.Visible = false;
                }
                baglanti.Close();
                SqlCommand komut = new SqlCommand($"INSERT INTO Ogrenciler (Isim,Soyisim,Telefon,TC,Resim) \r VALUES ('{txt_Isim.Text}' ,'{txt_Soyisim.Text}' , '{masked_Telefon.Text}' , '{masked_TC.Text}' , '{textBox1.Text}')");
                komut.Connection = baglanti;
                baglanti.Open();
                int eklenti2 = komut.ExecuteNonQuery();
                baglanti.Close();
                if (eklenti2 > 0)
                {
                    MessageBox.Show("Müşteri eklendi");
                    OgrenciEkle();
                    txt_Isim.Clear();
                    txt_Soyisim.Clear();
                    masked_Telefon.Clear();
                    masked_TC.Clear();
                    label7.Visible = false;
                    label8.Visible = false;
                    pictureBox1.Image = null;
                }
                else
                {
                    MessageBox.Show("Öğrenci Eklenemedi");
                    baglanti.Close();
                }
                Guncelleme();
                eklenti2 = 0;
                baglanti.Close();
            }
            baglanti.Close();
        }


        private void masked_TC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txt_Isim_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txt_Soyisim_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void Guncelleme()
        {
            SqlDataAdapter daa = new SqlDataAdapter("SELECT * FROM Ogrenciler", baglanti);
            DataTable dtt = new DataTable();
            daa.Fill(dtt);
            dataGridView1.DataSource = dtt;
            baglanti.Close();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            //string Isim = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            //string Soyisim = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            //string Telefon = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            //string TC = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            //string Resim = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);

            baglanti.Open();
            SqlCommand komut = new SqlCommand($"UPDATE Ogrenciler SET Isim = '{txt_Isim.Text}' , Soyisim = '{txt_Soyisim.Text}' , Telefon = '{masked_Telefon.Text}' , TC = '{masked_TC.Text}' , Resim = '{textBox1.Text}' WHERE Id = {Id}");

            komut.Connection = baglanti;
            int eklenti2 = komut.ExecuteNonQuery();
            baglanti.Close();

            if (eklenti2 > 0)
            {
                Guncelleme();
                MessageBox.Show("Öğrenci Bilgisi Güncellendi");
            }
            else
            {
                MessageBox.Show("Öğrenci Bilgisi Güncellenmedi");
                baglanti.Close();
            }
            Guncelleme();
            eklenti2 = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            baglanti.Open();
            SqlCommand komut = new SqlCommand($"DELETE Ogrenciler WHERE Id = '{Id}'", baglanti);
            komut.Connection = baglanti;
            int eklenti2 = komut.ExecuteNonQuery();
            baglanti.Close();

            if (eklenti2 > 0)
            {
                MessageBox.Show("Öğrenci Silindi");
                Guncelleme();
            }
            else
            {
                MessageBox.Show("Öğrenci Silinmedi");
                baglanti.Close();
            }
            eklenti2 = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası ||.jpg;.nef;.png;.jpeg ||  Tüm Dosyalar |.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            textBox1.Text = dosyayolu;
            pictureBox1.ImageLocation = dosyayolu;
        }

        private void txt_Isim_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            }
            catch
            {
                MessageBox.Show("Tıkladığın yerin ID'si YOK BİLADEEEERRRRRR");
            }
            txt_Isim.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Isim"].Value);
            txt_Soyisim.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Soyisim"].Value);
            masked_TC.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["TC"].Value);
            masked_Telefon.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Telefon"].Value);
            pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells["Resim"].Value.ToString();


        }

        private void masked_Telefon_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_Isim_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }
    }
}

