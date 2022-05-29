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
using MySql.Data.MySqlClient;
using MySql.Data;

namespace yeniotomasyon
{
    public partial class Emanetkitapverfrm : Form
    {
        public Emanetkitapverfrm()
        {
            InitializeComponent();
        }

        private void Emanetkitapverfrm_Load(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection();
            baglanti.ConnectionString = "Server=172.21.54.3;  uid=Ubebe; pwd=Ubebe123.;database=Ubebe";
            baglanti.Open();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void grpkitapbilgi_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnekle_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            MySqlConnection baglanti = new MySqlConnection();
            baglanti.ConnectionString = "Server=172.21.54.3;  uid=Ubebe; pwd=Ubebe123.;database=Ubebe";
            baglanti.Open();
            (new MySqlCommand("insert into sepet(ISBN,Kitap Adı,Yazar Adı,Kitap Sayısı,Kitap Dili,Çevirmen,	Sayfa Sayısı,Teslim Tarihi,İade Tarihi) values('" + txtısbn.Text + "','" + txtkitapadi + "','" + txtyazaradi + "','" + txtkitapsayisi +
                 "','" + txtkitapdili + "','" + txtcevirmen + "','" + txtsayfasayisi + "','" + dateTimePicker1 + "','" + dateTimePicker2 + "','" + Convert.ToInt32(textBox1.Text) + ")", baglanti)).ExecuteNonQuery();  
            baglanti.Close();
            MessageBox.Show("Kitap Emanet Edildi"); 
=======
            //MySqlConnection baglanti = new MySqlConnection();
            //baglanti.ConnectionString = "Server=172.21.54.3;  uid=Ubebe; pwd=Ubebe123.;database=Ubebe";
            //baglanti.Open();
            //(new MySqlCommand("insert into sepet(ISBN,Kitap Adı,Yazar Adı,Kitap Sayısı,Kitap Dili,Çevirmen,	Sayfa Sayısı,Teslim Tarihi,İade Tarihi) values('" + txtısbn.Text + "','" + txtkitapadi + "','" + txtyazaradi + "','" + txtkitapsayisi +
            //     "','" + txtkitapdili + "','" + txtcevirmen + "','" + txtsayfasayisi + "','" + dateTimePicker1 + "','" + dateTimePicker2 + "','" + Convert.ToInt32(textBox1.Text) + "','"), baglanti)).ExecuteNonQuery();
            //baglanti.Close();
            //MessageBox.Show("Kitap Emanet Edildi");




>>>>>>> Stashed changes

        }

        private void ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void Txögrenci_id_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection();
            baglanti.ConnectionString = "Server=172.21.54.3;  uid=Ubebe; pwd=Ubebe123.;database=Ubebe";
            baglanti.Open();

        }
    }
}
