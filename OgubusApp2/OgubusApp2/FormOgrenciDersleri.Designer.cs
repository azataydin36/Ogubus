using System.Windows.Forms;

namespace OgubusApp2
{
    public partial class FormOgrenciDersleri : Form
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewTumDersler = new System.Windows.Forms.DataGridView();
            this.dataGridViewSecilenDersler = new System.Windows.Forms.DataGridView();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.btnDersSil = new System.Windows.Forms.Button();
            this.btnTamamla = new System.Windows.Forms.Button();
            this.ogubsDataSet1 = new OgubusApp2.ogubsDataSet1();
            this.ogrenciIslemleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciIslemleriTableAdapter = new OgubusApp2.ogubsDataSet1TableAdapters.OgrenciIslemleriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTumDersler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecilenDersler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogubsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciIslemleriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTumDersler
            // 
            this.dataGridViewTumDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTumDersler.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTumDersler.Name = "dataGridViewTumDersler";
            this.dataGridViewTumDersler.RowHeadersWidth = 51;
            this.dataGridViewTumDersler.Size = new System.Drawing.Size(400, 250);
            this.dataGridViewTumDersler.TabIndex = 0;
            // 
            // dataGridViewSecilenDersler
            // 
            this.dataGridViewSecilenDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSecilenDersler.Location = new System.Drawing.Point(420, 12);
            this.dataGridViewSecilenDersler.Name = "dataGridViewSecilenDersler";
            this.dataGridViewSecilenDersler.RowHeadersWidth = 51;
            this.dataGridViewSecilenDersler.Size = new System.Drawing.Size(400, 250);
            this.dataGridViewSecilenDersler.TabIndex = 1;
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.Location = new System.Drawing.Point(302, 300);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(75, 23);
            this.btnDersEkle.TabIndex = 2;
            this.btnDersEkle.Text = "Ders Ekle";
            // 
            // btnDersSil
            // 
            this.btnDersSil.Location = new System.Drawing.Point(420, 300);
            this.btnDersSil.Name = "btnDersSil";
            this.btnDersSil.Size = new System.Drawing.Size(75, 23);
            this.btnDersSil.TabIndex = 3;
            this.btnDersSil.Text = "Ders Sil";
            // 
            // btnTamamla
            // 
            this.btnTamamla.Location = new System.Drawing.Point(540, 300);
            this.btnTamamla.Name = "btnTamamla";
            this.btnTamamla.Size = new System.Drawing.Size(75, 23);
            this.btnTamamla.TabIndex = 4;
            this.btnTamamla.Text = "Tamamla";
            // 
            // ogubsDataSet1
            // 
            this.ogubsDataSet1.DataSetName = "ogubsDataSet1";
            this.ogubsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciIslemleriBindingSource
            // 
            this.ogrenciIslemleriBindingSource.DataMember = "OgrenciIslemleri";
            this.ogrenciIslemleriBindingSource.DataSource = this.ogubsDataSet1;
            // 
            // ogrenciIslemleriTableAdapter
            // 
            this.ogrenciIslemleriTableAdapter.ClearBeforeFill = true;
            // 
            // FormOgrenciDersleri
            // 
            this.ClientSize = new System.Drawing.Size(997, 473);
            this.Controls.Add(this.dataGridViewTumDersler);
            this.Controls.Add(this.dataGridViewSecilenDersler);
            this.Controls.Add(this.btnDersEkle);
            this.Controls.Add(this.btnDersSil);
            this.Controls.Add(this.btnTamamla);
            this.Name = "FormOgrenciDersleri";
            this.Text = "Öğrenci Ders İşlemleri";
            this.Load += new System.EventHandler(this.FormOgrenciDersleri_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTumDersler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecilenDersler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogubsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciIslemleriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private DataGridView dataGridViewTumDersler;
        private DataGridView dataGridViewSecilenDersler;
        private Button btnDersEkle;
        private Button btnDersSil;
        private Button btnTamamla;
        private ogubsDataSet1 ogubsDataSet1;
        private BindingSource ogrenciIslemleriBindingSource;
        private ogubsDataSet1TableAdapters.OgrenciIslemleriTableAdapter ogrenciIslemleriTableAdapter;
    }
}
