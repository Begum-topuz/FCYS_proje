namespace FCYS_proje
{
    partial class FreelancerPanel
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
            this.lblToplamKazanc = new System.Windows.Forms.Label();
            this.lblKasadakiPara = new System.Windows.Forms.Label();
            this.lblBekleyenOdemeler = new System.Windows.Forms.Label();
            this.dgvProjeler = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnReddet = new System.Windows.Forms.Button();
            this.btnKabulEt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjeler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblToplamKazanc
            // 
            this.lblToplamKazanc.AutoSize = true;
            this.lblToplamKazanc.Location = new System.Drawing.Point(181, 103);
            this.lblToplamKazanc.Name = "lblToplamKazanc";
            this.lblToplamKazanc.Size = new System.Drawing.Size(10, 13);
            this.lblToplamKazanc.TabIndex = 0;
            this.lblToplamKazanc.Text = ".";
            // 
            // lblKasadakiPara
            // 
            this.lblKasadakiPara.AutoSize = true;
            this.lblKasadakiPara.Location = new System.Drawing.Point(181, 139);
            this.lblKasadakiPara.Name = "lblKasadakiPara";
            this.lblKasadakiPara.Size = new System.Drawing.Size(10, 13);
            this.lblKasadakiPara.TabIndex = 1;
            this.lblKasadakiPara.Text = ".";
            // 
            // lblBekleyenOdemeler
            // 
            this.lblBekleyenOdemeler.AutoSize = true;
            this.lblBekleyenOdemeler.Location = new System.Drawing.Point(181, 176);
            this.lblBekleyenOdemeler.Name = "lblBekleyenOdemeler";
            this.lblBekleyenOdemeler.Size = new System.Drawing.Size(10, 13);
            this.lblBekleyenOdemeler.TabIndex = 2;
            this.lblBekleyenOdemeler.Text = ".";
            // 
            // dgvProjeler
            // 
            this.dgvProjeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjeler.Location = new System.Drawing.Point(283, 100);
            this.dgvProjeler.Name = "dgvProjeler";
            this.dgvProjeler.Size = new System.Drawing.Size(436, 171);
            this.dgvProjeler.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Yeni Proje Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(74, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Ödeme Onayla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(74, 306);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Durum Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Toplam Kazanç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kasadaki Para";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bekleyen Ödemeler";
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(658, 53);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(75, 23);
            this.btnGeriDon.TabIndex = 10;
            this.btnGeriDon.Text = "Çıkış Yap";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnReddet
            // 
            this.btnReddet.Location = new System.Drawing.Point(601, 306);
            this.btnReddet.Name = "btnReddet";
            this.btnReddet.Size = new System.Drawing.Size(90, 23);
            this.btnReddet.TabIndex = 11;
            this.btnReddet.Text = "Reddet";
            this.btnReddet.UseVisualStyleBackColor = true;
            // 
            // btnKabulEt
            // 
            this.btnKabulEt.Location = new System.Drawing.Point(471, 306);
            this.btnKabulEt.Name = "btnKabulEt";
            this.btnKabulEt.Size = new System.Drawing.Size(90, 23);
            this.btnKabulEt.TabIndex = 12;
            this.btnKabulEt.Text = "Kabul Et";
            this.btnKabulEt.UseVisualStyleBackColor = true;
            this.btnKabulEt.Click += new System.EventHandler(this.button4_Click);
            // 
            // FreelancerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKabulEt);
            this.Controls.Add(this.btnReddet);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvProjeler);
            this.Controls.Add(this.lblBekleyenOdemeler);
            this.Controls.Add(this.lblKasadakiPara);
            this.Controls.Add(this.lblToplamKazanc);
            this.Name = "FreelancerPanel";
            this.Text = "FreelancerPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FreelancerPanel_FormClosing);
            this.Load += new System.EventHandler(this.FreelancerPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblToplamKazanc;
        private System.Windows.Forms.Label lblKasadakiPara;
        private System.Windows.Forms.Label lblBekleyenOdemeler;
        private System.Windows.Forms.DataGridView dgvProjeler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Button btnReddet;
        private System.Windows.Forms.Button btnKabulEt;
    }
}