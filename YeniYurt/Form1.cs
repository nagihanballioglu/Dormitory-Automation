using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YeniYurt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    var result = Helper.HelperKullanici.GetKullanici(textBox1.Text, textBox2.Text);
                    Helper.HelperSifre.Admin = result.YoneticiAdi;
                    Helper.HelperSifre.AdminID = result.YoneticiID;
                    if (result != null)
                    {
                        Form2 f = new Form2();
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        label2.Text = "Giriş Başarısız...";
                        label2.ForeColor = Color.Red;
                    }
                    label2.Visible = true;
                }
                else
                {
                    label2.Text = "Boş alanları doldurun!";
                    label2.Visible = true;
                    label2.ForeColor = Color.Red;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Giriş Başarısız", "Giriş", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            label2.Visible = false;
        }
    }
}
