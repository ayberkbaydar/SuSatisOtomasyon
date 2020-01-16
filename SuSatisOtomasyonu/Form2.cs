using SuSatisOtomasyonu.DAL;
using SuSatisOtomasyonu.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuSatisOtomasyonu
{
    public partial class Form2 : Form
    {
        int guncelle = 0;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(int guncelleID)
        {
            InitializeComponent();
            guncelle = guncelleID;
            button1.Visible = false;
        }
        public Form2(bool a)
        {
            InitializeComponent();
            if (a)
            {
                button2.Visible = false;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            musteriler m = new musteriler
            {
                adi = adTxt.Text,
                soyadi = soyadTxt.Text,
                telefon = TelefonTxt.Text,
                adres = adresTxt.Text
            };
            var a = Helper.AddMusteri(m);
            if (a)
            {
                MessageBox.Show("Kayıt Başarılı");
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = adTxt.Text;
            string s = soyadTxt.Text;
            string t = TelefonTxt.Text;
            string d = adresTxt.Text;
            var deger=Helper.UpdateMusteri(guncelle, a, s, t, d);
            if (deger)
            {
                MessageBox.Show("Güncelleme Başarılı");
            }
            else
            {
                MessageBox.Show("Güncelleme Başarısız");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
