
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace ogrenci_takip
{
    public partial class girisekraný : Form
    {
        public girisekraný()
        {
            InitializeComponent();
        }
        string connectionString = "Host=localhost;Port=5432;Database=ogrencitakip;Username=postgres;Password=12345678";
        private void ogrtmnbtn_Click(object sender, EventArgs e)
        {
            string kullanici_adi = ogretmentxt.Text;
            int sifre = Convert.ToInt32(ogrtmnsifretxt.Text);
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM kullanýcý WHERE kullanýcý_adý = @kullanici_adi AND sifre = @sifre";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@kullanici_adi", kullanici_adi);
                    cmd.Parameters.AddWithValue("@sifre", sifre);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Giriþ baþarýlý!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Burada giriþ yapýldýktan sonra yapýlacak iþlemleri ekleyebilirsiniz
                            ogretmen ogretmen = new ogretmen();
                            ogretmen.Show();
                            ogretmentxt.Clear();
                            ogrtmnsifretxt.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Hatalý kullanýcý adý veya þifre.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                }
            }
        }

        private void ogtmniptalbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ogrbtn_Click(object sender, EventArgs e)
        {
            string kullanici_adi = ogrencitxt.Text;
            int sifre = Convert.ToInt32(ogrnsifretxt.Text);
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM kullanýcý WHERE kullanýcý_adý = @kullanici_adi AND sifre = @sifre";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@kullanici_adi", kullanici_adi);
                    cmd.Parameters.AddWithValue("@sifre", sifre);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Giriþ baþarýlý!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Burada giriþ yapýldýktan sonra yapýlacak iþlemleri ekleyebilirsiniz
                            ogrencipaneli ogrencipaneli = new ogrencipaneli();
                            ogrencipaneli.Show();
                            ogrencitxt.Clear();
                            ogrnsifretxt.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Hatalý kullanýcý adý veya þifre.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private void ogriptalbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
