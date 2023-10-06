namespace Hastane_Yönetim_Randevu_Otomasyonu
{
    partial class AnaGirisFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaGirisFormu));
            this.label1 = new System.Windows.Forms.Label();
            this.btnHastaGiris = new System.Windows.Forms.Button();
            this.btnDoktorGiris = new System.Windows.Forms.Button();
            this.btnSekreterGiris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta";
            // 
            // btnHastaGiris
            // 
            this.btnHastaGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHastaGiris.BackgroundImage")));
            this.btnHastaGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHastaGiris.Location = new System.Drawing.Point(12, 140);
            this.btnHastaGiris.Name = "btnHastaGiris";
            this.btnHastaGiris.Size = new System.Drawing.Size(206, 185);
            this.btnHastaGiris.TabIndex = 1;
            this.btnHastaGiris.UseVisualStyleBackColor = true;
            this.btnHastaGiris.Click += new System.EventHandler(this.btnHastaGiris_Click);
            // 
            // btnDoktorGiris
            // 
            this.btnDoktorGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoktorGiris.BackgroundImage")));
            this.btnDoktorGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoktorGiris.Location = new System.Drawing.Point(316, 140);
            this.btnDoktorGiris.Name = "btnDoktorGiris";
            this.btnDoktorGiris.Size = new System.Drawing.Size(208, 185);
            this.btnDoktorGiris.TabIndex = 2;
            this.btnDoktorGiris.UseVisualStyleBackColor = true;
            this.btnDoktorGiris.Click += new System.EventHandler(this.btnDoktorGiris_Click);
            // 
            // btnSekreterGiris
            // 
            this.btnSekreterGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSekreterGiris.BackgroundImage")));
            this.btnSekreterGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSekreterGiris.Location = new System.Drawing.Point(608, 140);
            this.btnSekreterGiris.Name = "btnSekreterGiris";
            this.btnSekreterGiris.Size = new System.Drawing.Size(208, 185);
            this.btnSekreterGiris.TabIndex = 3;
            this.btnSekreterGiris.UseVisualStyleBackColor = true;
            this.btnSekreterGiris.Click += new System.EventHandler(this.btnSekreterGiris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(604, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(648, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(2, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(501, 80);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hastalık Hastanesi";
            // 
            // AnaGirisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(828, 368);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSekreterGiris);
            this.Controls.Add(this.btnDoktorGiris);
            this.Controls.Add(this.btnHastaGiris);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "AnaGirisFormu";
            this.Text = "Hastane Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHastaGiris;
        private System.Windows.Forms.Button btnDoktorGiris;
        private System.Windows.Forms.Button btnSekreterGiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

