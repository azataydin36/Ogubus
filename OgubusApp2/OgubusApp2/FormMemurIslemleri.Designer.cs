using System;
using System.Windows.Forms;

namespace OgubusApp2
{
    partial class FormMemurIslemleri
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.btnOgrenciSil = new System.Windows.Forms.Button();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.btnDersSil = new System.Windows.Forms.Button();
            this.dataGridViewOgrenciListesi = new System.Windows.Forms.DataGridView();
            this.dataGridViewDersler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgrenciListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDersler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Location = new System.Drawing.Point(30, 402);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(150, 50);
            this.btnOgrenciEkle.TabIndex = 1;
            this.btnOgrenciEkle.Text = "Öğrenci Ekle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // btnOgrenciSil
            // 
            this.btnOgrenciSil.Location = new System.Drawing.Point(220, 402);
            this.btnOgrenciSil.Name = "btnOgrenciSil";
            this.btnOgrenciSil.Size = new System.Drawing.Size(150, 50);
            this.btnOgrenciSil.TabIndex = 2;
            this.btnOgrenciSil.Text = "Öğrenci Sil";
            this.btnOgrenciSil.UseVisualStyleBackColor = true;
            this.btnOgrenciSil.Click += new System.EventHandler(this.btnOgrenciSil_Click);
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.Location = new System.Drawing.Point(30, 493);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(150, 50);
            this.btnDersEkle.TabIndex = 3;
            this.btnDersEkle.Text = "Ders Ekle";
            this.btnDersEkle.UseVisualStyleBackColor = true;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // btnDersSil
            // 
            this.btnDersSil.Location = new System.Drawing.Point(220, 493);
            this.btnDersSil.Name = "btnDersSil";
            this.btnDersSil.Size = new System.Drawing.Size(150, 50);
            this.btnDersSil.TabIndex = 4;
            this.btnDersSil.Text = "Ders Sil";
            this.btnDersSil.UseVisualStyleBackColor = true;
            this.btnDersSil.Click += new System.EventHandler(this.btnDersSil_Click);
            // 
            // dataGridViewOgrenciListesi
            // 
            this.dataGridViewOgrenciListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOgrenciListesi.Location = new System.Drawing.Point(30, 50);
            this.dataGridViewOgrenciListesi.Name = "dataGridViewOgrenciListesi";
            this.dataGridViewOgrenciListesi.RowHeadersWidth = 51;
            this.dataGridViewOgrenciListesi.Size = new System.Drawing.Size(500, 150);
            this.dataGridViewOgrenciListesi.TabIndex = 5;
            this.dataGridViewOgrenciListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOgrenciListesi_CellContentClick);
            // 
            // dataGridViewDersler
            // 
            this.dataGridViewDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDersler.Location = new System.Drawing.Point(30, 220);
            this.dataGridViewDersler.Name = "dataGridViewDersler";
            this.dataGridViewDersler.RowHeadersWidth = 51;
            this.dataGridViewDersler.Size = new System.Drawing.Size(500, 150);
            this.dataGridViewDersler.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(200, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Memur İşlemleri Paneli";
            // 
            // FormMemurIslemleri
            // 
            this.ClientSize = new System.Drawing.Size(760, 576);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDersler);
            this.Controls.Add(this.dataGridViewOgrenciListesi);
            this.Controls.Add(this.btnDersSil);
            this.Controls.Add(this.btnDersEkle);
            this.Controls.Add(this.btnOgrenciSil);
            this.Controls.Add(this.btnOgrenciEkle);
            this.Name = "FormMemurIslemleri";
            this.Text = "Memur İşlemleri";
            this.Load += new System.EventHandler(this.FormMemurIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgrenciListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDersler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dataGridViewOgrenciListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FormMemurIslemleri_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.Button btnOgrenciSil;
        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.Button btnDersSil;
        private System.Windows.Forms.DataGridView dataGridViewOgrenciListesi;
        private System.Windows.Forms.DataGridView dataGridViewDersler;
        private System.Windows.Forms.Label label1;
    }
}
