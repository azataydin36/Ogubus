using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OgubusApp2
{
    partial class FormOgretmenIslemleri
    {
        private IContainer components;
        private TextBox txtIsimSoyisim;
        private Button btnGir;
        private Button btnOnayla;
        private Button btnReddet;
        private DataGridView dataGridViewOgrenciDersler;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtIsimSoyisim = new TextBox();
            this.btnGir = new Button();
            this.btnOnayla = new Button();
            this.btnReddet = new Button();
            this.dataGridViewOgrenciDersler = new DataGridView();

            ((ISupportInitialize)(this.dataGridViewOgrenciDersler)).BeginInit();
            this.SuspendLayout();

            // txtIsimSoyisim
            this.txtIsimSoyisim.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtIsimSoyisim.Location = new System.Drawing.Point(20, 20);
            this.txtIsimSoyisim.Size = new System.Drawing.Size(250, 30);

            // btnGir
            this.btnGir.Text = "Dersleri Gör";
            this.btnGir.Location = new Point(280, 20);
            this.btnGir.Size = new Size(100, 30);

            // btnOnayla
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.Location = new Point(150, 320);
            this.btnOnayla.Size = new Size(100, 50);

            // btnReddet
            this.btnReddet.Text = "Reddet";
            this.btnReddet.Location = new Point(270, 320);
            this.btnReddet.Size = new Size(100, 50);

            // dataGridView
            this.dataGridViewOgrenciDersler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOgrenciDersler.Location = new Point(20, 70);
            this.dataGridViewOgrenciDersler.Size = new Size(740, 220);

            this.ClientSize = new Size(800, 400);
            this.Controls.Add(this.txtIsimSoyisim);
            this.Controls.Add(this.btnGir);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.btnReddet);
            this.Controls.Add(this.dataGridViewOgrenciDersler);

            this.Text = "Öğretmen İşlemleri";
            this.StartPosition = FormStartPosition.CenterScreen;

            ((ISupportInitialize)(this.dataGridViewOgrenciDersler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
