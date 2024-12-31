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
    public partial class notgiris : Form
    {
        public notgiris()
        {
            InitializeComponent();
        }
        string connectionString = "Host=localhost;Port=5432;Database=ogrencitakip;Username=postgres;Password=12345678";
        private void eklebtn_Click(object sender, EventArgs e)
        {
            int ogrno = Convert.ToInt32(ogrnotxt.Text);
          
            int vize = Convert.ToInt32(vizetxt.Text);
            int final = Convert.ToInt32(finaltxt.Text);
            int ortalama = vize * 40 / 100 + final * 60 / 100;
            orttxt.Text = ortalama.ToString();
            string sonuc;
            if (ortalama >= 50)
            {
                sonuc = "Başarılı";
                sonuctxt.Text = sonuc;
            }
            else
            {
                sonuc = "Başarısız";
                sonuctxt.Text = sonuc;
            }
            string derskodu = derstxt.Text;
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO ogrnot (ogrno,dersid,vize,final,ortalama, sonuc) " +
                                  "VALUES (@ogrno,@derskodu,@vize, @final, @ortalama, @sonuc) "; 
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    // Parametreleri ekle
                    cmd.Parameters.AddWithValue("@ogrno", ogrno);
                                  cmd.Parameters.AddWithValue("@derskodu", derskodu);
                    cmd.Parameters.AddWithValue("@vize", vize);
                    cmd.Parameters.AddWithValue("@final", final);
                    cmd.Parameters.AddWithValue("@ortalama", ortalama);
                    cmd.Parameters.AddWithValue("@sonuc", sonuc);

                    // Sorguyu çalıştır
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Öğrenci başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ogrnotxt.Clear();
                   
                    derstxt.Clear();
                    vizetxt.Clear();
                    finaltxt.Clear();
                    orttxt.Clear();
                    sonuctxt.Clear();
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

        private void degisbtn_Click(object sender, EventArgs e)
        {
            int ogrno = Convert.ToInt32(ogrnotxt.Text);
          
            int vize = Convert.ToInt32(vizetxt.Text);
            int final = Convert.ToInt32(finaltxt.Text);
            int ortalama = vize * 40 / 100 + final * 60 / 100;
            orttxt.Text = ortalama.ToString();
            string sonuc;
            if (ortalama >= 50)
            {
                sonuc = "Başarılı";
                sonuctxt.Text = sonuc;
            }
            else
            {
                sonuc = "Başarısız";
                sonuctxt.Text = sonuc;
            }
            string derskodu = derstxt.Text;
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE ogrnot SET " +
                                  " dersid = @derskodu, " +
                                  "vize = @vize, final = @final, ortalama = @ortalama, sonuc = @sonuc " +
                                  "WHERE ogrno = @ogrno";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    // Parametreleri ekle
                    cmd.Parameters.AddWithValue("@ogrno", ogrno);
                 
                    cmd.Parameters.AddWithValue("@derskodu", derskodu);
                    cmd.Parameters.AddWithValue("@vize", vize);
                    cmd.Parameters.AddWithValue("@final", final);
                    cmd.Parameters.AddWithValue("@ortalama", ortalama);
                    cmd.Parameters.AddWithValue("@sonuc", sonuc);

                    // Sorguyu çalıştır
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("notlar başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ogrnotxt.Clear();
                    
                    derstxt.Clear();
                    vizetxt.Clear();
                    finaltxt.Clear();
                    orttxt.Clear();
                    sonuctxt.Clear();
                }
            }

        }
            }
    }


