using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OgubusApp2
{
    public partial class FormOgrenciDersleri : Form
    {
        private List<Ders> tumDersler = new List<Ders>();
        private List<Ders> secilenDersler = new List<Ders>();
        private string isimSoyisim;

        public FormOgrenciDersleri(string isimSoyisim)
        {
            this.isimSoyisim = isimSoyisim;
            InitializeComponent();
            TumDersleriListele();

            btnDersEkle.Click += btnDersEkle_Click;
            btnDersSil.Click += btnDersSil_Click;
            btnTamamla.Click += btnTamamla_Click;
        }

        private void TumDersleriListele()
        {
            tumDersler = new List<Ders>
            {
                new Ders { DersAdı = "Bilgisayar Programcılığı", DersKodu = "CS101", DersKredisi = 3 },
                new Ders { DersAdı = "Veritabanı Yönetimi", DersKodu = "DB102", DersKredisi = 4 },
                new Ders { DersAdı = "Algoritmalar", DersKodu = "ALG103", DersKredisi = 3 },
                new Ders { DersAdı = "Ağ Teknolojileri", DersKodu = "NET201", DersKredisi = 3 },
                new Ders { DersAdı = "Yapay Zeka", DersKodu = "AI301", DersKredisi = 4 },
                new Ders { DersAdı = "Mobil Uygulama Geliştirme", DersKodu = "MOB202", DersKredisi = 3 },
                new Ders { DersAdı = "Web Programlama", DersKodu = "WEB103", DersKredisi = 3 }
            };

            dataGridViewTumDersler.DataSource = tumDersler;
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            if (dataGridViewTumDersler.SelectedRows.Count > 0)
            {
                var ders = dataGridViewTumDersler.SelectedRows[0].DataBoundItem as Ders;
                if (ders != null && !secilenDersler.Contains(ders))
                {
                    secilenDersler.Add(ders);

                    dataGridViewSecilenDersler.DataSource = null;
                    dataGridViewSecilenDersler.DataSource = secilenDersler;
                }
            }
        }

        private void btnDersSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewSecilenDersler.SelectedRows.Count > 0)
            {
                var ders = dataGridViewSecilenDersler.SelectedRows[0].DataBoundItem as Ders;
                if (ders != null)
                {
                    secilenDersler.Remove(ders);

                    dataGridViewSecilenDersler.DataSource = null;
                    dataGridViewSecilenDersler.DataSource = secilenDersler;
                }
            }
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-SL0DCJP\\MSSQLSERVER01;Initial Catalog=ogubs;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    foreach (var ders in secilenDersler)
                    {
                        string query = "INSERT INTO OgrenciDersleri (IsimSoyisim, DersKodu, DersAdı, DersKredisi) VALUES (@IsimSoyisim, @DersKodu, @DersAdı, @DersKredisi)";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@IsimSoyisim", isimSoyisim);
                            command.Parameters.AddWithValue("@DersKodu", ders.DersKodu);
                            command.Parameters.AddWithValue("@DersAdı", ders.DersAdı);
                            command.Parameters.AddWithValue("@DersKredisi", ders.DersKredisi);

                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Veriler başarıyla kaydedildi.");
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri kaydedilirken bir hata oluştu: {ex.Message}");
            }
        }

        private void FormOgrenciDersleri_Load(object sender, EventArgs e)
        {
        }

        private void FormOgrenciDersleri_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ogubsDataSet1.OgrenciIslemleri' table. You can move, or remove it, as needed.
            this.ogrenciIslemleriTableAdapter.Fill(this.ogubsDataSet1.OgrenciIslemleri);

        }
    }
}
