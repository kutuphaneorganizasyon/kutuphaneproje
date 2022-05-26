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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            kitapSil kitapsil = new kitapSil();
            kitapsil.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            uyesil uyesil = new uyesil();
            uyesil.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        { 
            uye_ekleme uye_Ekleme = new uye_ekleme();
            uye_Ekleme.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kitapekle kitapekle = new kitapekle();
            kitapekle.Show();
        }
    }
    
}
