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
    public partial class kitapSil : Form
    {
        public kitapSil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu kaydı silmek istediğinizden emin misiniz?","Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                MySqlConnection mySqlConnection = new MySqlConnection();
                MySqlConnection baglan = mySqlConnection;
                baglan.ConnectionString = "Server=172.21.54.3; Port=3306; Database=Ubebe; Uid=Ubebe; Pwd=Ubebe123.; ";
                baglan.Open();
                string Query = "delete from kitap where kitap_id='" + kitapIdTxt.Text + "';";
                MySqlCommand cm = new MySqlCommand(Query, baglan);
                MySqlDataReader MyReader2;
                MyReader2 = cm.ExecuteReader();
                MessageBox.Show("Kitap Silindi");
                while (MyReader2.Read())
                {
                }
                baglan.Close();

            }
           


        }
    }
}
