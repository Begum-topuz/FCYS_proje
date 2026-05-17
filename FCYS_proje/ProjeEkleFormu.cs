using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FCYS_proje
{
    public partial class ProjeEkleFormu : Form
    {
        private int aktifMusteriId;
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=FCYS_Zeynep_Mdf;AttachDbFilename=|DataDirectory|\FCYS_DB.mdf;Integrated Security=True;";
        public ProjeEkleFormu(int musteriId)
        {
            InitializeComponent();
            this.aktifMusteriId = musteriId;
            FreelancerlariGetir();
        }
        
            private void FreelancerlariGetir()
        {
            string query = "SELECT user_id, kullanici_adi FROM Kullanicilar WHERE rol = 'Freelancer'";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                try
                {
                    da.Fill(dt);
                    cmbFreelancerlar.DataSource = dt;
                    cmbFreelancerlar.DisplayMember = "kullanici_adi";
                    cmbFreelancerlar.ValueMember = "user_id";         
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Freelancer listesi yüklenirken hata oluştu: " + ex.Message);
                }
            }
        }

        private void btnTalepGonder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProjeBaslik.Text) || string.IsNullOrEmpty(txtButce.Text) || string.IsNullOrEmpty(txtMusteriTalebi.Text) || cmbFreelancerlar.SelectedValue == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz ve bir Freelancer seçiniz!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "INSERT INTO Projeler (baslik, toplam_ucret, durum, musteri_id, freelancer_id, musteri_talebi, teslim_tarihi) " +
                               "VALUES (@baslik, @ucret, @durum, @musteriId, @freelancerId, @talep, @tarih)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@baslik", txtProjeBaslik.Text);
                cmd.Parameters.AddWithValue("@ucret", Convert.ToDecimal(txtButce.Text));
                cmd.Parameters.AddWithValue("@durum", "Onay Bekliyor");
                cmd.Parameters.AddWithValue("@musteriId", this.aktifMusteriId);
                cmd.Parameters.AddWithValue("@freelancerId", cmbFreelancerlar.SelectedValue);
                cmd.Parameters.AddWithValue("@talep", txtMusteriTalebi.Text);
                cmd.Parameters.AddWithValue("@tarih", dtpTeslimTarihi.Value);

                try
                {
                    conn.Open();
                    int sonuc = cmd.ExecuteNonQuery();

                    if (sonuc > 0)
                    {
                        MessageBox.Show("Proje talebiniz başarıyla seçtiğiniz freelancer'a iletildi!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Proje eklenirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ProjeEkleFormu_Load(object sender, EventArgs e)
        {

        }
    }
}