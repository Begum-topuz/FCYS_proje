namespace FCYS_proje
{
    partial class ProjeEkleFormu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProjeBaslik = new System.Windows.Forms.TextBox();
            this.txtButce = new System.Windows.Forms.TextBox();
            this.btnTalepGonder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMusteriTalebi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTeslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbFreelancerlar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proje Başlığı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bütçe (TL) :";
            // 
            // txtProjeBaslik
            // 
            this.txtProjeBaslik.Location = new System.Drawing.Point(164, 64);
            this.txtProjeBaslik.Name = "txtProjeBaslik";
            this.txtProjeBaslik.Size = new System.Drawing.Size(100, 20);
            this.txtProjeBaslik.TabIndex = 2;
            // 
            // txtButce
            // 
            this.txtButce.Location = new System.Drawing.Point(164, 105);
            this.txtButce.Name = "txtButce";
            this.txtButce.Size = new System.Drawing.Size(100, 20);
            this.txtButce.TabIndex = 3;
            // 
            // btnTalepGonder
            // 
            this.btnTalepGonder.Location = new System.Drawing.Point(554, 333);
            this.btnTalepGonder.Name = "btnTalepGonder";
            this.btnTalepGonder.Size = new System.Drawing.Size(139, 23);
            this.btnTalepGonder.TabIndex = 4;
            this.btnTalepGonder.Text = "Talebi Gönder";
            this.btnTalepGonder.UseVisualStyleBackColor = true;
            this.btnTalepGonder.Click += new System.EventHandler(this.btnTalepGonder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Talep :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtMusteriTalebi
            // 
            this.txtMusteriTalebi.Location = new System.Drawing.Point(164, 190);
            this.txtMusteriTalebi.Multiline = true;
            this.txtMusteriTalebi.Name = "txtMusteriTalebi";
            this.txtMusteriTalebi.Size = new System.Drawing.Size(264, 97);
            this.txtMusteriTalebi.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Teslim Tarihi :";
            // 
            // dtpTeslimTarihi
            // 
            this.dtpTeslimTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTeslimTarihi.Location = new System.Drawing.Point(164, 151);
            this.dtpTeslimTarihi.Name = "dtpTeslimTarihi";
            this.dtpTeslimTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpTeslimTarihi.TabIndex = 9;
            // 
            // cmbFreelancerlar
            // 
            this.cmbFreelancerlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFreelancerlar.FormattingEnabled = true;
            this.cmbFreelancerlar.Location = new System.Drawing.Point(191, 304);
            this.cmbFreelancerlar.Name = "cmbFreelancerlar";
            this.cmbFreelancerlar.Size = new System.Drawing.Size(121, 21);
            this.cmbFreelancerlar.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Freelancer Seçin :";
            // 
            // ProjeEkleFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbFreelancerlar);
            this.Controls.Add(this.dtpTeslimTarihi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMusteriTalebi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTalepGonder);
            this.Controls.Add(this.txtButce);
            this.Controls.Add(this.txtProjeBaslik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProjeEkleFormu";
            this.Text = "ProjeEkleFormu";
            this.Load += new System.EventHandler(this.ProjeEkleFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProjeBaslik;
        private System.Windows.Forms.TextBox txtButce;
        private System.Windows.Forms.Button btnTalepGonder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMusteriTalebi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTeslimTarihi;
        private System.Windows.Forms.ComboBox cmbFreelancerlar;
        private System.Windows.Forms.Label label5;
    }
}