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
    public partial class Form2 : Form
    {

       

        public Form2()
        {
            InitializeComponent();
            OgrenciListele();
            IzınListele();
            OdemeListele();
            label2.Text = Helper.HelperSifre.Admin;
           
        }
        private void Button2_Click(object sender, EventArgs e)//ÖğrenciEkle formunu açar
        {
            ÖgrEkle frm2 = new ÖgrEkle();//ÖgrEkle formunu açar
            this.Hide();
            frm2.Show();
            dataGridView1.Rows.Clear();
            OgrenciListele();
        }

        private void Button3_Click(object sender, EventArgs e)//Ögrenci düzenle formunu açar
        {
            var student = new Ogrenciler();
            {
                student.OgrenciID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                student.OgrenciAdi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                student.OgrenciSoyadi = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                student.OgrenciTC = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                student.OgrenciOkul = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                student.OgrenciBolum = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                student.OgrenciSınıf = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                //student.OgrenciKayitTarihi = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                student.KalacagiOda = Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value);
                student.OgrenciTelefon = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                student.VeliAdi = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                student.VeliTelefon = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                student.OgrenciAdresi = dataGridView1.CurrentRow.Cells[12].Value.ToString();

            }
            //OgrenciModel a = (OgrenciModel)dataGridView1.SelectedRows[0].DataBoundItem;
            ÖgrDüzenle frm2 = new ÖgrDüzenle(student);//ÖgrDüzenle formunu dolu biçimde açar
            //this.Hide();
            frm2.Show();
            dataGridView1.Rows.Clear();
            OgrenciListele();
        }


        private void Button69_Click(object sender, EventArgs e)//İzin Silme
        {
            try
            {
                DialogResult result = MessageBox.Show("İzin silmek istediğinize emin misiniz?", "İzin Silme", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int izinID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());

                    bool deleted = Helper.Helperİzin.DeleteIzın(izinID);


                    if (deleted)
                    {
                        MessageBox.Show("İzin Silindi", "İzin Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView2.Rows.Clear();
                        IzınListele();
                    }
                    else
                    {
                        MessageBox.Show("İzin Silinemedi");

                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("İzin Silinemedi", "hataa", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }


        public void OgrenciListele()//öğrenci listesini gridviewa model cinsinden ekler.
        {
            List<OgrenciModel> ogrenciListe = Helper.HelperOgrenci.OgrenciListesiModel();

            foreach (OgrenciModel item in ogrenciListe)
            {
                dataGridView1.Rows.Add(item.OgrenciID, item.OgrenciAdi, item.OgrenciSoyadi, item.OgrenciTC, item.OgrenciOkul,
                    item.OgrenciBolum, item.OgrenciSınıf, item.OgrenciKayitTarihi, item.KalacagiOda, item.OgrenciTelefon,
                    item.VeliAdi, item.VeliTelefon, item.OgrenciAdresi);

            }
        }

        public void GiderListele()
        {
            List<GiderModel> giderListe = Helper.HelperGider.GiderListesiModel();

            foreach (GiderModel item in giderListe)
            {
                dataGridView4.Rows.Add(item.gıderID, item.giderTuru, item.giderTutar);
            }
        }
        public void IzınListele()//İzin listesini gridviewa model cinsinden ekler.
        {
            List<IzınModel> izinList = Helper.Helperİzin.IzınlerListesiModel();

            foreach (IzınModel item in izinList)
            {
                dataGridView2.Rows.Add(item.IzınID, item.OgrenciTC, item.om.OgrenciAdi, item.om.OgrenciSoyadi, item.gidisTarihi, item.donusTarihi, item.gidecegiKisiTel, item.gşdecegiAdres);

            }
        }

        public void OdemeListele()
        {
            List<OdemeModel> odemeList = Helper.HelperOdeme.OdemelerListesiModel();
            foreach (OdemeModel item in odemeList)
            {
                dataGridView3.Rows.Add(item.OdemeID, item.OgrenciTC, item.om.OgrenciAdi, item.om.OgrenciSoyadi, item.KalanTaksit, item.odenenTutar);
            }
        }

        public void ListStudent()
        {
            List<OgrenciModel> student = Helper.HelperOgrenci.StudentModelDon(Helper.HelperOgrenci.GetOgrenciler(textBox1.Text));
            if (student.Count > 0)
            {
                dataGridView1.Rows.Clear();
                for (int i = 0; i < student.Count; i++)
                {
                    i = dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = student[i].OgrenciID;
                    dataGridView1.Rows[i].Cells[1].Value = student[i].OgrenciAdi;
                    dataGridView1.Rows[i].Cells[2].Value = student[i].OgrenciSoyadi;
                    dataGridView1.Rows[i].Cells[3].Value = student[i].OgrenciTC;
                    dataGridView1.Rows[i].Cells[4].Value = student[i].OgrenciOkul;
                    dataGridView1.Rows[i].Cells[5].Value = student[i].OgrenciBolum;
                    dataGridView1.Rows[i].Cells[6].Value = student[i].OgrenciSınıf;
                    dataGridView1.Rows[i].Cells[7].Value = student[i].OgrenciKayitTarihi;
                    dataGridView1.Rows[i].Cells[8].Value = student[i].KalacagiOda;
                    dataGridView1.Rows[i].Cells[9].Value = student[i].OgrenciTelefon;
                    dataGridView1.Rows[i].Cells[10].Value = student[i].VeliAdi;
                    dataGridView1.Rows[i].Cells[11].Value = student[i].VeliTelefon;
                    dataGridView1.Rows[i].Cells[12].Value = student[i].OgrenciAdresi;
                }
            }
        }// textbox arama butonu --sadece adı yazılanı listeler


        public void OdemeAra()
        {
            List<OdemeModel> studentTC = Helper.HelperOdeme.OdemeModelDon(Helper.HelperOdeme.GetOdemeler(textBox8.Text));
            if (studentTC.Count > 0)
            {
                dataGridView3.Rows.Clear();
                for (int i = 0; i < studentTC.Count; i++)
                {
                    i = dataGridView3.Rows.Add();
                    dataGridView3.Rows[i].Cells[0].Value = studentTC[i].OdemeID;
                    dataGridView3.Rows[i].Cells[1].Value = studentTC[i].OgrenciTC;
                    dataGridView3.Rows[i].Cells[2].Value = studentTC[i].om.OgrenciAdi;
                    dataGridView3.Rows[i].Cells[3].Value = studentTC[i].om.OgrenciSoyadi;
                    dataGridView3.Rows[i].Cells[4].Value = studentTC[i].KalanTaksit;
                    dataGridView3.Rows[i].Cells[5].Value = studentTC[i].odenenTutar;
                }
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            ListStudent();
        }

        private void Button4_Click(object sender, EventArgs e) //Öğrenci Silme
        {
            try
            {
                DialogResult result = MessageBox.Show("Öğrenci kaydını silmek istediğinize emin misiniz?", "Kayıt Silme", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int orderID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                    bool deleted = Helper.HelperOgrenci.DeleteOgrenci(orderID);


                    if (deleted)
                    {
                        MessageBox.Show("Öğrenci Kaydı Silindi", "Ekran", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.Rows.Clear();
                        OgrenciListele();
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci Kaydı Silinemedi");

                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Öğrenci Kaydı Silinemedi", "Kayıt Ekranı", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }


        }

        private void Button70_Click(object sender, EventArgs e)//İzin Ekleme
        {
            try
            {
                if (textBox2.Text=="")
                {
                    MessageBox.Show("TC Kimlik numarası boş geçilemez");

                    return;
                }
                    IzınModel izinal = new IzınModel();

                    izinal.OgrenciTC = textBox2.Text;
                    izinal.gidisTarihi = dateTimePicker1.Value;
                    izinal.donusTarihi = dateTimePicker2.Value;
                    izinal.gidecegiKisiTel = maskedTextBox1.Text;
                    izinal.gşdecegiAdres = textBox3.Text;

                bool eklendiMi = Helper.Helperİzin.AddIzın(izinal);
               
                    if (eklendiMi)
                    {
                        MessageBox.Show("İzin sisteme kaydedildi.");
                        dataGridView2.Rows.Clear();
                        IzınListele();
                    }
            }
            catch (Exception)
            {
                
                MessageBox.Show("Lütfen TC kimlik numarasını doğru girdiğinizden emin olunuz.");
            }
            

        }

        private void Button75_Click(object sender, EventArgs e)//Gider Ekle
        {
            try
            {
                GiderModel giderekle = new GiderModel();
                giderekle.giderTuru = comboBox1.SelectedItem.ToString();
                giderekle.giderTutar = Convert.ToInt32(textBox7.Text);
                bool eklendiMi = Helper.HelperGider.AddGider(giderekle);
                if (eklendiMi)
                {
                    MessageBox.Show("Gider eklenmiştir.","Gider Ekle",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    dataGridView4.Rows.Clear();
                    GiderListele();
                }
                else
                {
                    MessageBox.Show("Gider eklenemedi.Bilgilerinizi kontrol edip tekrar deneyiniz.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen gider türünü ve tutarını eksiksiz giriniz.","Hata",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
           
        }

        private void Button76_Click(object sender, EventArgs e)//Gider Silme
        {
            try
            {
                DialogResult result = MessageBox.Show("Gider kaydını silmek istediğinize emin misiniz?", "Kayıt Silme", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int giderID = Convert.ToInt32(dataGridView4.CurrentRow.Cells[0].Value.ToString());

                    bool deleted = Helper.HelperGider.DeleteGider(giderID);


                    if (deleted)
                    {
                        MessageBox.Show("Gider Kaydı Silindi");
                        dataGridView4.Rows.Clear();
                        GiderListele();
                    }
                    else
                    {
                        MessageBox.Show("Gider Kaydı Silinemedi");

                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Gider Kaydı Silinemedi", "Kayıt Silme", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void Button77_Click(object sender, EventArgs e)
        {
            GiderListele();
        }

        private void Button78_Click(object sender, EventArgs e)
        {
            
            try
            {
                Yonetici sifredegistir = new Yonetici();
                int userID = Helper.HelperSifre.AdminID;

                var u = Helper.HelperKullanici.GetKullanici(userID);
                if (u.YoneticiSifre == textBox17.Text)
                {
                    label29.Visible = false;

                    if ((textBox16.Text != "" && textBox15.Text != "") && (textBox16.Text == textBox15.Text))
                    {
                        u.YoneticiSifre = textBox15.Text;
                        Helper.HelperKullanici.UpdateKullanici(sifredegistir);
                        label29.ForeColor = Color.Green;
                        label29.Visible = true;
                        label29.Text = "Şifre değiştirildi.";
                    }
                }
                else
                {
                    label29.ForeColor = Color.Red;
                    label29.Visible = true;
                    label29.Text = "Girdiğiniz şifre yanlış ya da eksik.";
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Yeni şifre tekrarıyla aynı olmalıdır.","Hata",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
            
        }

        private void Button71_Click(object sender, EventArgs e)//Ödeme Alma
        {
            try
            {
                OdemeModel odemeal = new OdemeModel();
                odemeal.OgrenciTC = textBox4.Text;
                //odemeal.KalanTaksit = Convert.ToInt32(textBox5.Text);
                odemeal.odenenTutar = Convert.ToInt32(textBox6.Text);
                odemeal.KalanTaksit = 9000;
                odemeal.KalanTaksit = odemeal.KalanTaksit - odemeal.odenenTutar;
               
                bool eklendiMi = Helper.HelperOdeme.AddOdeme(odemeal);
                
                if (eklendiMi)
                {
                    MessageBox.Show("Ödeme başarıyla gerçekleştirildi.","Ödeme Al",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    dataGridView3.Rows.Clear();
                    OdemeListele();
                }
                else
                {
                    MessageBox.Show("Ödeme kaydedilemedi.Lütfen tekrar deneyiniz.");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ödeme kaydedilemedi.Lütfen tekrar deneyiniz.","Hata",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }


        }

        private void Button73_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Ödemeyi silmek istediğinize emin misiniz?", "Ödeme Silme", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int odemeID = Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value.ToString());

                    bool deleted = Helper.HelperOdeme.DeleteOdeme(odemeID);


                    if (deleted)
                    {
                        MessageBox.Show("Ödeme Silindi");
                        dataGridView3.Rows.Clear();
                        OdemeListele();
                    }
                    else
                    {
                        MessageBox.Show("Ödeme Silinemedi");

                    }
                }
            }
            catch (Exception)
            {


                MessageBox.Show("Ödeme Silinemedi");
            }

        }//Ödeme Silme

       

        private void Button6_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            maskedTextBox1.Clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox15.PasswordChar = '*';
           textBox16.PasswordChar = '*';
        }

        private void Button6_Click_1(object sender, EventArgs e)
        {
            OdemeAra();
        }
    }
    }

