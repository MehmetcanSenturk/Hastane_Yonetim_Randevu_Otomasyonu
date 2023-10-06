namespace Hastane_Yönetim_Randevu_Otomasyonu
{
    partial class HastaBilgiDuzenlemeFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaBilgiDuzenlemeFormu));
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mskdTelNo = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.MaskedTextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mskdTc = new System.Windows.Forms.MaskedTextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnGuncelle.Location = new System.Drawing.Point(138, 280);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(88, 35);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(121, 243);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(105, 31);
            this.cmbCinsiyet.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "Cinsiyet:";
            // 
            // mskdTelNo
            // 
            this.mskdTelNo.Location = new System.Drawing.Point(121, 168);
            this.mskdTelNo.Mask = "(999) 000-0000";
            this.mskdTelNo.Name = "mskdTelNo";
            this.mskdTelNo.Size = new System.Drawing.Size(105, 31);
            this.mskdTelNo.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 23);
            this.label5.TabIndex = 27;
            this.label5.Text = "Telefon No:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(121, 57);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(105, 31);
            this.txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(121, 94);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(105, 31);
            this.txtSoyad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ad:";
            // 
            // mskdTc
            // 
            this.mskdTc.Location = new System.Drawing.Point(121, 131);
            this.mskdTc.Mask = "00000000000";
            this.mskdTc.Name = "mskdTc";
            this.mskdTc.Size = new System.Drawing.Size(105, 31);
            this.mskdTc.TabIndex = 3;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(121, 205);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(105, 31);
            this.txtSifre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "TCKN:";
            // 
            // HastaBilgiDuzenlemeFormu
            // 
            this.AcceptButton = this.btnGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(297, 345);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskdTelNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mskdTc);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "HastaBilgiDuzenlemeFormu";
            this.Text = "Hasta Bilgi Güncelleme Formu";
            this.Load += new System.EventHandler(this.HastaBilgiDuzenlemeFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskdTelNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskdTc;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}