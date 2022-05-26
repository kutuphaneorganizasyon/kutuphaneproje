using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
    

namespace yeniotomasyon
{
    public partial class kitapekle : Form
    {
        public kitapekle()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("deneme", "Kitap İd");
            dataGridView1.Columns.Add("deneme", "Kitap Adı");
            dataGridView1.Columns.Add("deneme", "Baskı");
            dataGridView1.Columns.Add("deneme", "Cilt");
            dataGridView1.Columns.Add("deneme", "İSBN");
            dataGridView1.Columns.Add("deneme", "Kitap Dili");
            dataGridView1.Columns.Add("deneme", "Çevirme Yılı");
            dataGridView1.Columns.Add("deneme", "Sayfa Sayısı");
            dataGridView1.Columns.Add("deneme", "Raf Konumu");
            dataGridView1.Columns.Add("deneme", "Adet");
            dataGridView1.Columns.Add("deneme", "Yayın Yılı");
            dataGridView1.Columns.Add("deneme", "Yazar İd");
            dataGridView1.Columns.Add("deneme", "Yazar Adı ");
            dataGridView1.Columns.Add("deneme", "Çevirmen İd");
            dataGridView1.Columns.Add("deneme", "Yazar Soyadı");
            dataGridView1.Columns.Add("deneme", "Çevirmen Adı");
            dataGridView1.Columns.Add("deneme", "Çevirmen Soyadı");
            dataGridView1.Columns.Add("deneme", "Kategori İd");
            dataGridView1.Columns.Add("deneme", " Yayınevi İd");
            dataGridView1.Columns.Add("deneme", " Yayınevi Ad");


        }



        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection();
            MySqlConnection baglan = mySqlConnection;
            baglan.ConnectionString = "Server=172.21.54.3; Port=3306; Database=Ubebe; Uid=Ubebe; Pwd=Ubebe123.; ";
            baglan.Open();
            if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "" && textBox4.Text.Trim() != "" && textBox5.Text.Trim() != "" && textBox6.Text.Trim() != "" && textBox7.Text.Trim() != "" && textBox8.Text.Trim() != "" && textBox9.Text.Trim() != "" && textBox10.Text.Trim() != "") 
            {
                string komut = "insert into kitap (kitap_id, kitap_adi, baski, cilt, isbn, kitap_dili, cevirme_yili,sayfa_sayisi, raf_konumu, adet, yayin_yili, yazar_id, yazar_ad, cevirmen_id, yazar_soyad, cevirmen_ad, cevirmen_soyad, kategori_id, yayinevi_id ,yayinevi_ad,) values(" + textBox11.Text + " , " + textBox1.Text + " , " + textBox2.Text + " ," + textBox3.Text + " ," + textBox4.Text + " ," + textBox5.Text + " ," + textBox12.Text + " ," + textBox6.Text + " ," + textBox7.Text + " ," + textBox8.Text + " ," + textBox9.Text + " ," + textBox10.Text + " ," + textBox13.Text + " ," + textBox14.Text + " ," + textBox15.Text + " ," + textBox16.Text + " ," + textBox17.Text + " ," + textBox18.Text + " ," + textBox19.Text + " ," + textBox20.Text + " ," + ")";
                MySqlCommand cm = new MySqlCommand(komut, baglan);
                cm.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kayıt Başarıyla Tamamlandı.");

                dataGridView1.Rows.Add(1);
                int toplam = dataGridView1.Rows.Count;
                dataGridView1.Rows[toplam - 2].Cells[0].Value = textBox11.Text;
                dataGridView1.Rows[toplam - 2].Cells[1].Value = textBox1.Text;
                dataGridView1.Rows[toplam - 2].Cells[2].Value = textBox2.Text;
                dataGridView1.Rows[toplam - 2].Cells[3].Value = textBox3.Text;
                dataGridView1.Rows[toplam - 2].Cells[4].Value = textBox4.Text;
                dataGridView1.Rows[toplam - 2].Cells[5].Value = textBox5.Text;
                dataGridView1.Rows[toplam - 2].Cells[6].Value = textBox12.Text;
                dataGridView1.Rows[toplam - 2].Cells[7].Value = textBox6.Text;
                dataGridView1.Rows[toplam - 2].Cells[8].Value = textBox7.Text;
                dataGridView1.Rows[toplam - 2].Cells[9].Value = textBox8.Text;
                dataGridView1.Rows[toplam - 2].Cells[10].Value = textBox9.Text;
                dataGridView1.Rows[toplam - 2].Cells[11].Value = textBox10.Text;
                dataGridView1.Rows[toplam - 2].Cells[12].Value = textBox13.Text;
                dataGridView1.Rows[toplam - 2].Cells[13].Value = textBox14.Text;
                dataGridView1.Rows[toplam - 2].Cells[14].Value = textBox15.Text;
                dataGridView1.Rows[toplam - 2].Cells[15].Value = textBox16.Text;
                dataGridView1.Rows[toplam - 2].Cells[16].Value = textBox17.Text;
                dataGridView1.Rows[toplam - 2].Cells[17].Value = textBox18.Text;
                dataGridView1.Rows[toplam - 2].Cells[18].Value = textBox19.Text;
                dataGridView1.Rows[toplam - 2].Cells[19].Value = textBox20.Text;

                textBox11.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox12.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox13.Text = "";
                textBox14.Text = "";
                textBox15.Text = "";
                textBox16.Text = "";
                textBox17.Text = "";
                textBox18.Text = "";
                textBox19.Text = "";
                textBox20.Text = "";
                
            }
            else MessageBox.Show("TÜM ALANLARI DOLDURUNUZ");
        }
    }
}
