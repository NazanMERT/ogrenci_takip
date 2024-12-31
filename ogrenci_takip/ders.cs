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
namespace ogrenci_takip
{
    public partial class ders : Form
    {
        public ders()
        {
            InitializeComponent();
        }
        string connectionString = "Host=localhost;Port=5432;Database=ogrencitakip;Username=postgres;Password=12345678";
        private void cikisbtn_Click(object sender, EventArgs e)
        {
            girisekranı girisekranı = new girisekranı();
            girisekranı.Show();
            this.Hide();
        }

        private void anasayfabtn_Click(object sender, EventArgs e)
        {
            ogretmen ogretmen = new ogretmen();
            ogretmen.Show();
            this.Hide();
        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            string bolumu = (bolumtxt.Text);
            string dersid = (derstxt.Text);
            string dersad = dersadtxt.Text;
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO ders (dersid, ders_ad,bolumid) " +
                                   "VALUES (@dersid, @dersad,@bolumu)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    // Parametreleri ekle
                    cmd.Parameters.AddWithValue("@dersid", dersid);
                    cmd.Parameters.AddWithValue("@dersad", dersad);
                    cmd.Parameters.AddWithValue("@bolumu", bolumu);
                   

                    // Sorguyu çalıştır
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Ders başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    bolumtxt.Clear();
                   dersadtxt.Clear();
                    derstxt.Clear();


                }



            }
        }
    }
}
