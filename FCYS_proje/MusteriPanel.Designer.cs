namespace FCYS_proje
{
    partial class MusteriPanel
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
            this.lblMusteriAdSoyad = new System.Windows.Forms.Label();
            this.lblMusteriEPosta = new System.Windows.Forms.Label();
            this.lblMusteriRol = new System.Windows.Forms.Label();
            this.dgvMusteriProjeleri = new System.Windows.Forms.DataGridView();
            this.btnTalepGonder = new System.Windows.Forms.Button();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOdedigimToplam = new System.Windows.Forms.Label();
            this.lblOdememGereken = new System.Windows.Forms.Label();
            this.btnGeriDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriProjeleri)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMusteriAdSoyad
            // 
            this.lblMusteriAdSoyad.AutoSize = true;
            this.lblMusteriAdSoyad.Location = new System.Drawing.Point(130, 107);
            this.lblMusteriAdSoyad.Name = "lblMusteriAdSoyad";
            this.lblMusteriAdSoyad.Size = new System.Drawing.Size(10, 13);
            this.lblMusteriAdSoyad.TabIndex = 0;
            this.lblMusteriAdSoyad.Text = "-";
            // 
            // lblMusteriEPosta
            // 
            this.lblMusteriEPosta.AutoSize = true;
            this.lblMusteriEPosta.Location = new System.Drawing.Point(161, 223);
            this.lblMusteriEPosta.Name = "lblMusteriEPosta";
            this.lblMusteriEPosta.Size = new System.Drawing.Size(10, 13);
            this.lblMusteriEPosta.TabIndex = 1;
            this.lblMusteriEPosta.Text = "-";
            // 
            // lblMusteriRol
            // 
            this.lblMusteriRol.AutoSize = true;
            this.lblMusteriRol.Location = new System.Drawing.Point(130, 144);
            this.lblMusteriRol.Name = "lblMusteriRol";
            this.lblMusteriRol.Size = new System.Drawing.Size(10, 13);
            this.lblMusteriRol.TabIndex = 2;
            this.lblMusteriRol.Text = "-";
            // 
            // dgvMusteriProjeleri
            // 
            this.dgvMusteriProjeleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriProjeleri.Location = new System.Drawing.Point(253, 127);
            this.dgvMusteriProjeleri.Name = "dgvMusteriProjeleri";
            this.dgvMusteriProjeleri.Size = new System.Drawing.Size(452, 150);
            this.dgvMusteriProjeleri.TabIndex = 3;
            // 
            // btnTalepGonder
            // 
            this.btnTalepGonder.Location = new System.Drawing.Point(564, 331);
            this.btnTalepGonder.Name = "btnTalepGonder";
            this.btnTalepGonder.Size = new System.Drawing.Size(141, 23);
            this.btnTalepGonder.TabIndex = 4;
            this.btnTalepGonder.Text = "Yeni Müşteri Talebi Gönder";
            this.btnTalepGonder.UseVisualStyleBackColor = true;
            this.btnTalepGonder.Click += new System.EventHandler(this.btnTalepGonder_Click_1);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(59, 107);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(59, 13);
            this.lblAdSoyad.TabIndex = 5;
            this.lblAdSoyad.Text = "Ad Soyad :";
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Location = new System.Drawing.Point(59, 223);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(91, 13);
            this.lblBakiye.TabIndex = 6;
            this.lblBakiye.Text = "Cüzdan Bakiyesi :";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(59, 144);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(69, 13);
            this.lblRol.TabIndex = 7;
            this.lblRol.Text = "Sistem Rolü :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ödediğim Toplam :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ödemem Gereken :";
            // 
            // lblOdedigimToplam
            // 
            this.lblOdedigimToplam.AutoSize = true;
            this.lblOdedigimToplam.Location = new System.Drawing.Point(161, 264);
            this.lblOdedigimToplam.Name = "lblOdedigimToplam";
            this.lblOdedigimToplam.Size = new System.Drawing.Size(10, 13);
            this.lblOdedigimToplam.TabIndex = 10;
            this.lblOdedigimToplam.Text = "-";
            // 
            // lblOdememGereken
            // 
            this.lblOdememGereken.AutoSize = true;
            this.lblOdememGereken.Location = new System.Drawing.Point(161, 299);
            this.lblOdememGereken.Name = "lblOdememGereken";
            this.lblOdememGereken.Size = new System.Drawing.Size(10, 13);
            this.lblOdememGereken.TabIndex = 11;
            this.lblOdememGereken.Text = "-";
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(656, 66);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(75, 23);
            this.btnGeriDon.TabIndex = 12;
            this.btnGeriDon.Text = "Çıkış Yap";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // MusteriPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.lblOdememGereken);
            this.Controls.Add(this.lblOdedigimToplam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.btnTalepGonder);
            this.Controls.Add(this.dgvMusteriProjeleri);
            this.Controls.Add(this.lblMusteriRol);
            this.Controls.Add(this.lblMusteriEPosta);
            this.Controls.Add(this.lblMusteriAdSoyad);
            this.Name = "MusteriPanel";
            this.Text = "MusteriPanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MusteriPanel_FormClosed);
            this.Load += new System.EventHandler(this.MusteriPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriProjeleri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMusteriAdSoyad;
        private System.Windows.Forms.Label lblMusteriEPosta;
        private System.Windows.Forms.Label lblMusteriRol;
        private System.Windows.Forms.DataGridView dgvMusteriProjeleri;
        private System.Windows.Forms.Button btnTalepGonder;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOdedigimToplam;
        private System.Windows.Forms.Label lblOdememGereken;
        private System.Windows.Forms.Button btnGeriDon;
    }
}