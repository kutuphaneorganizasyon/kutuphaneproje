using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace yeniotomasyon
{
    public partial class uye_ekleme : Form
    {
        public uye_ekleme()
        {
            InitializeComponent();
        }

        private void Uye_ekleme_Load(object sender, EventArgs e)
        {
            MessageBox.Show("sdfsadf");
        }

        private void button1_Click(object sender, EventArgs e)
        { kayit_ol(); }
        public void kayit_ol()
        {
            MySqlConnection mySqlConnection = new MySqlConnection();
            MySqlConnection baglan = mySqlConnection;
            baglan.ConnectionString = "Server=172.21.54.3; Port=3306; Database=Ubebe; Uid=Ubebe; Pwd=Ubebe123.; ";
            baglan.Open();
            if (radioButton1.Checked)
            {
                (new MySqlCommand("insert into ogrenci (ogrenci_id, kart_id, bolum_id, ogrenci_ad, ogrenci_soyad, mail, adres,tel_no, bolum) values (" + maskedTextBox1.Text + maskedTextBox2.Text + maskedTextBox4.Text
                    + textBox1.Text + textBox2.Text + textBox4.Text + textBox5.Text + maskedTextBox3.Text + textBox3.Text + ")", 
                    baglan)).ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kayıt Başarıyla Tamamlandı.");
            }
            else if (radioButton2.Checked)
            {
                (new MySqlCommand("insert into ogretmen (ogretmen_id, kart_id, ogretmen_ad, ogretmen_soyad , tel_no, adres, mail) values (" + maskedTextBox1.Text + maskedTextBox2.Text + textBox1.Text +
                    textBox2.Text + maskedTextBox3.Text + textBox5.Text + textBox4.Text + ")", baglan)).ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kayıt Başarıyla Tamamlandı.");
            }
            else if (radioButton3.Checked)
            {
                (new MySqlCommand("insert into personel (kart_id,personel_id, mail, tel_no, personel_ad, personel_soyad) values (" + maskedTextBox2.Text + maskedTextBox1.Text + textBox4.Text +
                 maskedTextBox3.Text + textBox1.Text + textBox2.Text + ")", baglan)).ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kayıt Başarıyla Tamamlandı.");
            }
            else
                MessageBox.Show("Kayıt Başarısız!");
                baglan.Close();
        }
    }
}
