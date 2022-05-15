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


namespace mysql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection();
            baglanti.ConnectionString = "Server=172.21.54.3; uid=Ubebe; pwd=Ubebe123.;database=Ubebe";
             baglanti.Open();
            //MySqlCommand komutum =new MySqlCommand();
            //komutum.Connection = baglanti;
            //komutum.CommandText = "insert into personel(id,adSoyad,Telefon,eposta,departmanid) values ('"+ textBox1.Text+"','"+textBox2.Text+"','" +textBox3.Text + "','" + Convert.ToInt32(textBox4.Text) + ")";
            //new MySqlCommand();
            //komutum.ExecuteNonQuery();
            //baglanti.Close();
            //MessageBox.Show("kaydedildi");
            (new MySqlCommand("insert into personel (adsoyad,telefon,eposta,departmanid) values ('" + textBox1.Text + "','" + textBox2.Text + "','"
                + textBox3.Text + "','" + Convert.ToInt32(textBox4.Text) + "'   )",baglanti)).ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaydedildi");
               




        }
    }
}
