using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OgubusApp2
{
    public partial class FormOgretmenIslemleri : Form
    {
        private readonly string connectionString = "Data Source=DESKTOP-SL0DCJP\\MSSQLSERVER01;Initial Catalog=ogubs;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public FormOgretmenIslemleri()
        {
            InitializeComponent();

            btnGir.Click += btnGir_Click;
            btnOnayla.Click += btnOnayla_Click;
            btnReddet.Click += btnReddet_Click;
        }

        private void FormOgretmenIslemleri_Load(object sender, EventArgs e)
        {
            try
            {
                LoadInitialData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veriler yüklenirken bir hata oluştu: {ex.Message}");
            }
        }

        private void LoadInitialData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT DersKodu, DersAdı, DersKredisi FROM OgrenciDersleri";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewOgrenciDersler.DataSource = dt;
            }
        }

        private void btnGir_Click(object sender, EventArgs e)
        {
            string isimSoyisim = txtIsimSoyisim.Text.Trim();
            if (string.IsNullOrEmpty(isimSoyisim))
            {
                MessageBox.Show("İsim ve soyisim alanı boş bırakılmamalıdır.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT DersKodu, DersAdı, DersKredisi FROM OgrenciDersleri WHERE IsimSoyisim = @IsimSoyisim";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IsimSoyisim", isimSoyisim);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            dataGridViewOgrenciDersler.DataSource = dt;
                            MessageBox.Show($"{isimSoyisim} için dersler ve krediler yüklendi.");
                        }
                        else
                        {
                            MessageBox.Show("Girilen isim ve soyisim bulunamadı.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri çekilirken bir hata oluştu: {ex.Message}");
            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (dataGridViewOgrenciDersler.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewOgrenciDersler.SelectedRows[0];

                if (selectedRow != null && selectedRow.Cells["DersAdı"]?.Value != null) // Seçilen satır kontrolü
                {
                    string ogrenciDersAd = selectedRow.Cells["DersAdı"].Value.ToString();
                    MessageBox.Show($"{ogrenciDersAd} dersi onaylandı.");
                }
                else
                {
                    MessageBox.Show("Seçilen satırda geçersiz bir veri var.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir öğrenci seçin.");
            }
        }

        private void btnReddet_Click(object sender, EventArgs e)
        {
            if (dataGridViewOgrenciDersler.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewOgrenciDersler.SelectedRows[0];

                if (selectedRow != null && selectedRow.Cells["DersAdı"]?.Value != null) // Seçilen satır kontrolü
                {
                    string ogrenciDersAd = selectedRow.Cells["DersAdı"].Value.ToString();
                    MessageBox.Show($"{ogrenciDersAd} dersi reddedildi.");
                }
                else
                {
                    MessageBox.Show("Seçilen satırda geçersiz bir veri var.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir öğrenci seçin.");
            }
        }


        private void FormOgretmenIslemleri_Load_1(object sender, EventArgs e)
        {

        }

        private void FormOgretmenIslemleri_Load_2(object sender, EventArgs e)
        {

        }
    }
}
