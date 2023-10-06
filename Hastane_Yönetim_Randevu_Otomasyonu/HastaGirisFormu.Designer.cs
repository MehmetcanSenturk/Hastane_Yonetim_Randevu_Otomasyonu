namespace Hastane_Yönetim_Randevu_Otomasyonu
{
    partial class HastaGirisFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaGirisFormu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.mskdTc = new System.Windows.Forms.MaskedTextBox();
            this.linkUyeOl = new System.Windows.Forms.LinkLabel();
            this.btnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giriş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "TCKN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre:";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(106, 137);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(105, 31);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // mskdTc
            // 
            this.mskdTc.Location = new System.Drawing.Point(106, 100);
            this.mskdTc.Mask = "00000000000";
            this.mskdTc.Name = "mskdTc";
            this.mskdTc.Size = new System.Drawing.Size(105, 31);
            this.mskdTc.TabIndex = 1;
            // 
            // linkUyeOl
            // 
            this.linkUyeOl.AutoSize = true;
            this.linkUyeOl.Location = new System.Drawing.Point(217, 123);
            this.linkUyeOl.Name = "linkUyeOl";
            this.linkUyeOl.Size = new System.Drawing.Size(61, 23);
            this.linkUyeOl.TabIndex = 3;
            this.linkUyeOl.TabStop = true;
            this.linkUyeOl.Text = "Üye Ol";
            this.linkUyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUyeOl_LinkClicked);
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(106, 174);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(105, 33);
            this.btnGiris.TabIndex = 8;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // HastaGirisFormu
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(367, 230);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.linkUyeOl);
            this.Controls.Add(this.mskdTc);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "HastaGirisFormu";
            this.Text = "Hasta Giriş";
            this.Load += new System.EventHandler(this.HastaGirisFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.MaskedTextBox mskdTc;
        private System.Windows.Forms.LinkLabel linkUyeOl;
        private System.Windows.Forms.Button btnGiris;
    }
}