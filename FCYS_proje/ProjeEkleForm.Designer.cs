namespace FCYS_proje
{
    partial class ProjeEkleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.txtMusteriId = new System.Windows.Forms.TextBox();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.txtTalep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnProjeKaydet = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpTeslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(222, 83);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(100, 20);
            this.txtBaslik.TabIndex = 0;
            // 
            // txtMusteriId
            // 
            this.txtMusteriId.Location = new System.Drawing.Point(222, 121);
            this.txtMusteriId.Name = "txtMusteriId";
            this.txtMusteriId.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriId.TabIndex = 1;
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(222, 161);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(100, 20);
            this.txtUcret.TabIndex = 2;
            // 
            // txtTalep
            // 
            this.txtTalep.Location = new System.Drawing.Point(222, 251);
            this.txtTalep.Multiline = true;
            this.txtTalep.Name = "txtTalep";
            this.txtTalep.Size = new System.Drawing.Size(200, 75);
            this.txtTalep.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Proje Başlığı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Müşteri ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Proje Ücreti (TL) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Müşteri Talebi / Detay :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnProjeKaydet
            // 
            this.btnProjeKaydet.Location = new System.Drawing.Point(461, 350);
            this.btnProjeKaydet.Name = "btnProjeKaydet";
            this.btnProjeKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnProjeKaydet.TabIndex = 8;
            this.btnProjeKaydet.Text = "Projeyi Ekle";
            this.btnProjeKaydet.UseVisualStyleBackColor = true;
            this.btnProjeKaydet.Click += new System.EventHandler(this.btnProjeKaydet_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Teslim Tarihi";
            // 
            // dtpTeslimTarihi
            // 
            this.dtpTeslimTarihi.Location = new System.Drawing.Point(222, 202);
            this.dtpTeslimTarihi.Name = "dtpTeslimTarihi";
            this.dtpTeslimTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpTeslimTarihi.TabIndex = 10;
            // 
            // ProjeEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpTeslimTarihi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnProjeKaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTalep);
            this.Controls.Add(this.txtUcret);
            this.Controls.Add(this.txtMusteriId);
            this.Controls.Add(this.txtBaslik);
            this.Name = "ProjeEkleForm";
            this.Text = "ProjeEkleForm";
            this.Load += new System.EventHandler(this.ProjeEkleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.TextBox txtMusteriId;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.TextBox txtTalep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnProjeKaydet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpTeslimTarihi;
    }
}