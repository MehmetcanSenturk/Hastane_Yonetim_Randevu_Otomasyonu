namespace Hastane_Yönetim_Randevu_Otomasyonu
{
    partial class HastaDetayFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaDetayFormu));
            this.grpBilgi = new System.Windows.Forms.GroupBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTCKN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpRandevu = new System.Windows.Forms.GroupBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lnkBilgiDuzenle = new System.Windows.Forms.LinkLabel();
            this.btnRandevu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richSikayet = new System.Windows.Forms.RichTextBox();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.grpRandevuGecmisi = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpAktifRandevu = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.grpBilgi.SuspendLayout();
            this.grpRandevu.SuspendLayout();
            this.grpRandevuGecmisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpAktifRandevu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBilgi
            // 
            this.grpBilgi.Controls.Add(this.lblAdSoyad);
            this.grpBilgi.Controls.Add(this.label3);
            this.grpBilgi.Controls.Add(this.lblTCKN);
            this.grpBilgi.Controls.Add(this.label1);
            this.grpBilgi.Location = new System.Drawing.Point(4, 0);
            this.grpBilgi.Name = "grpBilgi";
            this.grpBilgi.Size = new System.Drawing.Size(424, 248);
            this.grpBilgi.TabIndex = 0;
            this.grpBilgi.TabStop = false;
            this.grpBilgi.Text = "Bilgi Ekranı";
            this.grpBilgi.Enter += new System.EventHandler(this.grpBilgi_Enter);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(112, 59);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(74, 23);
            this.lblAdSoyad.TabIndex = 4;
            this.lblAdSoyad.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ad Soyad:";
            // 
            // lblTCKN
            // 
            this.lblTCKN.AutoSize = true;
            this.lblTCKN.Location = new System.Drawing.Point(112, 27);
            this.lblTCKN.Name = "lblTCKN";
            this.lblTCKN.Size = new System.Drawing.Size(120, 23);
            this.lblTCKN.TabIndex = 2;
            this.lblTCKN.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "TCKN:";
            // 
            // grpRandevu
            // 
            this.grpRandevu.Controls.Add(this.txtid);
            this.grpRandevu.Controls.Add(this.lblid);
            this.grpRandevu.Controls.Add(this.lnkBilgiDuzenle);
            this.grpRandevu.Controls.Add(this.btnRandevu);
            this.grpRandevu.Controls.Add(this.label7);
            this.grpRandevu.Controls.Add(this.label6);
            this.grpRandevu.Controls.Add(this.richSikayet);
            this.grpRandevu.Controls.Add(this.cmbDoktor);
            this.grpRandevu.Controls.Add(this.label5);
            this.grpRandevu.Controls.Add(this.cmbBrans);
            this.grpRandevu.Location = new System.Drawing.Point(4, 254);
            this.grpRandevu.Name = "grpRandevu";
            this.grpRandevu.Size = new System.Drawing.Size(424, 337);
            this.grpRandevu.TabIndex = 1;
            this.grpRandevu.TabStop = false;
            this.grpRandevu.Text = "Randevu Paneli";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(84, 22);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(148, 31);
            this.txtid.TabIndex = 1;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(37, 27);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(29, 23);
            this.lblid.TabIndex = 9;
            this.lblid.Text = "id:";
            // 
            // lnkBilgiDuzenle
            // 
            this.lnkBilgiDuzenle.ActiveLinkColor = System.Drawing.Color.White;
            this.lnkBilgiDuzenle.AutoSize = true;
            this.lnkBilgiDuzenle.LinkColor = System.Drawing.Color.White;
            this.lnkBilgiDuzenle.Location = new System.Drawing.Point(274, 30);
            this.lnkBilgiDuzenle.Name = "lnkBilgiDuzenle";
            this.lnkBilgiDuzenle.Size = new System.Drawing.Size(150, 23);
            this.lnkBilgiDuzenle.TabIndex = 8;
            this.lnkBilgiDuzenle.TabStop = true;
            this.lnkBilgiDuzenle.Text = "Bilgilerimi Düzenle";
            this.lnkBilgiDuzenle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBilgiDuzenle_LinkClicked);
            // 
            // btnRandevu
            // 
            this.btnRandevu.Location = new System.Drawing.Point(276, 290);
            this.btnRandevu.Name = "btnRandevu";
            this.btnRandevu.Size = new System.Drawing.Size(148, 41);
            this.btnRandevu.TabIndex = 6;
            this.btnRandevu.Text = "Randevu Oluştur";
            this.btnRandevu.UseVisualStyleBackColor = true;
            this.btnRandevu.Click += new System.EventHandler(this.btnRandevu_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Şikayet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Doktor:";
            // 
            // richSikayet
            // 
            this.richSikayet.Location = new System.Drawing.Point(84, 130);
            this.richSikayet.Name = "richSikayet";
            this.richSikayet.Size = new System.Drawing.Size(334, 160);
            this.richSikayet.TabIndex = 4;
            this.richSikayet.Text = "";
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(84, 93);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(148, 31);
            this.cmbDoktor.TabIndex = 3;
            this.cmbDoktor.SelectedIndexChanged += new System.EventHandler(this.cmbDoktor_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Branş:";
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(84, 56);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(148, 31);
            this.cmbBrans.TabIndex = 2;
            this.cmbBrans.SelectedIndexChanged += new System.EventHandler(this.cmbBrans_SelectedIndexChanged);
            // 
            // grpRandevuGecmisi
            // 
            this.grpRandevuGecmisi.Controls.Add(this.dataGridView1);
            this.grpRandevuGecmisi.Location = new System.Drawing.Point(434, 0);
            this.grpRandevuGecmisi.Name = "grpRandevuGecmisi";
            this.grpRandevuGecmisi.Size = new System.Drawing.Size(901, 318);
            this.grpRandevuGecmisi.TabIndex = 2;
            this.grpRandevuGecmisi.TabStop = false;
            this.grpRandevuGecmisi.Text = "Randevu Geçmişi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(895, 288);
            this.dataGridView1.TabIndex = 0;
            // 
            // grpAktifRandevu
            // 
            this.grpAktifRandevu.Controls.Add(this.dataGridView2);
            this.grpAktifRandevu.Location = new System.Drawing.Point(435, 321);
            this.grpAktifRandevu.Name = "grpAktifRandevu";
            this.grpAktifRandevu.Size = new System.Drawing.Size(900, 270);
            this.grpAktifRandevu.TabIndex = 3;
            this.grpAktifRandevu.TabStop = false;
            this.grpAktifRandevu.Text = "Aktif Randevular";
            this.grpAktifRandevu.Enter += new System.EventHandler(this.grpAktifRandevu_Enter);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(894, 240);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // HastaDetayFormu
            // 
            this.AcceptButton = this.btnRandevu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1339, 599);
            this.Controls.Add(this.grpAktifRandevu);
            this.Controls.Add(this.grpRandevuGecmisi);
            this.Controls.Add(this.grpRandevu);
            this.Controls.Add(this.grpBilgi);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "HastaDetayFormu";
            this.Text = "HastaDetayFormu";
            this.Load += new System.EventHandler(this.HastaDetayFormu_Load);
            this.grpBilgi.ResumeLayout(false);
            this.grpBilgi.PerformLayout();
            this.grpRandevu.ResumeLayout(false);
            this.grpRandevu.PerformLayout();
            this.grpRandevuGecmisi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpAktifRandevu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBilgi;
        private System.Windows.Forms.Label lblTCKN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpRandevu;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richSikayet;
        private System.Windows.Forms.Button btnRandevu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpRandevuGecmisi;
        private System.Windows.Forms.GroupBox grpAktifRandevu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.LinkLabel lnkBilgiDuzenle;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblid;
    }
}