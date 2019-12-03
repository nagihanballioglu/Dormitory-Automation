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

namespace YeniYurt
{
    public partial class OdaNo : Form
    {

        //Boolean a = true;
        YurtDbEntities vt = new YurtDbEntities();
        //public int odaAdi;
        //List<string> veriler = new List<string>();
        public OdaNo()
        {
            InitializeComponent();
        }

        private void Kat1_Click(object sender, EventArgs e)
        {

        }

        private void Kat2_Click(object sender, EventArgs e)
        {

        }

        private void Kat3_Click(object sender, EventArgs e)
        {

        }

        private void Kat4_Click(object sender, EventArgs e)
        {

        }

        private void Kat5_Click(object sender, EventArgs e)
        {

        }

        private void Kat1_Click_1(object sender, EventArgs e)
        {
            pnl.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void Kat2_Click_1(object sender, EventArgs e)
        {
            kat1.BackColor = Color.IndianRed;
            kat2.BackColor = Color.Tan;
            kat3.BackColor = Color.IndianRed;
            kat4.BackColor = Color.IndianRed;
            kat5.BackColor = Color.IndianRed;
            pnl.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void Kat3_Click_1(object sender, EventArgs e)
        {
            kat1.BackColor = Color.IndianRed;
            kat2.BackColor = Color.IndianRed;
            kat3.BackColor = Color.Tan;
            kat4.BackColor = Color.IndianRed;
            kat5.BackColor = Color.IndianRed;
            pnl.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void Kat4_Click_1(object sender, EventArgs e)
        {
            kat1.BackColor = Color.IndianRed;
            kat2.BackColor = Color.IndianRed;
            kat3.BackColor = Color.IndianRed;
            kat4.BackColor = Color.Tan;
            kat5.BackColor = Color.IndianRed;
            pnl.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;
        }

        private void Kat5_Click_1(object sender, EventArgs e)
        {
            kat1.BackColor = Color.IndianRed;
            kat2.BackColor = Color.IndianRed;
            kat3.BackColor = Color.IndianRed;
            kat4.BackColor = Color.IndianRed;
            kat5.BackColor = Color.Tan;

            pnl.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;
        }

        private void OdaNo_Load(object sender, EventArgs e)
        {
            ///* odaların doluluk durumuna gore butonların rengi belirleniyor */

            //foreach (FlowLayoutPanel item in this.Controls.OfType<FlowLayoutPanel>())
            //{
            //    if (item == flowLayoutPanel1)
            //    {
            //        continue;
            //    }
            //    foreach (Button i in item.Controls)
            //    {
            //        int oda = Int32.Parse(i.Text);
            //        var doluluk = vt.Odalar.Where(s => s.OdaNo == oda).ToList();


            //        if (doluluk.Count <= 1)
            //        {
            //            i.BackColor = Color.Chocolate;
            //        }
            //        else if (doluluk.Count == 2)
            //        {
            //            i.BackColor = Color.Yellow;
            //        }
            //        else if (doluluk.Count == 3)
            //        {
            //            i.BackColor = Color.Red;
            //        }

            //    }

            //}

        }

        //public void deneme(object x, EventArgs e)
        //{

        //    /*Tıklanan butonun bilgisini donduruyor */
        //    Button bu = x as Button;

        //    int odaKodu = Int32.Parse(bu.Text);



        //    if (bu.BackColor == Color.Red)
        //    {
        //        MessageBox.Show("Bu oda tamamen doludur !");


        //    }
        //    else
        //    {
        //        odaAdi = Int32.Parse(bu.Text);

        //    }

        //    /* Odada kalan ogrencilerin goruntulenmesi icin aşağıda sorgu yapılıyor */

        //    var ogrenciler = vt.Ogrenciler.Where(s => s.KalacagiOda == odaKodu).ToList();
            
        //    foreach (var item in ogrenciler)
        //    {
        //        veriler.Add(item.OgrenciAdi + " " + item.OgrenciSoyadi);
               

        //    }

        //}

        private void OdaNo_MouseEnter(object sender, EventArgs e)
        {
        //    /* Fare ekrana girdiğinde ekrandaki tüm kontrolleri tarıyor(buton,label vs) */
        //    foreach (FlowLayoutPanel item in this.Controls.OfType<FlowLayoutPanel>())
        //    {
        //        if (a)
        //        {
        //            foreach (Button i in item.Controls)
        //            {
        //                i.Click += new EventHandler(deneme);


        //            }
        //            a = false;
        //            break;
        //        }


        //    }

        }
    }
}
