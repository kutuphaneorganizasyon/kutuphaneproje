
namespace kitapekleme
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
            this.kitapisimtxt = new System.Windows.Forms.TextBox();
            this.kitapidtxt = new System.Windows.Forms.TextBox();
            this.sayfasayitxt = new System.Windows.Forms.TextBox();
            this.yazarisimtxt = new System.Windows.Forms.TextBox();
            this.cevirmenisimtxt = new System.Windows.Forms.TextBox();
            this.yayinevitxt = new System.Windows.Forms.TextBox();
            this.kategoritxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yazarisimlbl = new System.Windows.Forms.Label();
            this.cevirmenlbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kategoriİsim = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.anahtarkelimetxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kitapisimtxt
            // 
            this.kitapisimtxt.Location = new System.Drawing.Point(224, 94);
            this.kitapisimtxt.Name = "kitapisimtxt";
            this.kitapisimtxt.Size = new System.Drawing.Size(121, 22);
            this.kitapisimtxt.TabIndex = 0;
            // 
            // kitapidtxt
            // 
            this.kitapidtxt.Location = new System.Drawing.Point(224, 31);
            this.kitapidtxt.Name = "kitapidtxt";
            this.kitapidtxt.Size = new System.Drawing.Size(121, 22);
            this.kitapidtxt.TabIndex = 1;
            // 
            // sayfasayitxt
            // 
            this.sayfasayitxt.Location = new System.Drawing.Point(224, 158);
            this.sayfasayitxt.Name = "sayfasayitxt";
            this.sayfasayitxt.Size = new System.Drawing.Size(121, 22);
            this.sayfasayitxt.TabIndex = 2;
            // 
            // yazarisimtxt
            // 
            this.yazarisimtxt.Location = new System.Drawing.Point(224, 227);
            this.yazarisimtxt.Name = "yazarisimtxt";
            this.yazarisimtxt.Size = new System.Drawing.Size(121, 22);
            this.yazarisimtxt.TabIndex = 3;
            // 
            // cevirmenisimtxt
            // 
            this.cevirmenisimtxt.Location = new System.Drawing.Point(598, 94);
            this.cevirmenisimtxt.Name = "cevirmenisimtxt";
            this.cevirmenisimtxt.Size = new System.Drawing.Size(100, 22);
            this.cevirmenisimtxt.TabIndex = 4;
            // 
            // yayinevitxt
            // 
            this.yayinevitxt.Location = new System.Drawing.Point(598, 31);
            this.yayinevitxt.Name = "yayinevitxt";
            this.yayinevitxt.Size = new System.Drawing.Size(100, 22);
            this.yayinevitxt.TabIndex = 5;
            this.yayinevitxt.TextChanged += new System.EventHandler(this.yayinevitxt_TextChanged);
            // 
            // kategoritxt
            // 
            this.kategoritxt.Location = new System.Drawing.Point(598, 163);
            this.kategoritxt.Name = "kategoritxt";
            this.kategoritxt.Size = new System.Drawing.Size(100, 22);
            this.kategoritxt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kitap İd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kitap İsim";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sayfa Sayısı";
            // 
            // yazarisimlbl
            // 
            this.yazarisimlbl.AutoSize = true;
            this.yazarisimlbl.Location = new System.Drawing.Point(92, 230);
            this.yazarisimlbl.Name = "yazarisimlbl";
            this.yazarisimlbl.Size = new System.Drawing.Size(73, 17);
            this.yazarisimlbl.TabIndex = 10;
            this.yazarisimlbl.Text = "Yazar İsmi";
            // 
            // cevirmenlbl
            // 
            this.cevirmenlbl.AutoSize = true;
            this.cevirmenlbl.BackColor = System.Drawing.Color.Transparent;
            this.cevirmenlbl.ForeColor = System.Drawing.Color.Transparent;
            this.cevirmenlbl.Location = new System.Drawing.Point(419, 99);
            this.cevirmenlbl.Name = "cevirmenlbl";
            this.cevirmenlbl.Size = new System.Drawing.Size(95, 17);
            this.cevirmenlbl.TabIndex = 11;
            this.cevirmenlbl.Text = "Çevirmen İsmi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Yayınevi İsim";
            // 
            // kategoriİsim
            // 
            this.kategoriİsim.AutoSize = true;
            this.kategoriİsim.Location = new System.Drawing.Point(416, 161);
            this.kategoriİsim.Name = "kategoriİsim";
            this.kategoriİsim.Size = new System.Drawing.Size(61, 17);
            this.kategoriİsim.TabIndex = 13;
            this.kategoriİsim.Text = "Kategori";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Anahtar Kelime";
            // 
            // anahtarkelimetxt
            // 
            this.anahtarkelimetxt.Location = new System.Drawing.Point(598, 225);
            this.anahtarkelimetxt.Name = "anahtarkelimetxt";
            this.anahtarkelimetxt.Size = new System.Drawing.Size(100, 22);
            this.anahtarkelimetxt.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::kitapekleme.Properties.Resources.png_transparent_computer_icons_add_button_logo_number_add_button_thumbnail_removebg_preview;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(356, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 59);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.yazarisimtxt);
            this.panel1.Controls.Add(this.yazarisimlbl);
            this.panel1.Controls.Add(this.sayfasayitxt);
            this.panel1.Controls.Add(this.anahtarkelimetxt);
            this.panel1.Controls.Add(this.kitapisimtxt);
            this.panel1.Controls.Add(this.kitapidtxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cevirmenlbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.kategoriİsim);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.yayinevitxt);
            this.panel1.Controls.Add(this.cevirmenisimtxt);
            this.panel1.Controls.Add(this.kategoritxt);
            this.panel1.Cursor = System.Windows.Forms.Cursors.No;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(147, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 376);
            this.panel1.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(147, 409);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(782, 150);
            this.dataGridView1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kitapekleme.Properties.Resources.colorful_vibrant_gradient_blur_wallpaper_preview;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1118, 571);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox kitapisimtxt;
        private System.Windows.Forms.TextBox kitapidtxt;
        private System.Windows.Forms.TextBox sayfasayitxt;
        private System.Windows.Forms.TextBox yazarisimtxt;
        private System.Windows.Forms.TextBox cevirmenisimtxt;
        private System.Windows.Forms.TextBox yayinevitxt;
        private System.Windows.Forms.TextBox kategoritxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label yazarisimlbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label kategoriİsim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox anahtarkelimetxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label cevirmenlbl;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

