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
    public partial class ogretmen : Form
    {
        public ogretmen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrencikaydet ogrencikaydet = new ogrencikaydet();
            ogrencikaydet.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            guncelle guncelle = new guncelle();
            guncelle.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sil sil = new sil();
            sil.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ara ara = new ara();
            ara.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            notgiris notgiris = new notgiris();
            notgiris.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            girisekranı girisekranı = new girisekranı();
            girisekranı.Show();
            this.Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            bolum bolum = new bolum();
            bolum.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ders ders = new ders();
            ders.Show();
            this.Hide();
        }
    }
}
