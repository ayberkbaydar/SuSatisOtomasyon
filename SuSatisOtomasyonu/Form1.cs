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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.aramaGroupBox.BackColor = Color.Transparent;
            this.tabloGroupBox.BackColor = Color.Transparent;
            this.musterilerGroupBox.BackColor = Color.Transparent;
            this.siparislerGroupBox.BackColor = Color.Transparent;
        }

        private void ekleButton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(true);
            f2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGrid1Guncelle();
            dataGrid2Guncelle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGrid1Guncelle();
        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {
            int seciliSatir = dataGridView1.CurrentRow.Index;
            var musID = dataGridView1.Rows[seciliSatir].Cells[0].Value.ToString();
            Form2 ff = new Form2(int.Parse(musID));
            ff.ShowDialog();
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            DialogResult m = MessageBox.Show("Bu işlem geri alınamaz.Yine de silinsin mi?", "Sil ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (m == DialogResult.Yes)
            {
                int seciliSatir = dataGridView1.CurrentRow.Index;
                var musID = dataGridView1.Rows[seciliSatir].Cells[0].Value.ToString();
                Helper.DeleteMusteri(int.Parse(musID));
                dataGrid1Guncelle();
                MessageBox.Show("Silme işlemi gerçekleşti.");
            }
            else
            {
                MessageBox.Show("Silme işlemi başarısız.");
            }
        }

        public void dataGrid1Guncelle()
        {
            if (this.dataGridView1.DataSource != null)
            {
                this.dataGridView1.DataSource = null;
            }
            else
            {
                this.dataGridView1.Rows.Clear();
            }
            var f = Helper.MusteriGetList();
            dataGridView1.Rows.Clear();
            foreach (var item in f)
            {
                int satir = dataGridView1.Rows.Add();
                dataGridView1.Rows[satir].Cells[0].Value = item.musteriID;
                dataGridView1.Rows[satir].Cells[1].Value = item.adi;
                dataGridView1.Rows[satir].Cells[2].Value = item.soyadi;
                dataGridView1.Rows[satir].Cells[3].Value = item.telefon;
                dataGridView1.Rows[satir].Cells[4].Value = item.adres;
            }
        }

        public void dataGrid2Guncelle()
        {

            if (this.dataGridView2.DataSource != null)
            {
                this.dataGridView2.DataSource = null;
            }
            else
            {
                this.dataGridView2.Rows.Clear();
            }
            var f = Helper.SiparisGetList();
            dataGridView2.Rows.Clear();
            foreach (var item in f)
            {
                int satir = dataGridView2.Rows.Add();
                dataGridView2.Rows[satir].Cells[0].Value = item.siparisID;
                dataGridView2.Rows[satir].Cells[1].Value = item.musteriler.adi;
                dataGridView2.Rows[satir].Cells[2].Value = item.musteriler.soyadi;
                dataGridView2.Rows[satir].Cells[3].Value = item.durum;
                dataGridView2.Rows[satir].Cells[4].Value = item.musteriler.adres;
                dataGridView2.Rows[satir].Cells[5].Value = item.tutar;
            }
        }

        private void yenileButton_Click(object sender, EventArgs e)
        {
            dataGrid2Guncelle();
        }


        private void seciliyiSilButton_Click(object sender, EventArgs e)
        {
            DialogResult m = MessageBox.Show("Bu işlem geri alınamaz.Yine de silinsin mi?", "Sil ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (m == DialogResult.Yes)
            {
                int seciliSatir = dataGridView2.CurrentRow.Index;
                var musID = dataGridView2.Rows[seciliSatir].Cells[0].Value.ToString();
                Helper.DeleteSiparis(int.Parse(musID));
                dataGrid2Guncelle();
                MessageBox.Show("Silme işlemi gerçekleşti.");
            }
            else
            {
                MessageBox.Show("Silme işlemi başarısız.");
            }
        }

        private void tümünüSilButton_Click(object sender, EventArgs e)
        {
            DialogResult m = MessageBox.Show("Bu işlem geri alınamaz.Yine de silinsin mi?", "Sil ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (m == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    //int seciliSatir = dataGridView2.CurrentRow.Index;
                    var musID = dataGridView2.Rows[i].Cells[0].Value.ToString();
                    Helper.DeleteSiparis(int.Parse(musID));
                }
                dataGrid2Guncelle();
                MessageBox.Show("Silme işlemi gerçekleşti.");
            }
            else
            {
                MessageBox.Show("Silme işlemi başarısız.");
            }
        }
        private void yeniSiparisButton_Click(object sender, EventArgs e)
        {
            int seciliSatir = dataGridView1.CurrentRow.Index;
            var musID = dataGridView1.Rows[seciliSatir].Cells[0].Value.ToString();
            Form3 f3 = new Form3(int.Parse(musID));
            f3.ShowDialog();
        }

        private void yolaCiktiButton_Click(object sender, EventArgs e)
        {
            int seciliSatir = dataGridView2.CurrentRow.Index;
            var musID = dataGridView2.Rows[seciliSatir].Cells[0].Value.ToString();
            Helper.UpdateSiparis(int.Parse(musID), "Yolda...");
            dataGrid2Guncelle();
        }

        private void teslimEdildiButton_Click(object sender, EventArgs e)
        {
            int seciliSatir = dataGridView2.CurrentRow.Index;
            var musID = dataGridView2.Rows[seciliSatir].Cells[0].Value.ToString();
            Helper.UpdateSiparis(int.Parse(musID), "Teslim Edildi.");
            dataGrid2Guncelle();
        }

        private void BugununSiparisleriButton_Click(object sender, EventArgs e)
        {
            using (SuSatisEntities s = new SuSatisEntities())
            {
                var th = DateTime.Now.Date;
                if (true)
                {
                    var pp = s.siparisler.Where(x => x.tarih == th).ToList();
                    if (this.dataGridView2.DataSource != null)
                    {
                        this.dataGridView2.DataSource = null;
                    }
                    else
                    {
                        this.dataGridView2.Rows.Clear();
                    }
                    foreach (var item in pp)
                    {
                        int satir = dataGridView2.Rows.Add();
                        dataGridView2.Rows[satir].Cells[0].Value = item.siparisID;
                        dataGridView2.Rows[satir].Cells[1].Value = item.musteriler.adi;
                        dataGridView2.Rows[satir].Cells[2].Value = item.musteriler.soyadi;
                        dataGridView2.Rows[satir].Cells[3].Value = item.durum;
                        dataGridView2.Rows[satir].Cells[4].Value = item.musteriler.adres;
                        dataGridView2.Rows[satir].Cells[5].Value = item.tutar;
                    }
                }
            }
        }

        private void aramaButton_Click(object sender, EventArgs e)
        {
            using (SuSatisEntities s = new SuSatisEntities())
            {
                if (s.musteriler.Where(x => x.adi.Contains(musteriAdiTextBox.Text) && x.soyadi.Contains(musteriSoyadiTextBox.Text)).Any())
                {
                    var pp = s.musteriler.Where(x => x.adi.Contains(musteriAdiTextBox.Text) && x.soyadi.Contains(musteriSoyadiTextBox.Text)).ToList();
                    if (this.dataGridView1.DataSource != null)
                    {
                        this.dataGridView1.DataSource = null;
                    }
                    else
                    {
                        this.dataGridView1.Rows.Clear();
                    }
                    foreach (var item in pp)
                    {
                        int satir = dataGridView1.Rows.Add();
                        dataGridView1.Rows[satir].Cells[0].Value = item.musteriID;
                        dataGridView1.Rows[satir].Cells[1].Value = item.adi;
                        dataGridView1.Rows[satir].Cells[2].Value = item.soyadi;
                        dataGridView1.Rows[satir].Cells[3].Value = item.telefon;
                        dataGridView1.Rows[satir].Cells[4].Value = item.adres;
                    }
                }
            }
        }
    }
}
