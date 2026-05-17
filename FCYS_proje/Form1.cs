using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace FCYS_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KayıtFormu frm = new KayıtFormu();
            frm.ShowDialog();
        }

        private void txtKullanici_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click_1(object sender, EventArgs e)
        {
            if (txtKullanici.Text == "" || txtSifre.Text == "" || cmbRol.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun ve rolünüzü seçin!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string secilenRol = cmbRol.SelectedItem.ToString();
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=FCYS_Zeynep_Mdf;AttachDbFilename=|DataDirectory|\FCYS_DB.mdf;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT user_id, rol FROM Kullanicilar WHERE kullanici_adi = @kullaniciAdi AND sifre = @sifre AND rol = @rol";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@kullaniciAdi", txtKullanici.Text);
                cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);
                cmd.Parameters.AddWithValue("@rol", secilenRol);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int userId = Convert.ToInt32(reader["user_id"]);
                        string veritabaniRol = reader["rol"].ToString().Trim();

                        MessageBox.Show($"Hoş geldiniz! {veritabaniRol} olarak giriş yapılıyor...", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();

                        if (veritabaniRol.ToLower() == "freelancer")
                        {
                            FreelancerPanel frmFree = new FreelancerPanel(userId);
                            frmFree.ShowDialog();
                        }
                        else if (veritabaniRol.ToLower() == "müşteri" || veritabaniRol.ToLower() == "musteri")
                        {
                            MusteriPanel frmMusteri = new MusteriPanel(userId);
                            frmMusteri.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Giriş başarısız! Bilgileriniz hatalı veya seçtiğiniz rol hesabınızla uyuşmuyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bağlantı hatası: " + ex.Message, "Sistem Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}