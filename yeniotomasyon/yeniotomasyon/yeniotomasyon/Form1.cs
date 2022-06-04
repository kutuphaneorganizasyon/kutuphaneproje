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
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ;
        }

        private void button4_Click(object sender, EventArgs e)
        { 
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            

            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            uye_ekleme uye_Ekleme = new uye_ekleme();
            uye_Ekleme.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            kitapekle kitapekle = new kitapekle();
            kitapekle.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            kitapSil kitapsil = new kitapSil();
            kitapsil.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Emanetkitapverfrm emanetkitapverfrm = new Emanetkitapverfrm();
            emanetkitapverfrm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            uyesil uyesil = new uyesil();
            uyesil.Show();
        }
    }
    
}
