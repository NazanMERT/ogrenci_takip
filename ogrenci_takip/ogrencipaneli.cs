using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenci_takip
{
    public partial class ogrencipaneli : Form
    {
        public ogrencipaneli()
        {
            InitializeComponent();
        }

        

        private void ogrnprofilbtn_Click(object sender, EventArgs e)
        {
            öğrenciprofili öğrenciprofili = new öğrenciprofili();
            öğrenciprofili.Show();
            this.Hide();
        }

        private void cikisbtn_Click(object sender, EventArgs e)
        {
            girisekranı girisekranı = new girisekranı();
            girisekranı.Show();
            this.Hide();
        }
    }
}
