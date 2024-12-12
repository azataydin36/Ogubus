using System;
using System.Windows.Forms;

namespace OgubusApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOgrenciIslemleri_Click(object sender, EventArgs e)
        {
            string isimSoyisim = Prompt("Lütfen isim ve soyisminizi girin:", "Öğrenci İşlemleri");

            if (!string.IsNullOrEmpty(isimSoyisim))
            {
                FormOgrenciDersleri ogrenciForm = new FormOgrenciDersleri(isimSoyisim);
                ogrenciForm.Show();
            }
            else
            {
                MessageBox.Show("İsim ve soyisim boş olamaz.");
            }
        }

        private void btnMemurIslemleri_Click(object sender, EventArgs e)
        {
            FormMemurIslemleri memurForm = new FormMemurIslemleri();
            memurForm.Show();
            this.Hide();
        }

        private void btnOgretmenIslemleri_Click(object sender, EventArgs e)
        {
            FormOgretmenIslemleri ogretmenForm = new FormOgretmenIslemleri();
            ogretmenForm.Show();
        }

        public static string Prompt(string text, string caption)
        {
            Form prompt = new Form
            {
                Width = 400,
                Height = 150,
                Text = caption
            };

            Label textLabel = new Label { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox { Left = 50, Top = 50, Width = 300 };
            Button confirmation = new Button { Text = "Tamam", Left = 150, Width = 100, Top = 80, DialogResult = DialogResult.OK };

            confirmation.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
