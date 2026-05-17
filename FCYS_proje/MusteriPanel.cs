using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FCYS_proje
{
    public partial class MusteriPanel : Form
    {
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=FCYS_Zeynep_Mdf;AttachDbFilename=|DataDirectory|\FCYS_DB.mdf;Integrated Security=True;";
        private int logginedMusteriId;

        public MusteriPanel(int musteriId)
        {
            InitializeComponent();
            this.logginedMusteriId = musteriId;
        }

        private void MusteriPanel_Load(object sender, EventArgs e)
        {
            MusteriProfiliniGetir();
            ProjeleriListele();
        }

        public void ProjeleriListele()
        {
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=FCYS_Zeynep_Mdf;AttachDbFilename=|DataDirectory|\FCYS_DB.mdf;Integrated Security=True;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = "SELECT proje_id, baslik, toplam_ucret, durum, teslim_tarihi FROM Projeler WHERE musteri_id = @id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", logginedMusteriId);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvMusteriProjeleri.DataSource = null;
                    dgvMusteriProjeleri.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Projeler listelenirken hata oluştu: " + ex.Message);
            }
        }

        private void MusteriProfiliniGetir()
        {
            string queryProfil = "SELECT kullanici_adi, cuzdan_bakiyesi, rol FROM Kullanicilar WHERE user_id = @id";
            string queryOdedigim = "SELECT SUM(toplam_ucret) FROM Projeler WHERE musteri_id = @id AND durum = 'Tamamlandı'";
            string queryOdememGereken = "SELECT SUM(toplam_ucret) FROM Projeler WHERE musteri_id = @id AND (durum = 'Devam Ediyor' OR durum = 'Beklemede' OR durum = 'Onay Bekliyor') AND durum != 'Süresi Doldu'";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmdProfil = new SqlCommand(queryProfil, conn);
                    cmdProfil.Parameters.AddWithValue("@id", logginedMusteriId);

                    SqlDataReader dr = cmdProfil.ExecuteReader();
                    if (dr.Read())
                    {
                        lblAdSoyad.Text = "Ad Soyad : " + dr["kullanici_adi"].ToString();
                        lblBakiye.Text = "Cüzdan Bakiyesi : " + Convert.ToDecimal(dr["cuzdan_bakiyesi"]).ToString("C2");
                        lblRol.Text = "Sistem Rolü : " + dr["rol"].ToString();
                    }
                    dr.Close();

                    SqlCommand cmdOdedigim = new SqlCommand(queryOdedigim, conn);
                    cmdOdedigim.Parameters.AddWithValue("@id", logginedMusteriId);
                    object objOdedigim = cmdOdedigim.ExecuteScalar();

                    decimal odedigimToplam = (objOdedigim == DBNull.Value || objOdedigim == null) ? 0 : Convert.ToDecimal(objOdedigim);
                    lblOdedigimToplam.Text = odedigimToplam.ToString("C2");

                    SqlCommand cmdOdememGereken = new SqlCommand(queryOdememGereken, conn);
                    cmdOdememGereken.Parameters.AddWithValue("@id", logginedMusteriId);
                    object objOdemem = cmdOdememGereken.ExecuteScalar();

                    decimal odememGereken = (objOdemem == DBNull.Value || objOdemem == null) ? 0 : Convert.ToDecimal(objOdemem);
                    lblOdememGereken.Text = odememGereken.ToString("C2");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Finansal özet yüklenirken hata oluştu: " + ex.Message);
                }
            }
        }

        public void MusteriProjeleriniListele()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = "SELECT proje_id, baslik, toplam_ucret, durum, teslim_tarihi FROM Projeler WHERE musteri_id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", logginedMusteriId);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvMusteriProjeleri.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Projeleriniz yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void btnTalepGonder_Click(object sender, EventArgs e)
        {
            ProjeEkleForm frm = new ProjeEkleForm();
            frm.ShowDialog();
            MusteriProjeleriniListele();
        }

        private void btnYeniProjeEkle_Click(object sender, EventArgs e)
        {
            ProjeEkleFormu frm = new ProjeEkleFormu(logginedMusteriId);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                MusteriProfiliniGetir();
            }
        }

        private void btnTalepGonder_Click_1(object sender, EventArgs e)
        {
            ProjeEkleFormu frm = new ProjeEkleFormu(logginedMusteriId);
            frm.ShowDialog();
            ProjeleriListele();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            Form girisFormu = Application.OpenForms["Form1"];

            if (girisFormu != null)
            {
                girisFormu.Show();
                this.Close();      
            }
        }

        private void MusteriPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Application.OpenForms["Form1"].Visible)
            {
                Application.Exit();
            }
        }
    }
}