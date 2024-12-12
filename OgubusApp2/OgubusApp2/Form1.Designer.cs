using System.Windows.Forms;

namespace OgubusApp2
{
    partial class Form1
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
            this.btnOgrenciIslemleri = new System.Windows.Forms.Button();
            this.btnMemurIslemleri = new System.Windows.Forms.Button();
            this.btnOgretmenIslemleri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOgrenciIslemleri
            this.btnOgrenciIslemleri.Location = new System.Drawing.Point(13, 195);
            this.btnOgrenciIslemleri.Name = "btnOgrenciIslemleri";
            this.btnOgrenciIslemleri.Size = new System.Drawing.Size(200, 85);
            this.btnOgrenciIslemleri.TabIndex = 1;
            this.btnOgrenciIslemleri.Text = "Öğrenci İşlemleri";
            this.btnOgrenciIslemleri.UseVisualStyleBackColor = true;
            this.btnOgrenciIslemleri.Click += new System.EventHandler(this.btnOgrenciIslemleri_Click);
            // 
            // btnMemurIslemleri
            this.btnMemurIslemleri.Location = new System.Drawing.Point(567, 195);
            this.btnMemurIslemleri.Name = "btnMemurIslemleri";
            this.btnMemurIslemleri.Size = new System.Drawing.Size(200, 85);
            this.btnMemurIslemleri.TabIndex = 2;
            this.btnMemurIslemleri.Text = "Memur İşlemleri";
            this.btnMemurIslemleri.UseVisualStyleBackColor = true;
            this.btnMemurIslemleri.Click += new System.EventHandler(this.btnMemurIslemleri_Click);
            // 
            // btnOgretmenIslemleri
            this.btnOgretmenIslemleri.Location = new System.Drawing.Point(291, 195);
            this.btnOgretmenIslemleri.Name = "btnOgretmenIslemleri";
            this.btnOgretmenIslemleri.Size = new System.Drawing.Size(200, 85);
            this.btnOgretmenIslemleri.TabIndex = 3;
            this.btnOgretmenIslemleri.Text = "Öğretmen İşlemleri";
            this.btnOgretmenIslemleri.UseVisualStyleBackColor = true;
            this.btnOgretmenIslemleri.Click += new System.EventHandler(this.btnOgretmenIslemleri_Click);
            // 
            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(286, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "OGUBUS";
            // 
            // Form1
            this.ClientSize = new System.Drawing.Size(938, 495);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOgrenciIslemleri);
            this.Controls.Add(this.btnMemurIslemleri);
            this.Controls.Add(this.btnOgretmenIslemleri);
            this.Name = "Form1";
            this.Text = "OgubusApp2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnOgrenciIslemleri;
        private System.Windows.Forms.Button btnMemurIslemleri;
        private System.Windows.Forms.Button btnOgretmenIslemleri;
        private System.Windows.Forms.Label label1;
    }
}
