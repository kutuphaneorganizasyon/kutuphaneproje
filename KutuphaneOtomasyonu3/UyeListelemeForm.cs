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
    public partial class UyeListelemeForm : Form
    {
        public UyeListelemeForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-93OLOTV\\MSSQLSERVER2;Initial Catalog=KutuphaneOtomasyonu3;Integrated Security=True");

        private void idTxt_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from Uyeekle where Id like '"+idTxt.Text+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                uyeTipCmb.Text = read["uyeliktipi"].ToString();
                adTxt.Text = read["ad"].ToString();
                soyadTxt.Text = read["soyad"].ToString();
                telTxt.Text = read["telefon"].ToString();
                kartIdTxt.Text = read["kartid"].ToString();
                adresTxt.Text = read["adres"].ToString();
                mailTxt.Text = read["mail"].ToString();
                bolumTxt.Text = read["bolumid"].ToString();
                bolumTxt.Text = read["bolum"].ToString();
              

            }
            baglanti.Close();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idTxt.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
        }
        DataSet dataSet = new DataSet();

        private void idAraTxt_TextChanged(object sender, EventArgs e)
        { dataSet.Tables["Uyeekle"].Clear();
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select*from Uyeekle where Id like '%" + idAraTxt.Text + "%'", baglanti);
            adapter.Fill(dataSet,"Uyeekle");
            dataGridView1.DataSource = dataSet.Tables["Uyeekle"];
            baglanti.Close();
        }

        private void iptalBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu kaydı silmek istiyor musunuz","Sil",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Uyeekle where Id=@Id", baglanti);
                komut.Parameters.AddWithValue("@Id", dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme işlemi gerçekleşti");
                dataSet.Tables["Uyeekle"].Clear();
                uyeListele();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }

            }

      
        }

        private void uyeListele()
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select*from Uyeekle ", baglanti);
            adapter.Fill(dataSet,"Uyeekle");
            dataGridView1.DataSource = dataSet.Tables["Uyeekle"];
            baglanti.Close();
        }

        private void UyeListelemeForm_Load(object sender, EventArgs e)
        {
            uyeListele();
        }

        private void gnclBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Uyeekle set uyeliktipi=@uyeliktipi,ad=@ad,soyad=@soyad,telefon=@telefon,kartid=@kartid,adres=@adres,mail=@mail,bolum=@bolum,bolumid=@bolumid where Id=@Id", baglanti);
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
            MessageBox.Show("Güncelleme işlemi gerçekleşti");
            dataSet.Tables["Uyeekle"].Clear();
            uyeListele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }
    }
}
