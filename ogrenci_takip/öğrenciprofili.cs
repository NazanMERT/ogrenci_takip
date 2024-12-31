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
    public partial class öğrenciprofili : Form
    {
        public öğrenciprofili()
        {
            InitializeComponent();
        }
        string connectionString = "Host=localhost;Port=5432;Database=ogrencitakip;Username=postgres;Password=12345678";
        private void anasayfabtn_Click(object sender, EventArgs e)
        {
            ogrencipaneli ogrencipaneli = new ogrencipaneli();
            ogrencipaneli.Show();
            this.Hide();


        }

        private void cikisbtn_Click(object sender, EventArgs e)
        {
            girisekranı girisekranı = new girisekranı();
            girisekranı.Show();
            this.Hide();
        }

        private void bilgibtn_Click(object sender, EventArgs e)
        {
           string derskodu = derstxt.Text;
            int ogrno = Convert.ToInt32(ogrnotxt.Text);
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT bolumid,sinif FROM ogrenci WHERE ogrno = @ogrno";
                
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ogrno", ogrno);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {                                                    
                            bolumtxt.Text = reader["bolumid"].ToString();
                            siniftxt.Text = reader["sinif"].ToString();
                           // ogrnotxt.Text = reader["ogrno"].ToString();                                                 
                        }
                    }

                }
                string query1 = "Select vize,final,ortalama,sonuc from ogrnot where dersid=@derskodu and ogrno = @ogrno";
                using (NpgsqlCommand cmd1 = new NpgsqlCommand(query1, conn))
                {
                    cmd1.Parameters.AddWithValue("@derskodu", derskodu);
                    cmd1.Parameters.AddWithValue("@ogrno", ogrno);
                    using (NpgsqlDataReader reader = cmd1.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            vizetxt.Text = reader["vize"].ToString();
                            finaltxt.Text = reader["final"].ToString();
                            orttxt.Text = reader["ortalama"].ToString();
                            sonuctxt.Text = reader["sonuc"].ToString();

                        }


                    }
                }

            }
        }
    }
}
