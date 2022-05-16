
namespace KutuphaneOtomasyonu3
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grafiklerBtn = new System.Windows.Forms.Button();
            this.siralamaBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.emanetKitapIadeBtn = new System.Windows.Forms.Button();
            this.emanetKitapListeBtn = new System.Windows.Forms.Button();
            this.emanetKitapVerBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kitapListeBtn = new System.Windows.Forms.Button();
            this.kitapEkleBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uyeGirisBtn = new System.Windows.Forms.Button();
            this.uyeListeleBtn = new System.Windows.Forms.Button();
            this.uyeEkleBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1576, 847);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(552, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(748, 34);
            this.label1.TabIndex = 36;
            this.label1.Text = "BURSA ULUDAĞ ÜNİVERSİTESİ KÜTÜPHANE OTOMASYONU";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(185, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(224, 228);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grafiklerBtn);
            this.groupBox4.Controls.Add(this.siralamaBtn);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(945, 599);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(446, 193);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sıralama ve Grafikler";
            // 
            // grafiklerBtn
            // 
            this.grafiklerBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.grafiklerBtn.Location = new System.Drawing.Point(21, 115);
            this.grafiklerBtn.Name = "grafiklerBtn";
            this.grafiklerBtn.Size = new System.Drawing.Size(402, 43);
            this.grafiklerBtn.TabIndex = 1;
            this.grafiklerBtn.Text = "Grafikler";
            this.grafiklerBtn.UseVisualStyleBackColor = false;
            // 
            // siralamaBtn
            // 
            this.siralamaBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.siralamaBtn.Location = new System.Drawing.Point(21, 46);
            this.siralamaBtn.Name = "siralamaBtn";
            this.siralamaBtn.Size = new System.Drawing.Size(402, 43);
            this.siralamaBtn.TabIndex = 0;
            this.siralamaBtn.Text = "Sıralama";
            this.siralamaBtn.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.emanetKitapIadeBtn);
            this.groupBox3.Controls.Add(this.emanetKitapListeBtn);
            this.groupBox3.Controls.Add(this.emanetKitapVerBtn);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(386, 599);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 193);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Emanet Kitap İşlemleri";
            // 
            // emanetKitapIadeBtn
            // 
            this.emanetKitapIadeBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.emanetKitapIadeBtn.Location = new System.Drawing.Point(22, 134);
            this.emanetKitapIadeBtn.Name = "emanetKitapIadeBtn";
            this.emanetKitapIadeBtn.Size = new System.Drawing.Size(402, 43);
            this.emanetKitapIadeBtn.TabIndex = 2;
            this.emanetKitapIadeBtn.Text = "Emanet Kitap İade İşlemleri";
            this.emanetKitapIadeBtn.UseVisualStyleBackColor = false;
            // 
            // emanetKitapListeBtn
            // 
            this.emanetKitapListeBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.emanetKitapListeBtn.Location = new System.Drawing.Point(22, 75);
            this.emanetKitapListeBtn.Name = "emanetKitapListeBtn";
            this.emanetKitapListeBtn.Size = new System.Drawing.Size(402, 43);
            this.emanetKitapListeBtn.TabIndex = 1;
            this.emanetKitapListeBtn.Text = "Emanet Kitap Listeleme İşlemleri";
            this.emanetKitapListeBtn.UseVisualStyleBackColor = false;
            // 
            // emanetKitapVerBtn
            // 
            this.emanetKitapVerBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.emanetKitapVerBtn.Location = new System.Drawing.Point(21, 21);
            this.emanetKitapVerBtn.Name = "emanetKitapVerBtn";
            this.emanetKitapVerBtn.Size = new System.Drawing.Size(402, 43);
            this.emanetKitapVerBtn.TabIndex = 0;
            this.emanetKitapVerBtn.Text = "Emanet Kitap Verme İşlemleri";
            this.emanetKitapVerBtn.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kitapListeBtn);
            this.groupBox2.Controls.Add(this.kitapEkleBtn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(945, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 193);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap İşlemleri";
            // 
            // kitapListeBtn
            // 
            this.kitapListeBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.kitapListeBtn.Location = new System.Drawing.Point(21, 117);
            this.kitapListeBtn.Name = "kitapListeBtn";
            this.kitapListeBtn.Size = new System.Drawing.Size(402, 43);
            this.kitapListeBtn.TabIndex = 1;
            this.kitapListeBtn.Text = "Kitap Listeleme İşlemleri";
            this.kitapListeBtn.UseVisualStyleBackColor = false;
            // 
            // kitapEkleBtn
            // 
            this.kitapEkleBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.kitapEkleBtn.Location = new System.Drawing.Point(21, 45);
            this.kitapEkleBtn.Name = "kitapEkleBtn";
            this.kitapEkleBtn.Size = new System.Drawing.Size(402, 43);
            this.kitapEkleBtn.TabIndex = 0;
            this.kitapEkleBtn.Text = "Kitap Ekleme İşlemleri";
            this.kitapEkleBtn.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uyeGirisBtn);
            this.groupBox1.Controls.Add(this.uyeListeleBtn);
            this.groupBox1.Controls.Add(this.uyeEkleBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(386, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 193);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye İşlemleri";
            // 
            // uyeGirisBtn
            // 
            this.uyeGirisBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.uyeGirisBtn.Location = new System.Drawing.Point(22, 75);
            this.uyeGirisBtn.Name = "uyeGirisBtn";
            this.uyeGirisBtn.Size = new System.Drawing.Size(402, 43);
            this.uyeGirisBtn.TabIndex = 2;
            this.uyeGirisBtn.Text = "Üye Giriş İşlemleri";
            this.uyeGirisBtn.UseVisualStyleBackColor = false;
            // 
            // uyeListeleBtn
            // 
            this.uyeListeleBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.uyeListeleBtn.Location = new System.Drawing.Point(22, 124);
            this.uyeListeleBtn.Name = "uyeListeleBtn";
            this.uyeListeleBtn.Size = new System.Drawing.Size(402, 43);
            this.uyeListeleBtn.TabIndex = 1;
            this.uyeListeleBtn.Text = "Üye Listeleme İşlemleri";
            this.uyeListeleBtn.UseVisualStyleBackColor = false;
            this.uyeListeleBtn.Click += new System.EventHandler(this.uyeListeleBtn_Click);
            // 
            // uyeEkleBtn
            // 
            this.uyeEkleBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.uyeEkleBtn.Location = new System.Drawing.Point(22, 26);
            this.uyeEkleBtn.Name = "uyeEkleBtn";
            this.uyeEkleBtn.Size = new System.Drawing.Size(402, 43);
            this.uyeEkleBtn.TabIndex = 0;
            this.uyeEkleBtn.Text = "Üye Ekleme İşlemleri";
            this.uyeEkleBtn.UseVisualStyleBackColor = false;
            this.uyeEkleBtn.Click += new System.EventHandler(this.uyeEkleBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 847);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Ana Sayfa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button grafiklerBtn;
        private System.Windows.Forms.Button siralamaBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button emanetKitapIadeBtn;
        private System.Windows.Forms.Button emanetKitapListeBtn;
        private System.Windows.Forms.Button emanetKitapVerBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button kitapListeBtn;
        private System.Windows.Forms.Button kitapEkleBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button uyeGirisBtn;
        private System.Windows.Forms.Button uyeListeleBtn;
        private System.Windows.Forms.Button uyeEkleBtn;
    }
}

