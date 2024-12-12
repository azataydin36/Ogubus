using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OgubusApp2
{
    public partial class FormMemurIslemleri : Form
    {
        private readonly string connectionString = "Data Source=DESKTOP-SL0DCJP\\MSSQLSERVER01;Initial Catalog=ogubs;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public FormMemurIslemleri()
        {
            InitializeComponent();
            LoadOgrenciListesi();
            LoadDersler();
        }

        private void LoadOgrenciListesi()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM OgrenciListesi";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewOgrenciListesi.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Öğrenci listesi yüklenirken bir hata oluştu: {ex.Message}");
            }
        }

        private void LoadDersler()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM DerslerTablosu";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewDersler.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Dersler yüklenirken bir hata oluştu: {ex.Message}");
            }
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO OgrenciListesi (Ad, Soyad, TCNo, DogumTarihi, Sinif) " +
                                   "VALUES (@Ad, @Soyad, @TCNo, @DogumTarihi, @Sinif)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Ad", "Yeni");
                    command.Parameters.AddWithValue("@Soyad", "Öğrenci");
                    command.Parameters.AddWithValue("@TCNo", Guid.NewGuid().ToString().Substring(0, 11));
                    command.Parameters.AddWithValue("@DogumTarihi", DateTime.Now);
                    command.Parameters.AddWithValue("@Sinif", "10/A");

                    command.ExecuteNonQuery();
                    MessageBox.Show("Yeni öğrenci eklendi.");
                    LoadOgrenciListesi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Öğrenci eklenirken bir hata oluştu: {ex.Message}");
            }
        }

        private void btnOgrenciSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewOgrenciListesi.SelectedRows.Count > 0)
                {
                    int ogrenciId = Convert.ToInt32(dataGridViewOgrenciListesi.SelectedRows[0].Cells["OgrenciID"].Value);
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM OgrenciListesi WHERE OgrenciID = @OgrenciID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@OgrenciID", ogrenciId);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Seçilen öğrenci silindi.");
                        LoadOgrenciListesi();
                    }
                }
                else
                {
                    MessageBox.Show("Silmek için bir öğrenci seçiniz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Öğrenci silinirken bir hata oluştu: {ex.Message}");
            }
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO DerslerTablosu (DersAdi, Kredi, Ogretmen) VALUES (@DersAdi, @Kredi, @Ogretmen)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@DersAdi", "Yeni Ders");
                    command.Parameters.AddWithValue("@Kredi", 3);
                    command.Parameters.AddWithValue("@Ogretmen", "Öğretmen");

                    command.ExecuteNonQuery();
                    MessageBox.Show("Yeni ders eklendi.");
                    LoadDersler();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ders eklenirken bir hata oluştu: {ex.Message}");
            }
        }

        private void btnDersSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewDersler.SelectedRows.Count > 0)
                {
                    int dersId = Convert.ToInt32(dataGridViewDersler.SelectedRows[0].Cells["DersID"].Value);
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM DerslerTablosu WHERE DersID = @DersID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@DersID", dersId);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Seçilen ders silindi.");
                        LoadDersler();
                    }
                }
                else
                {
                    MessageBox.Show("Silmek için bir ders seçiniz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ders silinirken bir hata oluştu: {ex.Message}");
            }
        }
    }
}
