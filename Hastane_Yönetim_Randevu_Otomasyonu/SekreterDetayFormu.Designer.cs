namespace Hastane_Yönetim_Randevu_Otomasyonu
{
    partial class SekreterDetayFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SekreterDetayFormu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTCKN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDuyuruOlustur = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.mskdTCKN = new System.Windows.Forms.MaskedTextBox();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.cmdBrans = new System.Windows.Forms.ComboBox();
            this.mskdSaat = new System.Windows.Forms.MaskedTextBox();
            this.mskdTarih = new System.Windows.Forms.MaskedTextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnRandevListesi = new System.Windows.Forms.Button();
            this.btnBransPaneli = new System.Windows.Forms.Button();
            this.btnDoktorPaneli = new System.Windows.Forms.Button();
            this.btnDuyuru = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAdSoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblTCKN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(89, 65);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(70, 23);
            this.lblAdSoyad.TabIndex = 7;
            this.lblAdSoyad.Text = "NullNull";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ad Soyad:";
            // 
            // lblTCKN
            // 
            this.lblTCKN.AutoSize = true;
            this.lblTCKN.Location = new System.Drawing.Point(89, 27);
            this.lblTCKN.Name = "lblTCKN";
            this.lblTCKN.Size = new System.Drawing.Size(120, 23);
            this.lblTCKN.TabIndex = 5;
            this.lblTCKN.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "TCKN:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDuyuruOlustur);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 208);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // btnDuyuruOlustur
            // 
            this.btnDuyuruOlustur.Location = new System.Drawing.Point(8, 165);
            this.btnDuyuruOlustur.Name = "btnDuyuruOlustur";
            this.btnDuyuruOlustur.Size = new System.Drawing.Size(305, 31);
            this.btnDuyuruOlustur.TabIndex = 1;
            this.btnDuyuruOlustur.Text = "Oluştur";
            this.btnDuyuruOlustur.UseVisualStyleBackColor = true;
            this.btnDuyuruOlustur.Click += new System.EventHandler(this.btnDuyuruOlustur_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(8, 30);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(305, 129);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnKaydet);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.mskdTCKN);
            this.groupBox3.Controls.Add(this.cmbDoktor);
            this.groupBox3.Controls.Add(this.cmdBrans);
            this.groupBox3.Controls.Add(this.mskdSaat);
            this.groupBox3.Controls.Add(this.mskdTarih);
            this.groupBox3.Controls.Add(this.txtId);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(337, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 378);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(101, 301);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(137, 31);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(101, 277);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 27);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Durum";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // mskdTCKN
            // 
            this.mskdTCKN.Location = new System.Drawing.Point(101, 235);
            this.mskdTCKN.Mask = "00000000000";
            this.mskdTCKN.Name = "mskdTCKN";
            this.mskdTCKN.Size = new System.Drawing.Size(124, 31);
            this.mskdTCKN.TabIndex = 12;
            this.mskdTCKN.ValidatingType = typeof(int);
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(101, 197);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(124, 31);
            this.cmbDoktor.TabIndex = 11;
            // 
            // cmdBrans
            // 
            this.cmdBrans.FormattingEnabled = true;
            this.cmdBrans.Location = new System.Drawing.Point(101, 157);
            this.cmdBrans.Name = "cmdBrans";
            this.cmdBrans.Size = new System.Drawing.Size(124, 31);
            this.cmdBrans.TabIndex = 10;
            this.cmdBrans.SelectedIndexChanged += new System.EventHandler(this.cmdBrans_SelectedIndexChanged);
            // 
            // mskdSaat
            // 
            this.mskdSaat.Location = new System.Drawing.Point(101, 119);
            this.mskdSaat.Mask = "00:00";
            this.mskdSaat.Name = "mskdSaat";
            this.mskdSaat.Size = new System.Drawing.Size(124, 31);
            this.mskdSaat.TabIndex = 9;
            this.mskdSaat.ValidatingType = typeof(System.DateTime);
            // 
            // mskdTarih
            // 
            this.mskdTarih.Location = new System.Drawing.Point(101, 82);
            this.mskdTarih.Mask = "00/00/0000";
            this.mskdTarih.Name = "mskdTarih";
            this.mskdTarih.Size = new System.Drawing.Size(124, 31);
            this.mskdTarih.TabIndex = 8;
            this.mskdTarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(101, 40);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(124, 31);
            this.txtId.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "TCKN:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Doktor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Branş:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Saat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tarih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "id:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(608, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(326, 237);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(320, 207);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(608, 255);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(326, 228);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(320, 198);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnDuyuru);
            this.groupBox6.Controls.Add(this.btnRandevListesi);
            this.groupBox6.Controls.Add(this.btnBransPaneli);
            this.groupBox6.Controls.Add(this.btnDoktorPaneli);
            this.groupBox6.Location = new System.Drawing.Point(15, 396);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(590, 100);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // btnRandevListesi
            // 
            this.btnRandevListesi.Location = new System.Drawing.Point(307, 42);
            this.btnRandevListesi.Name = "btnRandevListesi";
            this.btnRandevListesi.Size = new System.Drawing.Size(137, 31);
            this.btnRandevListesi.TabIndex = 17;
            this.btnRandevListesi.Text = "Randevu Listesi";
            this.btnRandevListesi.UseVisualStyleBackColor = true;
            this.btnRandevListesi.Click += new System.EventHandler(this.btnRandevListesi_Click);
            // 
            // btnBransPaneli
            // 
            this.btnBransPaneli.Location = new System.Drawing.Point(164, 42);
            this.btnBransPaneli.Name = "btnBransPaneli";
            this.btnBransPaneli.Size = new System.Drawing.Size(137, 31);
            this.btnBransPaneli.TabIndex = 16;
            this.btnBransPaneli.Text = "Branş Paneli";
            this.btnBransPaneli.UseVisualStyleBackColor = true;
            this.btnBransPaneli.Click += new System.EventHandler(this.btnBransPaneli_Click);
            // 
            // btnDoktorPaneli
            // 
            this.btnDoktorPaneli.Location = new System.Drawing.Point(21, 42);
            this.btnDoktorPaneli.Name = "btnDoktorPaneli";
            this.btnDoktorPaneli.Size = new System.Drawing.Size(137, 31);
            this.btnDoktorPaneli.TabIndex = 15;
            this.btnDoktorPaneli.Text = "Doktor Paneli";
            this.btnDoktorPaneli.UseVisualStyleBackColor = true;
            this.btnDoktorPaneli.Click += new System.EventHandler(this.btnDoktorPaneli_Click);
            // 
            // btnDuyuru
            // 
            this.btnDuyuru.Location = new System.Drawing.Point(450, 42);
            this.btnDuyuru.Name = "btnDuyuru";
            this.btnDuyuru.Size = new System.Drawing.Size(137, 31);
            this.btnDuyuru.TabIndex = 18;
            this.btnDuyuru.Text = "Duyurular";
            this.btnDuyuru.UseVisualStyleBackColor = true;
            this.btnDuyuru.Click += new System.EventHandler(this.btnDuyuru_Click);
            // 
            // SekreterDetayFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(937, 495);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "SekreterDetayFormu";
            this.Text = "SekreterDetayFormu";
            this.Load += new System.EventHandler(this.SekreterDetayFormu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTCKN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDuyuruOlustur;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskdSaat;
        private System.Windows.Forms.MaskedTextBox mskdTarih;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MaskedTextBox mskdTCKN;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.ComboBox cmdBrans;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnRandevListesi;
        private System.Windows.Forms.Button btnBransPaneli;
        private System.Windows.Forms.Button btnDoktorPaneli;
        private System.Windows.Forms.Button btnDuyuru;
    }
}