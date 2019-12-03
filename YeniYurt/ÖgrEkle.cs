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
    public partial class ÖgrEkle : Form
    {
        YurtDbEntities vt = new YurtDbEntities();
        public ÖgrEkle()
        {
            InitializeComponent();
        }
        int Sayac = 0;
        int sayac2 = 0;
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

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void ÖgrEkle_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;

        }

        private void Button2_Click_1(object sender, EventArgs e) // Öğrenci Ekle
        {
            try
            {
                OgrenciModel yeniOgrenci = new OgrenciModel();
                yeniOgrenci.OgrenciAdi = textBox1.Text;
                yeniOgrenci.OgrenciSoyadi = textBox2.Text;
                yeniOgrenci.OgrenciTC = textBox3.Text;
                yeniOgrenci.OgrenciOkul = textBox4.Text;
                yeniOgrenci.OgrenciBolum = textBox5.Text;
                yeniOgrenci.OgrenciSınıf = comboBox1.SelectedItem.ToString();
                yeniOgrenci.OgrenciKayitTarihi = dateTimePicker1.Value;
                yeniOgrenci.KalacagiOda = Convert.ToInt32(textBox6.Text);
                yeniOgrenci.OgrenciTelefon = maskedTextBox1.Text;
                yeniOgrenci.VeliAdi = textBox8.Text;
                yeniOgrenci.VeliTelefon = maskedTextBox2.Text;
                yeniOgrenci.OgrenciAdresi = textBox10.Text;

                bool eklendiMi = Helper.HelperOgrenci.AddOgrenci(yeniOgrenci);
                if (eklendiMi)
                {
                    MessageBox.Show("Öğrenci Kaydı Alındı.");
                }
                else
                {
                    MessageBox.Show("Öğrenci kaydı alınamadı.Lütfen tüm bilgileri eksiksiz girdiğinizden emin olunuz.");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Öğrenci kaydı alınamadı.Lütfen yıldızlı alanları eksiksiz girdiğinizden emin olunuz.","Hata",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();//Anasayfayı  açar
            this.Hide();
            frm2.Show();
        }

        public void deneme(object x, EventArgs e)
        {

            /*Tıklanan butonun bilgisini donduruyor */
            Button btn = x as Button;

            int odaKodu = Int32.Parse(btn.Text);



            if (btn.BackColor == Color.Red)
            {
                MessageBox.Show("Bu oda tamamen doludur !");


            }
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
                    if (j==3)
                    {
                        break;
                    }

                    Ogrenciler ogroda = new Ogrenciler();
                    Odalar oodam = new Odalar();

                    //int oda = Int32.Parse(btn.Text);
                    //var doluluk = (ogroda.KalacagiOda == oda);
                    //if (oodam.OdaKatNo==1)
                    //{
                    //    btn.BackColor = Color.Yellow;
                    //}
                    //else if (oodam.OdaKatNo==2)
                    //{
                    //    btn.BackColor = Color.Red;
                    //}
                    
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
            else if (b.BackColor==Color.Green)
            {
                textBox6.Text = b.Text;
            }
            
        }

       
        private void Button6_Click_1(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }
    }
}
