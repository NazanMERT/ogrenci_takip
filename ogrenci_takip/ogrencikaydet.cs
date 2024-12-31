using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ogrenci_takip
{
    public partial class ogrencikaydet : Form
    {
        public ogrencikaydet()
        {
            InitializeComponent();
        }
        string connectionString = "Host=localhost;Port=5432;Database=ogrencitakip;Username=postgres;Password=12345678";
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

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
           int tcKimlikNo =Convert.ToInt32( tctxt.Text.Trim());
            string adi = adtxt.Text.Trim();
            string soyadi = soyadtxt.Text.Trim();
            string bolumu = (bolumtxt.Text);
            int ogrenciNo = Convert.ToInt32(ogrnotxt.Text.Trim());
            int sinif = Convert.ToInt32(siniftxt.Text.Trim());
            string cepNo =(cepnotxt.Text.Trim());
            DateTime dogumTarihi;
            if (!DateTime.TryParse(dogumtxt.Text, out dogumTarihi))
            {
                MessageBox.Show("Geçerli bir doğum tarihi girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string adres = adrestxt.Text.Trim();

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO ogrenci (tcno, ad, soyad, bolumid, sinif, ceptel, dogum_tarihi, adres,ogrno) " +
                                   "VALUES (@tckimlikno, @adi, @soyadi, @bolumu, @sinif, @cepNo, @dogumTarihi, @adres,@ogrenciNo)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    // Parametreleri ekle
                    cmd.Parameters.AddWithValue("@tcKimlikNo", tcKimlikNo);
                    cmd.Parameters.AddWithValue("@adi", adi);
                    cmd.Parameters.AddWithValue("@soyadi", soyadi);
                    cmd.Parameters.AddWithValue("@bolumu", bolumu);
                    cmd.Parameters.AddWithValue("@ogrenciNo", ogrenciNo);
                    cmd.Parameters.AddWithValue("@sinif", sinif);
                    cmd.Parameters.AddWithValue("@cepNo", cepNo);
                    cmd.Parameters.AddWithValue("@dogumTarihi", dogumTarihi);
                    cmd.Parameters.AddWithValue("@adres", adres);

                    // Sorguyu çalıştır
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Öğrenci başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tctxt.Clear();
                    adtxt.Clear();
                    soyadtxt.Clear();
                    bolumtxt.Clear();
                    ogrnotxt.Clear();
                    siniftxt.Clear();
                    cepnotxt.Clear();
                    dogumtxt.Clear();
                    adrestxt.Clear();

                                     
                }
               


            }
            }
    }
}
