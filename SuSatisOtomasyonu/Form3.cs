using SuSatisOtomasyonu.DAL;
using SuSatisOtomasyonu.Entity;
using SuSatisOtomasyonu.Model;
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
    public partial class Form3 : Form
    {
        int ID = 0;
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(int musID)
        {
            InitializeComponent();
            ID = musID;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var ff = Helper.GetByID(ID);
            textBox1.Text = ff.adi;
            textBox2.Text = ff.soyadi;
            textBox3.Text = ff.adres;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var ff = Helper.GetByID(ID);
            siparisler s = new siparisler()
            {
                musteriID = ff.musteriID,
                durum = "Hazırlanıyor...",
                tutar = int.Parse(textBox4.Text),
                tarih = DateTime.Now.Date
            };
            Helper.AddSiparis(s);
        }
    }
}
