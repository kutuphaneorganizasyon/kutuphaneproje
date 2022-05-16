using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace KutuphaneOtomasyonu3
{
    public partial class UyeEkleForm : Form
    {
        public UyeEkleForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-93OLOTV\\MSSQLSERVER2;Initial Catalog=KutuphaneOtomasyonu3;Integrated Security=True");
       

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Uyeekle(Id,uyeliktipi,ad,soyad,telefon,kartid,adres,mail,bolum,bolumid) values(@Id,@uyeliktipi,@ad,@soyad,@telefon,@kartid,@adres,@mail,@bolum,@bolumid) ", baglanti);
            komut.Parameters.AddWithValue("@Id", idTxt.Text);
            komut.Parameters.AddWithValue("@uyeliktipi", uyeTipCmb.Text);
            komut.Parameters.AddWithValue("@ad", adTxt.Text);
            komut.Parameters.AddWithValue("@soyad", soyadTxt.Text);
            komut.Parameters.AddWithValue("@telefon", telTxt.Text);
            komut.Parameters.AddWithValue("@kartid", kartIdTxt.Text);
            komut.Parameters.AddWithValue("@adres", adresTxt.Text);
            komut.Parameters.AddWithValue("@mail", mailTxt.Text);
            komut.Parameters.AddWithValue("@bolum", bolumTxt.Text);
            komut.Parameters.AddWithValue("@bolumid", bolumIdTxt.Text);
            
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt işlemi başarıyla gerçekleşti");
            foreach(Control item in Controls)
            {
                if(item is TextBox)
                { 
                    item.Text = "";
                }
            }

        }

        private void iptalBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
