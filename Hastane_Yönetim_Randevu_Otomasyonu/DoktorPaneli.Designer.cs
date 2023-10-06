namespace Hastane_Yönetim_Randevu_Otomasyonu
{
    partial class DoktorPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorPaneli));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTCKN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rchSikayet = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groRandevuListesi = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnDuyurular = new System.Windows.Forms.Button();
            this.btnBilgiDuzenle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groRandevuListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(375, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Detay";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(100, 65);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(70, 23);
            this.lblAdSoyad.TabIndex = 3;
            this.lblAdSoyad.Text = "NullNull";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad Soyad:";
            // 
            // lblTCKN
            // 
            this.lblTCKN.AutoSize = true;
            this.lblTCKN.Location = new System.Drawing.Point(100, 27);
            this.lblTCKN.Name = "lblTCKN";
            this.lblTCKN.Size = new System.Drawing.Size(120, 23);
            this.lblTCKN.TabIndex = 1;
            this.lblTCKN.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TCKN:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rchSikayet);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 248);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            // 
            // rchSikayet
            // 
            this.rchSikayet.Location = new System.Drawing.Point(6, 53);
            this.rchSikayet.Name = "rchSikayet";
            this.rchSikayet.Size = new System.Drawing.Size(363, 191);
            this.rchSikayet.TabIndex = 2;
            this.rchSikayet.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Şikayet:";
            // 
            // groRandevuListesi
            // 
            this.groRandevuListesi.Controls.Add(this.dataGridView1);
            this.groRandevuListesi.Location = new System.Drawing.Point(393, 12);
            this.groRandevuListesi.Name = "groRandevuListesi";
            this.groRandevuListesi.Size = new System.Drawing.Size(670, 627);
            this.groRandevuListesi.TabIndex = 2;
            this.groRandevuListesi.TabStop = false;
            this.groRandevuListesi.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(664, 597);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCikis);
            this.groupBox3.Controls.Add(this.btnDuyurular);
            this.groupBox3.Controls.Add(this.btnBilgiDuzenle);
            this.groupBox3.Location = new System.Drawing.Point(6, 508);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 131);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hızlı Erişim";
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(6, 87);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(363, 37);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnDuyurular
            // 
            this.btnDuyurular.Location = new System.Drawing.Point(251, 30);
            this.btnDuyurular.Name = "btnDuyurular";
            this.btnDuyurular.Size = new System.Drawing.Size(118, 37);
            this.btnDuyurular.TabIndex = 1;
            this.btnDuyurular.Text = "Duyurular";
            this.btnDuyurular.UseVisualStyleBackColor = true;
            this.btnDuyurular.Click += new System.EventHandler(this.btnDuyurular_Click);
            // 
            // btnBilgiDuzenle
            // 
            this.btnBilgiDuzenle.Location = new System.Drawing.Point(6, 30);
            this.btnBilgiDuzenle.Name = "btnBilgiDuzenle";
            this.btnBilgiDuzenle.Size = new System.Drawing.Size(118, 37);
            this.btnBilgiDuzenle.TabIndex = 0;
            this.btnBilgiDuzenle.Text = "Bilgi Düzenle";
            this.btnBilgiDuzenle.UseVisualStyleBackColor = true;
            this.btnBilgiDuzenle.Click += new System.EventHandler(this.btnBilgiDuzenle_Click);
            // 
            // DoktorPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1067, 640);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groRandevuListesi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "DoktorPaneli";
            this.Text = "DoktorPaneli";
            this.Load += new System.EventHandler(this.DoktorPaneli_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groRandevuListesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTCKN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groRandevuListesi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox rchSikayet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnDuyurular;
        private System.Windows.Forms.Button btnBilgiDuzenle;
    }
}