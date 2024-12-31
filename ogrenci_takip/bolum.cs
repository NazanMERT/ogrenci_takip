using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Net.Mime.MediaTypeNames;

namespace ogrenci_takip
{
    public partial class bolum : Form
    {
        public bolum()
        {
            InitializeComponent();
        }
        string connectionString = "Host=localhost;Port=5432;Database=ogrencitakip;Username=postgres;Password=12345678";

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            string bolumu = (bolumtxt.Text);
            string bolumad = (bolumadtxt.Text);
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO bolum (bolumid, bolum_ad) " +
                                   "VALUES (@bolumu, @bolumad)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    // Parametreleri ekle
                    cmd.Parameters.AddWithValue("@bolumu", bolumu);
                    cmd.Parameters.AddWithValue("@bolumad", bolumad);
                  
                    // Sorguyu çalıştır
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Bölüm başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    bolumtxt.Clear();
                    bolumadtxt.Clear();
                    

                }



            }
        }

        private void anasayfabtn_Click(object sender, EventArgs e)
        {
            ogretmen ogretmen = new ogretmen();
            ogretmen.Show();
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
