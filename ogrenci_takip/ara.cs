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
    public partial class ara : Form
    {
        public ara()
        {
            InitializeComponent();
        }
        string connectionString = "Host=localhost;Port=5432;Database=ogrencitakip;Username=postgres;Password=12345678";
        private void arabtn_Click(object sender, EventArgs e)
        {
            int ogrno = Convert.ToInt16(ogrnotxt.Text.Trim());
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ad, soyad FROM ogrenci WHERE ogrno = @ogrno";
              
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                  
                    cmd.Parameters.AddWithValue("@ogrno", ogrno);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {

                        if (reader.Read())
                        {
                            adtxt.Text = reader["ad"].ToString();
                            soyadtxt.Text = reader["soyad"].ToString();
                            
                          
                         
                        }
                    }

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
