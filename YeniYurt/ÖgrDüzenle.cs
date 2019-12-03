using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YeniYurt.Entity;
using YeniYurt.Model;

namespace YeniYurt
{
    public partial class ÖgrDüzenle : Form
    {
        private readonly Ogrenciler ogrenciler;
        public ÖgrDüzenle()
        {
            InitializeComponent();
            
        }
        int Sayac = 0;
        int sayac2 = 0;
        public ÖgrDüzenle(Ogrenciler ogrenciler)
        {
            this.ogrenciler = ogrenciler;
            InitializeComponent();

        }
        public ÖgrDüzenle(OgrenciModel a)
        {
            InitializeComponent();
            textBox1.Text = a.OgrenciAdi;
            textBox2.Text = a.OgrenciSoyadi;
            textBox3.Text = a.OgrenciTC;
            textBox4.Text = a.OgrenciOkul;
            textBox5.Text = a.OgrenciBolum;
            comboBox1.SelectedItem = a.OgrenciSınıf;
            dateTimePicker1.Value = a.OgrenciKayitTarihi.GetValueOrDefault();
            textBox6.Text = a.KalacagiOda.ToString();
            maskedTextBox1.Text = a.OgrenciTelefon;
            textBox8.Text = a.VeliAdi;
            maskedTextBox2.Text = a.VeliTelefon;
            textBox10.Text = a.OgrenciAdresi;

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();//Öğrenci eklemeyi iptal eder.
            this.Hide();
            frm2.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            //OdaNo frm2 = new OdaNo();//Oda bilgilerini formunu açar
            //this.Hide();
            //frm2.Show();
        }

        private void Button2_Click(object sender, EventArgs e)// Öğrenci düzenle
        {
            try
            {
                OgrenciModel yeniOgrenci = new OgrenciModel();

                yeniOgrenci.OgrenciAdi = textBox1.Text;
                yeniOgrenci.OgrenciSoyadi = textBox2.Text;
                yeniOgrenci.OgrenciTC = textBox3.Text;
                yeniOgrenci.OgrenciID = Helper.HelperOgrenci.BulOgrenciID(yeniOgrenci.OgrenciTC);
                yeniOgrenci.OgrenciOkul = textBox4.Text;
                yeniOgrenci.OgrenciBolum = textBox5.Text;
                yeniOgrenci.OgrenciSınıf = comboBox1.SelectedItem.ToString();
                yeniOgrenci.OgrenciKayitTarihi = dateTimePicker1.Value;
                yeniOgrenci.KalacagiOda = Convert.ToInt32(textBox6.Text);
                yeniOgrenci.OgrenciTelefon = maskedTextBox1.Text;
                yeniOgrenci.VeliAdi = textBox8.Text;
                yeniOgrenci.VeliTelefon = maskedTextBox2.Text;
                yeniOgrenci.OgrenciAdresi = textBox10.Text;

                bool eklendiMi = Helper.HelperOgrenci.UpdateOgrenci(yeniOgrenci);
                if (eklendiMi)
                {
                    MessageBox.Show("Öğrenci Kaydı Güncellendi.","Kayıt Ekranı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Öğrenci kaydı güncellenemedi.Lütfen tüm bilgileri eksiksiz girdiğinizden emin olunuz.");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Öğrenci kaydı güncellenemedi.Lütfen tüm bilgileri eksiksiz girdiğinizden emin olunuz.","Kayıt Ekranı",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
            

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();//Anasayfayı  açar
            this.Hide();
            frm2.Show();
        }
        
        private void ÖgrDüzenle_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;

            textBox1.Text = ogrenciler.OgrenciAdi;
            textBox2.Text = ogrenciler.OgrenciSoyadi;
            textBox3.Text = ogrenciler.OgrenciTC;
            textBox4.Text = ogrenciler.OgrenciOkul;
            textBox5.Text = ogrenciler.OgrenciBolum;
            comboBox1.SelectedItem = ogrenciler.OgrenciSınıf;
            textBox6.Text = ogrenciler.KalacagiOda.ToString();
            maskedTextBox1.Text = ogrenciler.OgrenciTelefon;
            textBox8.Text = ogrenciler.VeliAdi;
            maskedTextBox2.Text = ogrenciler.VeliTelefon;
            textBox10.Text = ogrenciler.OgrenciAdresi;
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {
            Sayac = 1; sayac2 = 1;
            for (int j = 1; j < 6; j++)
            {

                for (int i = 0; i < 10; i++)
                {


                    Button btn = new Button();
                    btn.Size = new Size(38, 38);
                    btn.BackColor = Color.Chocolate;
                    btn.Location = new Point(i * 30 + 20, j * 30 + 20);
                    btn.Name = "btn_" + Sayac.ToString();
                    btn.Text = sayac2.ToString();
                    Sayac++;
                    sayac2++;
                    if (j == 3)
                    {
                        break;
                    }
                    this.panel3.Controls.Add(btn);
                    btn.Click += Button5_Click;
                }
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.BackColor == Color.Chocolate)
            {
                textBox6.Text = b.Text;
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }
    }
}
