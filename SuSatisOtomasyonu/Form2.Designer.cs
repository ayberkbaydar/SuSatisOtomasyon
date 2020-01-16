namespace SuSatisOtomasyonu
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.adTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.soyadTxt = new System.Windows.Forms.TextBox();
            this.TelefonTxt = new System.Windows.Forms.TextBox();
            this.adresTxt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adTxt
            // 
            this.adTxt.Location = new System.Drawing.Point(105, 110);
            this.adTxt.Name = "adTxt";
            this.adTxt.Size = new System.Drawing.Size(100, 20);
            this.adTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Adres";
            // 
            // soyadTxt
            // 
            this.soyadTxt.Location = new System.Drawing.Point(105, 136);
            this.soyadTxt.Name = "soyadTxt";
            this.soyadTxt.Size = new System.Drawing.Size(100, 20);
            this.soyadTxt.TabIndex = 6;
            // 
            // TelefonTxt
            // 
            this.TelefonTxt.Location = new System.Drawing.Point(105, 162);
            this.TelefonTxt.Name = "TelefonTxt";
            this.TelefonTxt.Size = new System.Drawing.Size(100, 20);
            this.TelefonTxt.TabIndex = 7;
            // 
            // adresTxt
            // 
            this.adresTxt.Location = new System.Drawing.Point(105, 188);
            this.adresTxt.Name = "adresTxt";
            this.adresTxt.Size = new System.Drawing.Size(100, 20);
            this.adresTxt.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "GÜNCELLE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 406);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.adresTxt);
            this.Controls.Add(this.TelefonTxt);
            this.Controls.Add(this.soyadTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox adTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox soyadTxt;
        private System.Windows.Forms.TextBox TelefonTxt;
        private System.Windows.Forms.TextBox adresTxt;
        private System.Windows.Forms.Button button2;
    }
}