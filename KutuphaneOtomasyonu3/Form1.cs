using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uyeEkleBtn_Click(object sender, EventArgs e)
        {
            UyeEkleForm uyeEkle = new UyeEkleForm();
            uyeEkle.Show();
            
        }

        private void uyeListeleBtn_Click(object sender, EventArgs e)
        {
            UyeListelemeForm uyeListeleme = new UyeListelemeForm();
            uyeListeleme.Show();
        }
    }
}
