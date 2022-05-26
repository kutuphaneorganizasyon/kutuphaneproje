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
    public partial class uyesil : Form
    {
        public uyesil()
        {
            InitializeComponent();
        }
       


        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection();
            MySqlConnection baglan = mySqlConnection;
            baglan.ConnectionString = "Server=172.21.54.3; Port=3306; Database=Ubebe; Uid=Ubebe; Pwd=Ubebe123.; ";
            string Query = "delete from ogrenci where ogrenci_id='" + İdtextbox.Text + "';"; 
            MySqlCommand cm = new MySqlCommand(Query, baglan);
            MySqlDataReader MyReader2;
            baglan.Open();
            MyReader2 = cm.ExecuteReader();
            MessageBox.Show("Üye Silindi");
            while (MyReader2.Read())
            {
            }
            baglan.Close();









        }

        private void button3_Click(object sender, EventArgs e)
        {
            string komut = " select * from ogrenci";
        }
    }
}
