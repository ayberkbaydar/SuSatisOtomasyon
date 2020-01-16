namespace SuSatisOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.aramaGroupBox = new System.Windows.Forms.GroupBox();
            this.aramaButton = new System.Windows.Forms.Button();
            this.musteriSoyadiTextBox = new System.Windows.Forms.TextBox();
            this.musteriAdiTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabloGroupBox = new System.Windows.Forms.GroupBox();
            this.BugununSiparisleriButton = new System.Windows.Forms.Button();
            this.seciliyiSilButton = new System.Windows.Forms.Button();
            this.tümünüSilButton = new System.Windows.Forms.Button();
            this.musterilerGroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.silButton = new System.Windows.Forms.Button();
            this.guncelleButton = new System.Windows.Forms.Button();
            this.ekleButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparislerGroupBox = new System.Windows.Forms.GroupBox();
            this.teslimEdildiButton = new System.Windows.Forms.Button();
            this.yolaCiktiButton = new System.Windows.Forms.Button();
            this.yeniSiparisButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yenileButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.sid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssoyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sadres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aramaGroupBox.SuspendLayout();
            this.tabloGroupBox.SuspendLayout();
            this.musterilerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.siparislerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // aramaGroupBox
            // 
            this.aramaGroupBox.Controls.Add(this.aramaButton);
            this.aramaGroupBox.Controls.Add(this.musteriSoyadiTextBox);
            this.aramaGroupBox.Controls.Add(this.musteriAdiTextBox);
            this.aramaGroupBox.Controls.Add(this.label2);
            this.aramaGroupBox.Controls.Add(this.label1);
            this.aramaGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aramaGroupBox.Location = new System.Drawing.Point(12, 12);
            this.aramaGroupBox.Name = "aramaGroupBox";
            this.aramaGroupBox.Size = new System.Drawing.Size(360, 80);
            this.aramaGroupBox.TabIndex = 0;
            this.aramaGroupBox.TabStop = false;
            this.aramaGroupBox.Text = "Arama";
            // 
            // aramaButton
            // 
            this.aramaButton.BackgroundImage = global::SuSatisOtomasyonu.Properties.Resources.search;
            this.aramaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aramaButton.ImageKey = "(none)";
            this.aramaButton.Location = new System.Drawing.Point(263, 16);
            this.aramaButton.Name = "aramaButton";
            this.aramaButton.Size = new System.Drawing.Size(91, 58);
            this.aramaButton.TabIndex = 4;
            this.aramaButton.UseVisualStyleBackColor = true;
            this.aramaButton.Click += new System.EventHandler(this.aramaButton_Click);
            // 
            // musteriSoyadiTextBox
            // 
            this.musteriSoyadiTextBox.Location = new System.Drawing.Point(157, 36);
            this.musteriSoyadiTextBox.Name = "musteriSoyadiTextBox";
            this.musteriSoyadiTextBox.Size = new System.Drawing.Size(100, 20);
            this.musteriSoyadiTextBox.TabIndex = 3;
            // 
            // musteriAdiTextBox
            // 
            this.musteriAdiTextBox.Location = new System.Drawing.Point(51, 36);
            this.musteriAdiTextBox.Name = "musteriAdiTextBox";
            this.musteriAdiTextBox.Size = new System.Drawing.Size(100, 20);
            this.musteriAdiTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(154, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Müşteri Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(48, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Adı";
            // 
            // tabloGroupBox
            // 
            this.tabloGroupBox.Controls.Add(this.BugununSiparisleriButton);
            this.tabloGroupBox.Controls.Add(this.seciliyiSilButton);
            this.tabloGroupBox.Controls.Add(this.tümünüSilButton);
            this.tabloGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabloGroupBox.Location = new System.Drawing.Point(378, 12);
            this.tabloGroupBox.Name = "tabloGroupBox";
            this.tabloGroupBox.Size = new System.Drawing.Size(360, 80);
            this.tabloGroupBox.TabIndex = 1;
            this.tabloGroupBox.TabStop = false;
            this.tabloGroupBox.Text = "Sipariş İşlemleri";
            // 
            // BugununSiparisleriButton
            // 
            this.BugununSiparisleriButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BugununSiparisleriButton.Location = new System.Drawing.Point(218, 33);
            this.BugununSiparisleriButton.Name = "BugununSiparisleriButton";
            this.BugununSiparisleriButton.Size = new System.Drawing.Size(136, 23);
            this.BugununSiparisleriButton.TabIndex = 7;
            this.BugununSiparisleriButton.Text = "Bu Günün Siparişleri";
            this.BugununSiparisleriButton.UseVisualStyleBackColor = true;
            this.BugununSiparisleriButton.Click += new System.EventHandler(this.BugununSiparisleriButton_Click);
            // 
            // seciliyiSilButton
            // 
            this.seciliyiSilButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seciliyiSilButton.Location = new System.Drawing.Point(6, 33);
            this.seciliyiSilButton.Name = "seciliyiSilButton";
            this.seciliyiSilButton.Size = new System.Drawing.Size(111, 23);
            this.seciliyiSilButton.TabIndex = 5;
            this.seciliyiSilButton.Text = "Seçili Olanı Sil";
            this.seciliyiSilButton.UseVisualStyleBackColor = true;
            this.seciliyiSilButton.Click += new System.EventHandler(this.seciliyiSilButton_Click);
            // 
            // tümünüSilButton
            // 
            this.tümünüSilButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tümünüSilButton.Location = new System.Drawing.Point(123, 33);
            this.tümünüSilButton.Name = "tümünüSilButton";
            this.tümünüSilButton.Size = new System.Drawing.Size(89, 23);
            this.tümünüSilButton.TabIndex = 6;
            this.tümünüSilButton.Text = "Tümünü Sil";
            this.tümünüSilButton.UseVisualStyleBackColor = true;
            this.tümünüSilButton.Click += new System.EventHandler(this.tümünüSilButton_Click);
            // 
            // musterilerGroupBox
            // 
            this.musterilerGroupBox.Controls.Add(this.button1);
            this.musterilerGroupBox.Controls.Add(this.label8);
            this.musterilerGroupBox.Controls.Add(this.label7);
            this.musterilerGroupBox.Controls.Add(this.label6);
            this.musterilerGroupBox.Controls.Add(this.silButton);
            this.musterilerGroupBox.Controls.Add(this.guncelleButton);
            this.musterilerGroupBox.Controls.Add(this.ekleButton);
            this.musterilerGroupBox.Controls.Add(this.dataGridView1);
            this.musterilerGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musterilerGroupBox.Location = new System.Drawing.Point(12, 98);
            this.musterilerGroupBox.Name = "musterilerGroupBox";
            this.musterilerGroupBox.Size = new System.Drawing.Size(360, 340);
            this.musterilerGroupBox.TabIndex = 1;
            this.musterilerGroupBox.TabStop = false;
            this.musterilerGroupBox.Text = "Müşteriler";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Yenile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(168, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Sil";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(84, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Güncelle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ekle";
            // 
            // silButton
            // 
            this.silButton.BackgroundImage = global::SuSatisOtomasyonu.Properties.Resources.delete;
            this.silButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.silButton.Location = new System.Drawing.Point(168, 284);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(75, 50);
            this.silButton.TabIndex = 3;
            this.silButton.UseVisualStyleBackColor = true;
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            // 
            // guncelleButton
            // 
            this.guncelleButton.BackgroundImage = global::SuSatisOtomasyonu.Properties.Resources.edit;
            this.guncelleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guncelleButton.Location = new System.Drawing.Point(87, 284);
            this.guncelleButton.Name = "guncelleButton";
            this.guncelleButton.Size = new System.Drawing.Size(75, 50);
            this.guncelleButton.TabIndex = 2;
            this.guncelleButton.UseVisualStyleBackColor = true;
            this.guncelleButton.Click += new System.EventHandler(this.guncelleButton_Click);
            // 
            // ekleButton
            // 
            this.ekleButton.BackgroundImage = global::SuSatisOtomasyonu.Properties.Resources.add;
            this.ekleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ekleButton.Location = new System.Drawing.Point(6, 284);
            this.ekleButton.Name = "ekleButton";
            this.ekleButton.Size = new System.Drawing.Size(75, 50);
            this.ekleButton.TabIndex = 1;
            this.ekleButton.UseVisualStyleBackColor = true;
            this.ekleButton.Click += new System.EventHandler(this.ekleButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(348, 233);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 42;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Ad";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Soyad";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Telefon";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Adres";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // siparislerGroupBox
            // 
            this.siparislerGroupBox.Controls.Add(this.teslimEdildiButton);
            this.siparislerGroupBox.Controls.Add(this.yolaCiktiButton);
            this.siparislerGroupBox.Controls.Add(this.yeniSiparisButton);
            this.siparislerGroupBox.Controls.Add(this.label5);
            this.siparislerGroupBox.Controls.Add(this.label4);
            this.siparislerGroupBox.Controls.Add(this.label3);
            this.siparislerGroupBox.Controls.Add(this.yenileButton);
            this.siparislerGroupBox.Controls.Add(this.dataGridView2);
            this.siparislerGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparislerGroupBox.Location = new System.Drawing.Point(378, 98);
            this.siparislerGroupBox.Name = "siparislerGroupBox";
            this.siparislerGroupBox.Size = new System.Drawing.Size(360, 340);
            this.siparislerGroupBox.TabIndex = 1;
            this.siparislerGroupBox.TabStop = false;
            this.siparislerGroupBox.Text = "Siparişler";
            // 
            // teslimEdildiButton
            // 
            this.teslimEdildiButton.BackColor = System.Drawing.SystemColors.Control;
            this.teslimEdildiButton.BackgroundImage = global::SuSatisOtomasyonu.Properties.Resources.iletildi;
            this.teslimEdildiButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.teslimEdildiButton.Location = new System.Drawing.Point(171, 284);
            this.teslimEdildiButton.Name = "teslimEdildiButton";
            this.teslimEdildiButton.Size = new System.Drawing.Size(75, 50);
            this.teslimEdildiButton.TabIndex = 7;
            this.teslimEdildiButton.UseVisualStyleBackColor = false;
            this.teslimEdildiButton.Click += new System.EventHandler(this.teslimEdildiButton_Click);
            // 
            // yolaCiktiButton
            // 
            this.yolaCiktiButton.BackgroundImage = global::SuSatisOtomasyonu.Properties.Resources.local;
            this.yolaCiktiButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yolaCiktiButton.Location = new System.Drawing.Point(90, 284);
            this.yolaCiktiButton.Name = "yolaCiktiButton";
            this.yolaCiktiButton.Size = new System.Drawing.Size(75, 50);
            this.yolaCiktiButton.TabIndex = 6;
            this.yolaCiktiButton.UseVisualStyleBackColor = true;
            this.yolaCiktiButton.Click += new System.EventHandler(this.yolaCiktiButton_Click);
            // 
            // yeniSiparisButton
            // 
            this.yeniSiparisButton.BackgroundImage = global::SuSatisOtomasyonu.Properties.Resources.order;
            this.yeniSiparisButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yeniSiparisButton.Location = new System.Drawing.Point(9, 284);
            this.yeniSiparisButton.Name = "yeniSiparisButton";
            this.yeniSiparisButton.Size = new System.Drawing.Size(75, 50);
            this.yeniSiparisButton.TabIndex = 5;
            this.yeniSiparisButton.UseVisualStyleBackColor = true;
            this.yeniSiparisButton.Click += new System.EventHandler(this.yeniSiparisButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(168, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teslim Edildi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(87, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yola Çıktı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yeni Sipariş";
            // 
            // yenileButton
            // 
            this.yenileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yenileButton.Location = new System.Drawing.Point(279, 258);
            this.yenileButton.Name = "yenileButton";
            this.yenileButton.Size = new System.Drawing.Size(75, 23);
            this.yenileButton.TabIndex = 1;
            this.yenileButton.Text = "Yenile";
            this.yenileButton.UseVisualStyleBackColor = true;
            this.yenileButton.Click += new System.EventHandler(this.yenileButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sid,
            this.sadi,
            this.ssoyadi,
            this.sdurum,
            this.sadres,
            this.stutar});
            this.dataGridView2.Location = new System.Drawing.Point(6, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(348, 233);
            this.dataGridView2.TabIndex = 1;
            // 
            // sid
            // 
            this.sid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sid.HeaderText = "ID";
            this.sid.Name = "sid";
            this.sid.ReadOnly = true;
            this.sid.Width = 42;
            // 
            // sadi
            // 
            this.sadi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sadi.HeaderText = "Müşt.Adı";
            this.sadi.Name = "sadi";
            this.sadi.ReadOnly = true;
            // 
            // ssoyadi
            // 
            this.ssoyadi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ssoyadi.HeaderText = "Müşt.Soy";
            this.ssoyadi.Name = "ssoyadi";
            this.ssoyadi.ReadOnly = true;
            // 
            // sdurum
            // 
            this.sdurum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sdurum.HeaderText = "Durum";
            this.sdurum.Name = "sdurum";
            this.sdurum.ReadOnly = true;
            // 
            // sadres
            // 
            this.sadres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sadres.HeaderText = "Adres";
            this.sadres.Name = "sadres";
            this.sadres.ReadOnly = true;
            // 
            // stutar
            // 
            this.stutar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stutar.HeaderText = "Tutar";
            this.stutar.Name = "stutar";
            this.stutar.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SuSatisOtomasyonu.Properties.Resources.su;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.tabloGroupBox);
            this.Controls.Add(this.musterilerGroupBox);
            this.Controls.Add(this.siparislerGroupBox);
            this.Controls.Add(this.aramaGroupBox);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.aramaGroupBox.ResumeLayout(false);
            this.aramaGroupBox.PerformLayout();
            this.tabloGroupBox.ResumeLayout(false);
            this.musterilerGroupBox.ResumeLayout(false);
            this.musterilerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.siparislerGroupBox.ResumeLayout(false);
            this.siparislerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox aramaGroupBox;
        private System.Windows.Forms.Button aramaButton;
        private System.Windows.Forms.TextBox musteriSoyadiTextBox;
        private System.Windows.Forms.TextBox musteriAdiTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox tabloGroupBox;
        private System.Windows.Forms.GroupBox musterilerGroupBox;
        private System.Windows.Forms.GroupBox siparislerGroupBox;
        private System.Windows.Forms.Button BugununSiparisleriButton;
        private System.Windows.Forms.Button seciliyiSilButton;
        private System.Windows.Forms.Button tümünüSilButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sid;
        private System.Windows.Forms.DataGridViewTextBoxColumn sadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssoyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdurum;
        private System.Windows.Forms.DataGridViewTextBoxColumn sadres;
        private System.Windows.Forms.DataGridViewTextBoxColumn stutar;
        private System.Windows.Forms.Button yeniSiparisButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button yenileButton;
        private System.Windows.Forms.Button teslimEdildiButton;
        private System.Windows.Forms.Button yolaCiktiButton;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.Button guncelleButton;
        private System.Windows.Forms.Button ekleButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

